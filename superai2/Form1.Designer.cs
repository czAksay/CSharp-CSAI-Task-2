namespace superai2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlChooseFile = new System.Windows.Forms.Panel();
            this.btnTestFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.pnlSetValues = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbFunctions = new System.Windows.Forms.ListBox();
            this.lblParamDescr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbParams = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSetValues = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.openSourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlInit = new System.Windows.Forms.Panel();
            this.pnlDialog = new System.Windows.Forms.Panel();
            this.lbFunctions2 = new System.Windows.Forms.ListBox();
            this.lblDescr2 = new System.Windows.Forms.Label();
            this.chkNecessFind = new System.Windows.Forms.CheckBox();
            this.chkFullAnswer = new System.Windows.Forms.CheckBox();
            this.btnClearDialog = new System.Windows.Forms.Button();
            this.lblDescr = new System.Windows.Forms.Label();
            this.rtbDialog = new System.Windows.Forms.RichTextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.cbParamsId = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picDed = new System.Windows.Forms.PictureBox();
            this.tmrHideDed = new System.Windows.Forms.Timer(this.components);
            this.pnlChooseFile.SuspendLayout();
            this.pnlSetValues.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlInit.SuspendLayout();
            this.pnlDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDed)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChooseFile
            // 
            this.pnlChooseFile.BackColor = System.Drawing.Color.Transparent;
            this.pnlChooseFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChooseFile.Controls.Add(this.btnTestFile);
            this.pnlChooseFile.Controls.Add(this.label1);
            this.pnlChooseFile.Controls.Add(this.btnChooseFile);
            this.pnlChooseFile.Location = new System.Drawing.Point(3, 3);
            this.pnlChooseFile.Name = "pnlChooseFile";
            this.pnlChooseFile.Size = new System.Drawing.Size(650, 101);
            this.pnlChooseFile.TabIndex = 0;
            // 
            // btnTestFile
            // 
            this.btnTestFile.BackColor = System.Drawing.Color.Teal;
            this.btnTestFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestFile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTestFile.ForeColor = System.Drawing.Color.White;
            this.btnTestFile.Location = new System.Drawing.Point(430, 36);
            this.btnTestFile.Name = "btnTestFile";
            this.btnTestFile.Size = new System.Drawing.Size(208, 51);
            this.btnTestFile.TabIndex = 2;
            this.btnTestFile.Text = "./test.txt";
            this.btnTestFile.UseVisualStyleBackColor = false;
            this.btnTestFile.Click += new System.EventHandler(this.btnTestFile_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите файл";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.BackColor = System.Drawing.Color.Teal;
            this.btnChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseFile.ForeColor = System.Drawing.Color.White;
            this.btnChooseFile.Location = new System.Drawing.Point(14, 36);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(410, 51);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Выбрать...";
            this.btnChooseFile.UseVisualStyleBackColor = false;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // pnlSetValues
            // 
            this.pnlSetValues.BackColor = System.Drawing.Color.Transparent;
            this.pnlSetValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSetValues.Controls.Add(this.label6);
            this.pnlSetValues.Controls.Add(this.label5);
            this.pnlSetValues.Controls.Add(this.lbFunctions);
            this.pnlSetValues.Controls.Add(this.lblParamDescr);
            this.pnlSetValues.Controls.Add(this.label4);
            this.pnlSetValues.Controls.Add(this.lbParams);
            this.pnlSetValues.Controls.Add(this.btnNext);
            this.pnlSetValues.Controls.Add(this.label3);
            this.pnlSetValues.Controls.Add(this.tbSetValues);
            this.pnlSetValues.Controls.Add(this.label2);
            this.pnlSetValues.Enabled = false;
            this.pnlSetValues.Location = new System.Drawing.Point(3, 110);
            this.pnlSetValues.Name = "pnlSetValues";
            this.pnlSetValues.Size = new System.Drawing.Size(650, 304);
            this.pnlSetValues.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(482, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Функции";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(307, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Параметры";
            // 
            // lbFunctions
            // 
            this.lbFunctions.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFunctions.FormattingEnabled = true;
            this.lbFunctions.ItemHeight = 20;
            this.lbFunctions.Location = new System.Drawing.Point(483, 99);
            this.lbFunctions.Name = "lbFunctions";
            this.lbFunctions.Size = new System.Drawing.Size(155, 124);
            this.lbFunctions.TabIndex = 8;
            this.lbFunctions.SelectedIndexChanged += new System.EventHandler(this.lbFunctions_SelectedIndexChanged);
            // 
            // lblParamDescr
            // 
            this.lblParamDescr.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParamDescr.ForeColor = System.Drawing.Color.White;
            this.lblParamDescr.Location = new System.Drawing.Point(212, 234);
            this.lblParamDescr.Name = "lblParamDescr";
            this.lblParamDescr.Size = new System.Drawing.Size(251, 51);
            this.lblParamDescr.TabIndex = 7;
            this.lblParamDescr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(459, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 63);
            this.label4.TabIndex = 6;
            this.label4.Text = "двойной клик по параметру добавляет его в текстовое поле слева";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbParams
            // 
            this.lbParams.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbParams.FormattingEnabled = true;
            this.lbParams.ItemHeight = 20;
            this.lbParams.Location = new System.Drawing.Point(308, 99);
            this.lbParams.Name = "lbParams";
            this.lbParams.Size = new System.Drawing.Size(169, 124);
            this.lbParams.TabIndex = 5;
            this.lbParams.SelectedIndexChanged += new System.EventHandler(this.lbParams_SelectedIndexChanged);
            this.lbParams.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbParams_MouseDoubleClick);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Teal;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(14, 234);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(192, 51);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Готово";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(624, 43);
            this.label3.TabIndex = 3;
            this.label3.Text = "впишите в поле снизу выражения вида <идентификатор=значение> (каждое с новой стро" +
    "ки) и нажмите кнопку \"Готово\".";
            // 
            // tbSetValues
            // 
            this.tbSetValues.BackColor = System.Drawing.Color.White;
            this.tbSetValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSetValues.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSetValues.Location = new System.Drawing.Point(15, 79);
            this.tbSetValues.Name = "tbSetValues";
            this.tbSetValues.Size = new System.Drawing.Size(287, 143);
            this.tbSetValues.TabIndex = 2;
            this.tbSetValues.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(627, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Задайте переменным значения";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTop.Controls.Add(this.lblFileName);
            this.pnlTop.Controls.Add(this.btnHome);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(790, 33);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // lblFileName
            // 
            this.lblFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFileName.ForeColor = System.Drawing.Color.White;
            this.lblFileName.Location = new System.Drawing.Point(198, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(394, 33);
            this.lblFileName.TabIndex = 8;
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFileName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFileName_MouseDown);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Teal;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(198, 33);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Домой";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Teal;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(592, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Закрыть";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openSourceFileDialog
            // 
            this.openSourceFileDialog.Filter = "Жмых database(.txt)|*.txt|Пожилые файлы|*.*";
            // 
            // pnlInit
            // 
            this.pnlInit.BackColor = System.Drawing.Color.Transparent;
            this.pnlInit.Controls.Add(this.pnlChooseFile);
            this.pnlInit.Controls.Add(this.pnlSetValues);
            this.pnlInit.Location = new System.Drawing.Point(70, 65);
            this.pnlInit.Name = "pnlInit";
            this.pnlInit.Size = new System.Drawing.Size(654, 424);
            this.pnlInit.TabIndex = 3;
            // 
            // pnlDialog
            // 
            this.pnlDialog.BackColor = System.Drawing.Color.Transparent;
            this.pnlDialog.Controls.Add(this.lbFunctions2);
            this.pnlDialog.Controls.Add(this.lblDescr2);
            this.pnlDialog.Controls.Add(this.chkNecessFind);
            this.pnlDialog.Controls.Add(this.chkFullAnswer);
            this.pnlDialog.Controls.Add(this.btnClearDialog);
            this.pnlDialog.Controls.Add(this.lblDescr);
            this.pnlDialog.Controls.Add(this.rtbDialog);
            this.pnlDialog.Controls.Add(this.btnCalc);
            this.pnlDialog.Controls.Add(this.btnFind);
            this.pnlDialog.Controls.Add(this.cbParamsId);
            this.pnlDialog.Controls.Add(this.pictureBox2);
            this.pnlDialog.Controls.Add(this.picDed);
            this.pnlDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDialog.Location = new System.Drawing.Point(0, 0);
            this.pnlDialog.Name = "pnlDialog";
            this.pnlDialog.Size = new System.Drawing.Size(790, 530);
            this.pnlDialog.TabIndex = 4;
            this.pnlDialog.Visible = false;
            // 
            // lbFunctions2
            // 
            this.lbFunctions2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFunctions2.FormattingEnabled = true;
            this.lbFunctions2.ItemHeight = 20;
            this.lbFunctions2.Location = new System.Drawing.Point(546, 356);
            this.lbFunctions2.Name = "lbFunctions2";
            this.lbFunctions2.Size = new System.Drawing.Size(229, 144);
            this.lbFunctions2.TabIndex = 14;
            this.lbFunctions2.SelectedIndexChanged += new System.EventHandler(this.lbFunctions2_SelectedIndexChanged);
            // 
            // lblDescr2
            // 
            this.lblDescr2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescr2.ForeColor = System.Drawing.Color.White;
            this.lblDescr2.Location = new System.Drawing.Point(546, 164);
            this.lblDescr2.Name = "lblDescr2";
            this.lblDescr2.Size = new System.Drawing.Size(228, 82);
            this.lblDescr2.TabIndex = 13;
            // 
            // chkNecessFind
            // 
            this.chkNecessFind.BackColor = System.Drawing.Color.Teal;
            this.chkNecessFind.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.chkNecessFind.ForeColor = System.Drawing.Color.White;
            this.chkNecessFind.Location = new System.Drawing.Point(369, 456);
            this.chkNecessFind.Name = "chkNecessFind";
            this.chkNecessFind.Size = new System.Drawing.Size(152, 33);
            this.chkNecessFind.TabIndex = 12;
            this.chkNecessFind.Text = "Принуд. нахожд.";
            this.chkNecessFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNecessFind.UseVisualStyleBackColor = false;
            this.chkNecessFind.CheckedChanged += new System.EventHandler(this.chkNecessFind_CheckedChanged);
            // 
            // chkFullAnswer
            // 
            this.chkFullAnswer.BackColor = System.Drawing.Color.Teal;
            this.chkFullAnswer.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.chkFullAnswer.ForeColor = System.Drawing.Color.White;
            this.chkFullAnswer.Location = new System.Drawing.Point(33, 456);
            this.chkFullAnswer.Name = "chkFullAnswer";
            this.chkFullAnswer.Size = new System.Drawing.Size(152, 33);
            this.chkFullAnswer.TabIndex = 11;
            this.chkFullAnswer.Text = "Запоминать";
            this.chkFullAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkFullAnswer.UseVisualStyleBackColor = false;
            this.chkFullAnswer.CheckedChanged += new System.EventHandler(this.chkFullAnswer_CheckedChanged);
            // 
            // btnClearDialog
            // 
            this.btnClearDialog.BackColor = System.Drawing.Color.Teal;
            this.btnClearDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDialog.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearDialog.ForeColor = System.Drawing.Color.White;
            this.btnClearDialog.Location = new System.Drawing.Point(201, 456);
            this.btnClearDialog.Name = "btnClearDialog";
            this.btnClearDialog.Size = new System.Drawing.Size(152, 33);
            this.btnClearDialog.TabIndex = 9;
            this.btnClearDialog.Text = "Очистить";
            this.btnClearDialog.UseVisualStyleBackColor = false;
            this.btnClearDialog.Click += new System.EventHandler(this.btnClearDialog_Click);
            // 
            // lblDescr
            // 
            this.lblDescr.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescr.ForeColor = System.Drawing.Color.White;
            this.lblDescr.Location = new System.Drawing.Point(545, 46);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(218, 82);
            this.lblDescr.TabIndex = 7;
            this.lblDescr.Text = "Нахождение: поиск способа решения. Вычислить: найти значение параметра.";
            // 
            // rtbDialog
            // 
            this.rtbDialog.BackColor = System.Drawing.Color.White;
            this.rtbDialog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDialog.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbDialog.Location = new System.Drawing.Point(33, 53);
            this.rtbDialog.Name = "rtbDialog";
            this.rtbDialog.ReadOnly = true;
            this.rtbDialog.Size = new System.Drawing.Size(488, 398);
            this.rtbDialog.TabIndex = 4;
            this.rtbDialog.Text = "";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Teal;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(546, 304);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(229, 46);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Teal;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(546, 252);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(229, 46);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Нахождение";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cbParamsId
            // 
            this.cbParamsId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParamsId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbParamsId.FormattingEnabled = true;
            this.cbParamsId.Location = new System.Drawing.Point(546, 130);
            this.cbParamsId.Name = "cbParamsId";
            this.cbParamsId.Size = new System.Drawing.Size(229, 29);
            this.cbParamsId.TabIndex = 0;
            this.cbParamsId.SelectedIndexChanged += new System.EventHandler(this.cbParamsId_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::superai2.Properties.Resources.dialog;
            this.pictureBox2.Location = new System.Drawing.Point(19, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(583, 458);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // picDed
            // 
            this.picDed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDed.Image = global::superai2.Properties.Resources.pojiloy;
            this.picDed.Location = new System.Drawing.Point(611, 310);
            this.picDed.Name = "picDed";
            this.picDed.Size = new System.Drawing.Size(178, 220);
            this.picDed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDed.TabIndex = 5;
            this.picDed.TabStop = false;
            this.picDed.Visible = false;
            this.picDed.Click += new System.EventHandler(this.picDed_Click);
            // 
            // tmrHideDed
            // 
            this.tmrHideDed.Interval = 20;
            this.tmrHideDed.Tick += new System.EventHandler(this.tmrHideDed_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::superai2.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 530);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlDialog);
            this.Controls.Add(this.pnlInit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пожилой Васерман";
            this.pnlChooseFile.ResumeLayout(false);
            this.pnlSetValues.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlInit.ResumeLayout(false);
            this.pnlDialog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChooseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Panel pnlSetValues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbSetValues;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openSourceFileDialog;
        private System.Windows.Forms.ListBox lbParams;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTestFile;
        private System.Windows.Forms.Panel pnlInit;
        private System.Windows.Forms.Panel pnlDialog;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbParamsId;
        private System.Windows.Forms.RichTextBox rtbDialog;
        private System.Windows.Forms.PictureBox picDed;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Timer tmrHideDed;
        private System.Windows.Forms.Button btnClearDialog;
        private System.Windows.Forms.CheckBox chkFullAnswer;
        private System.Windows.Forms.CheckBox chkNecessFind;
        private System.Windows.Forms.Label lblParamDescr;
        private System.Windows.Forms.Label lblDescr2;
        private System.Windows.Forms.ListBox lbFunctions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbFunctions2;
    }
}

