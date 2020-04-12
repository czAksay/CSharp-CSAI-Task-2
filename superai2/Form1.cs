using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace superai2
{
    public partial class Form1 : Form
    {
        Ai ai;
        int tick;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetViewFuncList()
        {
            foreach (String l in ai.GetFuncList())
            {
                lbFunctions.Items.Add(l);
                lbFunctions2.Items.Add(l);
            }
        }

        private void SetViewParamsList()
        {
            foreach (String l in ai.GetParamsList())
            {
                lbParams.Items.Add(l);
            }
        }

        private void SetWindowName(String fileName)
        {
            int lng = fileName.Length;
            int maxLng = 35;
            if (lng > maxLng)
            {
                fileName = "..." + fileName.Substring(lng - maxLng, maxLng);
            }
            lblFileName.Text = fileName;
        }

        private void StartWork(String fileName)
        {
            try
            {
                SetWindowName(fileName);
                ai = new Ai(fileName);
                SetViewParamsList();
                SetViewFuncList();
                pnlChooseFile.Enabled = false;
                pnlSetValues.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Errorrrrr " + ex.Message + " be ready to your computer VZORVALSYA :*");
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            var result = openSourceFileDialog.ShowDialog();
            if (result == DialogResult.OK && File.Exists(openSourceFileDialog.FileName))
            {
                StartWork(openSourceFileDialog.FileName);
            }
        }

        private void Say(String text, bool user)
        {
            String name = user ? "Вы" : ai.Name;
            rtbDialog.Text += ">" + name + ":\n  " + text + "\n";
        }

        private void StartDialog()
        {
            cbParamsId.Items.AddRange(ai.GetParamsList());
            cbParamsId.SelectedIndex = 0;
            rtbDialog.Clear();
            Say(ai.Hello, false);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            String[] values = tbSetValues.Text.Split('\n');
            foreach(String v in values)
            {
                String[] splittedByEq = v.Split('=');
                if (v != "" && splittedByEq.Length >= 2)
                {
                    try
                    {
                        ai.SetValue(splittedByEq[0], splittedByEq[1]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return;
                    }
                }
            }
            pnlInit.Hide();
            pnlDialog.Show();
            StartDialog();
        }

        #region BorderChange
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblFileName_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void lbParams_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String addSymb;
            if (tbSetValues.Text == "" || tbSetValues.Text[tbSetValues.Text.Length - 1] == '\n')
                addSymb = "";
            else
                addSymb = "\n";
            tbSetValues.Text += addSymb + lbParams.SelectedItem + "=";
        }

        private void btnTestFile_Click(object sender, EventArgs e)
        {
            if (File.Exists("test.txt"))
                StartWork("test.txt");
            else
                MessageBox.Show("Файл test.txt не обнаружен. Поместите его в директорию с программой.");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Say("Как вычислить " + cbParamsId.Text + "?", true);
            Say(ai.Find(cbParamsId.Text), false);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Say("Вычисли " + cbParamsId.Text + ".", true);
            Say(ai.Calc(cbParamsId.Text), false);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlDialog.Hide();
            pnlInit.Show();
            openSourceFileDialog.FileName = "";
            pnlSetValues.Enabled = false;
            pnlChooseFile.Enabled = true;
            tbSetValues.Clear();
            lbParams.Items.Clear();
            cbParamsId.Items.Clear();
            lblFileName.Text = "";
            lblParamDescr.Text = "";
            lblDescr2.Text = "";
            lbFunctions.Items.Clear();
            lbFunctions2.Items.Clear();
        }

        private void tmrHideDed_Tick(object sender, EventArgs e)
        {
            picDed.Location = new Point(picDed.Location.X, picDed.Location.Y + 4);
            tick++;
            if (tick == 100)
                tmrHideDed.Enabled = false;
        }

        private void picDed_Click(object sender, EventArgs e)
        {
            tick = 0;
            tmrHideDed.Enabled = true;
        }

        private void btnClearDialog_Click(object sender, EventArgs e)
        {
            rtbDialog.Clear();
        }

        private void chkFullAnswer_CheckedChanged(object sender, EventArgs e)
        {
            ai.RememberAnswer = chkFullAnswer.Checked;
        }

        private void chkNecessFind_CheckedChanged(object sender, EventArgs e)
        {
            ai.NecessaryFind = chkNecessFind.Checked;
        }

        private void lbParams_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblParamDescr.Text = ai.GetParById(lbParams.Text).Name;
        }

        private void cbParamsId_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDescr2.Text = ai.GetParById(cbParamsId.Text).Name;
        }

        private void lbFunctions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Function f = ai.GetFuncById(lbFunctions.Text);
            lblParamDescr.Text = GetFunctionDescription(f);
        }

        private String GetFunctionDescription(Function f)
        {
            String s;
            Parameter[] ps = f.Params;
            s = f.Name + "\n" + f.ToFind.Id + "=("; ;
            foreach (var p in ps)
            {
                s += p.Id + ", ";
            }
            s = s.Remove(s.Length - 2);
            s += ").";
            return s;
        }

        private void lbFunctions2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Function f = ai.GetFuncById(lbFunctions2.Text);
            lblDescr2.Text = GetFunctionDescription(f);
        }
    }
}
