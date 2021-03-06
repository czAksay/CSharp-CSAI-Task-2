﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace superai2
{
    class Ai
    {
        string filePath;
        List<Parameter> mparams = new List<Parameter>();
        List<Function> mfunc = new List<Function>();
        FunctionSolution funcsol;
        String answer;
        List<Function> bannedf;
        List<Parameter> bannedp;
        bool remAns;
        int debug;
        public string Name { get { return "Пожилой интеллект";  } }
        public string Hello { get { return "Слушаю?";  } }
        public bool RememberAnswer { get { return remAns; }
            set
            {
                remAns = value;
                foreach (var p in mparams)
                {
                    p.Remember = value;
                }
            }
        }

        public bool NecessaryFind { get; set; }

        private void RemoveSpaces(ref String[] list)
        {
            for (int i = 0; i < list.Length; i ++)
            {
                int ind;
                if (list[i] == "")
                    continue;
                String curr = list[i];
                while ((ind = curr.IndexOf(' ')) == 0)
                {
                    curr = curr.Remove(0, 1);
                }
                while (curr[curr.Length-1] == ' ')
                {
                    curr = curr.Remove(curr.Length - 1, 1);
                }
                list[i] = curr;
            }
        }

        public Ai (string path)
        {
            if (File.Exists(path))
            {
                filePath = path;
                StreamReader sr = new StreamReader(filePath, Encoding.Default, true, 128);
                String fileText = sr.ReadToEnd();
                fileText = fileText.Replace("\r", "");
                String varPart, funcPart;
                varPart = fileText.Substring(fileText.IndexOf("#1")+3, fileText.IndexOf("#2") - 3);
                foreach (String line in varPart.Split('\n'))
                {
                    if (line == "" || line.IndexOf("//") == 0)
                        continue;
                    String[] splitted = line.Split(':');
                    RemoveSpaces(ref splitted);
                    if (line != "" && splitted.Length >= 3)
                    {
                        mparams.Add(new Parameter(Int32.Parse(splitted[0]), splitted[1], splitted[2]));
                    }
                }
                funcPart = fileText.Substring(fileText.IndexOf("#2") + 3, fileText.Length - fileText.IndexOf("#2") - 3);
                foreach (String line in funcPart.Split('\n'))
                {
                    if (line == "" || line.IndexOf("//") == 0)
                        continue;
                    int eqInd = line.IndexOf('=');
                    int br1Ind = line.IndexOf('(');
                    int br2Ind = line.IndexOf(')');
                    int colonInd = line.IndexOf(':');
                    int lng = line.Length;
                    String toFind = line.Substring(0, eqInd);
                    String id = line.Substring(eqInd + 1, br1Ind - eqInd -  1);
                    String name = line.Substring(colonInd + 1, lng - colonInd - 1);
                    String[] paramms = line.Substring(br1Ind + 1, br2Ind - br1Ind - 1).Split(',');
                    RemoveSpaces(ref paramms);
                    Parameter parToFind = GetParById(toFind);
                    if (parToFind == null)
                        throw new Exception("No such parameter "+toFind);
                    Parameter[] fParams = new Parameter[paramms.Length];
                    for (int i = 0; i < paramms.Length; i++)
                    {
                        fParams[i] = GetParById(paramms[i]);
                        if (fParams[i] == null)
                            throw new Exception("No such parameter " + paramms[i]);
                    }
                    mfunc.Add(new Function(id, name, parToFind, fParams));
                }
                funcsol = new FunctionSolution(this);
                NecessaryFind = false;
                bannedp = new List<Parameter>();
                bannedf = new List<Function>();
                sr.Close();
                RememberAnswer = false;
                debug = 0;
            }
            else
            {
                throw new Exception("Not such file.");
            }
        }

        public String[] GetFuncList()
        {
            String[] list = new string[mfunc.Count];
            for (int i = 0; i < mfunc.Count; i++)
            {
                list[i] = mfunc[i].Id;
            }
            return list;
        }

        public Function GetFuncById(String id)
        {
            foreach (var f in mfunc)
            {
                if (f.Id == id)
                {
                    return f;
                }
            }
            return null;
        }

        public String[] GetParamsList()
        {
            String[] list = new string[mparams.Count];
            for (int i = 0; i < mparams.Count; i++)
            {
                list[i] = mparams[i].Id;
            }
            return list;
        }

        public void SetValue(String id, String value)
        {
            bool tmp = RememberAnswer;
            RememberAnswer = true;
            String[] idvalue = new string[] { id, value };
            RemoveSpaces(ref idvalue);
            Parameter p = GetParById(idvalue[0]);
            if (p == null)
                throw new Exception("Cant find parameter with id "+idvalue[0]);
            else
            {
                p.Value = Double.Parse(idvalue[1]);
            }
            RememberAnswer = tmp;
        }

        public Parameter GetParById(String id)
        {
            foreach (var p in mparams)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }
            return null;
        }

        private Function[] GetFunctionByParameterToFind(String param)
        {
            List<Function> ret = new List<Function>();
            foreach (Function f in mfunc)
            {
                if (f.ToFind.Id == param)
                    ret.Add(f);
            }
            return ret.ToArray();
        }

        private String ParamToNormalForm(Parameter p)
        {
            return p.Id + " (" + p.Name + ")";
        }

        private void Ban(Function f)
        {
            bannedf.Add(f);
        }

        private void UnBan(Function f)
        {
            bannedf.Remove(f);
        }

        private bool isBanned(Function f)
        {
            foreach (Function b in bannedf)
            {
                if (f == b)
                    return true;
            }
            return false;
        }

        //Вовзращает, можно ли вычислить данный параметр.
        //В каждый вызов метода вкладывается список, который будет наполняться функциями, которые были использованы
        private bool Find_S(String id, List<String> modules)
        {
            bool functionCanBeUsed;
            debug++;
            //берем функции, необходимые для нахождения данного параметра.
            //если хотя бы одна из них подходит - параметр можно найти. Значит вернем true
            Function[] neededfuncs = GetFunctionByParameterToFind(id);
            //Список цепочек для получения параметра
            List<List<String>> myModules = new List<List<string>>();
            //Очередная цепочка для добавления в myModules
            List<String> newModule = new List<string>();
            //если функций для нахождения нет - значит найти нельзя.
            if (neededfuncs.Length > 0)
            {
                //проверяем каждую функцию
                foreach (Function neededfunc in neededfuncs)
                {
                    newModule = new List<string>();
                    newModule.Add(neededfunc.Id);
                    if (isBanned(neededfunc))
                        continue;
                    //modules.Add(neededfunc.Id);
                    //изначально определяем, что функция нам подходит для поиска параметра.
                    functionCanBeUsed = true;
                    //смотрим зависимые параметры функции для нахождения искомого параметра.
                    foreach (Parameter p in neededfunc.Params)
                    {
                        //каждый из них должен быть известен или находится.
                        //Если параметр неизвестен...
                        if (!p.Found && !p.TempFound)
                        {
                            //ну эта бан блять
                            Ban(neededfunc);
                            //...и не может быть найден - прекращаем анализ этой функции, она нам не подходит.
                            if (!Find_S(p.Id, newModule))
                            {
                                functionCanBeUsed = false;
                                UnBan(neededfunc);
                                break;
                            }
                            debug--;
                            //опа разбанил
                            UnBan(neededfunc);
                        }
                    }
                    //если данная функция нам подходит для нахождения параметра - дальнейшие функции рассматривать 
                    //не имеет смысла.
                    if (functionCanBeUsed)
                    {
                        //Ban(neededfunc);
                        myModules.Add(newModule);
                        //UnBan(neededfunc);
                    }
                }
            }
            else
            {
                //answer += "\nНахождение "+ParamToNormalForm(GetParById(id)) + " невозможно: отсутствуют модули, в которых он участвует.";
                return false;
            }
            if (myModules.Count > 0)
            {
                List<String> toAdd = myModules[0];
                foreach(var m in myModules)
                {
                    if (m.Count < toAdd.Count)
                    {
                        toAdd = m;
                    }
                }
                //if (needToFindSolution)
                //    funcsol.Run(toAdd[0]);
                
                //GetFuncById(toAdd[0]).ToFind.SetFound();
                modules.AddRange(toAdd);
                return true;
            }
            //answer += "\nНахождение " + ParamToNormalForm(GetParById(id)) + " невозможно: недостаточно известных данных для " + (neededfuncs.Length > 1 ? "модулей." : "модуля.");
            return false;
        }

        public String Find(String id)
        {
            bannedf.Clear();
            bannedp.Clear();
            answer = "";
            Parameter needed = GetParById(id);
            List<String> modules = new List<string>();
            //solutionFound = true;
            if (needed == null)
                throw new Exception("Cant find parameter with id " + id);
            if (needed.Found && !NecessaryFind)
            {
                answer = "А зачем тебе его находить? Ты же знаешь, что " + id + " = " + needed.Value + ".";
                return answer;
            }
            else
            {
                answer = "А-а-а, значит так:";

                if (Find_S(id, modules))
                {
                    answer += "\nЦепочка модулей: ";
                    //while (modules.Count > 1)
                    //{
                    //    answer += modules.Pop() + " -> ";
                    //}
                    modules.Reverse();
                    modules = modules.Distinct().ToList();
                    //IEnumerable<String> dmodules = modules.Distinct();
                    //modules = dmodules.ToList();
                    foreach(var s in modules)//for (int i = modules.Count - 1; i >= 0; i--)
                    {
                        answer += s + " -> ";
                    }
                    answer = answer.Remove(answer.Length - 4);
                    //if (modules.Count > 0)
                    //    answer += modules.Pop();
                    answer += "\nРешено.";
                }
                else
                {
                    answer += "\nРешить это я не в состоянии.";
                }
            }
            return answer;
        }

        public String Calc(String id)
        {
            String answer = "";
            bannedf.Clear();
            bannedp.Clear();
            Parameter needed = GetParById(id);
            List<String> modules = new List<string>();
            if (needed == null)
                throw new Exception("Cant find parameter with id " + id);
            if (needed.Found)
                answer = "Мы уже знаем, что " + ParamToNormalForm(needed) + " = " + needed.Value + ".";
            else
            {
                answer = "Легко.\n";
                try
                {
                    if (Find_S(id, modules))
                    {
                        for (int i = modules.Count - 1; i >= 0; i--)
                        {
                            funcsol.Run(modules[i]);
                        }
                        answer += ParamToNormalForm(needed) + " = " + needed.Value + ".";
                        ForgetValues();
                    }
                    else
                    {
                        answer += "Понятия не имею, как это решать.";
                    }
                }
                catch (Exception ex)
                {
                    answer += "В общем, дело такое: " + ex.Message + " Зовите меня Old Rabbit.";
                    return answer;
                }
            }
            return answer;
        }

        private void ForgetValues()
        {
            foreach (var p in mparams)
                p.TempFound = false;
        }

        private String ParamsToString(Parameter[] mparams)
        {
            String ret = "";
            foreach (Parameter p in mparams)
            {
                ret += ParamToNormalForm(p) + ", ";
            }
            ret = ret.Remove(ret.Length - 2);
            return ret;
        }
    }
}
