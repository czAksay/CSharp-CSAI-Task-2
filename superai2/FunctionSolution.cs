using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace superai2
{
    class FunctionSolution
    {
        Ai ai;

        public FunctionSolution(Ai ai)
        {
            this.ai = ai;
        }

        public void Run(String fId)
        {
            try
            {
                Type thisType = this.GetType();
                MethodInfo theMethod = thisType.GetMethod(fId);
                theMethod.Invoke(this, null);
            }
            catch (Exception)
            {
                throw new Exception("Модуль " + fId + " отсутствует или работает неправильно.");
            }
        }

        public void Run(Function f)
        {
            Run(f.Id);
            //currentF = f;
            //String id = f.Id;
            //try
            //{
            //    Type thisType = this.GetType();
            //    MethodInfo theMethod = thisType.GetMethod(id);
            //    theMethod.Invoke(this, null);
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("Модуль " + f.Id + " отсутствует или работает неправильно.");
            //}
        }

        private double G(String id)
        {
            return ai.GetParById(id).Value;
        }

        //L=F1(h, R) : вычисление образующей конуса
        //h = F2(L, R) : вычисление высоты конуса
        //R = F3(h, L) : вычисление радиуса основания конуса
        //Sbok=F4(R, L) : вычисление площади боковой поверхности конуса
        //R = F5(Sbok, L) : вычисление радиуса основания конуса
        //L=F6(R, Sbok) : вычисление образующей конуса
        //Sosn = F7(R) : вычисление площади основания конуса
        //R=F8(Sosn) : вычисление радиуса основания конуса
        //S=F9(Sosn, Sbok) : вычисление площади поверхности конуса
        //Sosn=F10(S, Sbok) : вычисление площади основания конуса
        //Sbok=F11(Sosn, S) : вычисление площади боковой поверхности конуса
        //V = F12(Sosn, h) : вычисление объема конуса
        //Sosn = F13(V, h) : вычисление площади основания конуса
        //h=F14(Sosn, V) : вычисление высоты конуса

        public void F1()
        {
            ai.GetParById("L").Value = Math.Sqrt(Math.Pow(G("h"),2) + Math.Pow(G("R"),2));
        }
        public void F2()
        {
            ai.GetParById("h").Value = Math.Sqrt(Math.Pow(G("L"), 2) - Math.Pow(G("R"), 2));
        }
        public void F3()
        {
            ai.GetParById("R").Value = Math.Sqrt(Math.Pow(G("L"), 2) - Math.Pow(G("h"), 2));
        }

        public void F4()
        {
            ai.GetParById("Sbok").Value = Math.PI * G("R") * G("L");
        }
        public void F5()
        {
            ai.GetParById("R").Value = G("Sbok") / Math.PI * G("L");
        }
        public void F6()
        {
            ai.GetParById("L").Value = G("Sbok") / Math.PI * G("R");
        }

        public void F7()
        {
            ai.GetParById("Sosn").Value = Math.PI * Math.Pow(G("R"),2);
        }
        public void F8()
        {
            ai.GetParById("R").Value = Math.Sqrt(G("Sosn") / Math.PI);
        }

        public void F9()
        {
            ai.GetParById("S").Value = G("Sosn") + G("Sbok");
        }
        public void F10()
        {
            ai.GetParById("Sosn").Value = G("S") - G("Sbok");
        }
        public void F11()
        {
            ai.GetParById("Sbok").Value = G("S") - G("Sosn");
        }

        public void F12()
        {
            ai.GetParById("V").Value = (G("Sosn") * G("h"))/3;
        }
        public void F13()
        {
            ai.GetParById("Sosn").Value = 3 * G("V") / G("h");
        }
        public void F14()
        {
            ai.GetParById("h").Value = 3 * G("V") / G("Sosn");
        }

        public void F15()
        {
            ai.GetParById("alpha").Value = Math.Atan(G("h") / G("R"));
        }
        public void F16()
        {
            ai.GetParById("h").Value = Math.Tan(G("alpha")) * G("R");
        }
        public void F17()
        {
            ai.GetParById("R").Value = G("h") / Math.Tan(G("alpha"));
        }
    }
}
