namespace Task8_3
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
            System.Windows.Forms.TabPage tabEditor;
            this.btnTrueOrFalse = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.questionsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.questionIndex = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.questionText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.startScreen = new System.Windows.Forms.GroupBox();
            this.btnSelectTrue = new System.Windows.Forms.Button();
            this.btnSelectFalse = new System.Windows.Forms.Button();
            this.gameQuestionText = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.answerCheck = new System.Windows.Forms.Label();
            this.correctAnswersCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loadedFilename = new System.Windows.Forms.Label();
            tabEditor = new System.Windows.Forms.TabPage();
            tabEditor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionIndex)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGame.SuspendLayout();
            this.startScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEditor
            // 
            tabEditor.Controls.Add(this.btnTrueOrFalse);
            tabEditor.Controls.Add(this.groupBox1);
            tabEditor.Controls.Add(this.questionText);
            tabEditor.Location = new System.Drawing.Point(4, 22);
            tabEditor.Name = "tabEditor";
            tabEditor.Padding = new System.Windows.Forms.Padding(3);
            tabEditor.Size = new System.Drawing.Size(566, 404);
            tabEditor.TabIndex = 0;
            tabEditor.Text = "Questions Editor";
            tabEditor.UseVisualStyleBackColor = true;
            // 
            // btnTrueOrFalse
            // 
            this.btnTrueOrFalse.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnTrueOrFalse.AutoSize = true;
            this.btnTrueOrFalse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTrueOrFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrueOrFalse.ForeColor = System.Drawing.Color.Red;
            this.btnTrueOrFalse.Location = new System.Drawing.Point(3, 308);
            this.btnTrueOrFalse.Name = "btnTrueOrFalse";
            this.btnTrueOrFalse.Size = new System.Drawing.Size(560, 23);
            this.btnTrueOrFalse.TabIndex = 4;
            this.btnTrueOrFalse.Text = "False";
            this.btnTrueOrFalse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTrueOrFalse.UseVisualStyleBackColor = true;
            this.btnTrueOrFalse.CheckedChanged += new System.EventHandler(this.BtnTrueOrFalse_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.questionsCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.questionIndex);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.dtnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(178, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // questionsCount
            // 
            this.questionsCount.AutoSize = true;
            this.questionsCount.Location = new System.Drawing.Point(113, 54);
            this.questionsCount.Name = "questionsCount";
            this.questionsCount.Size = new System.Drawing.Size(13, 13);
            this.questionsCount.TabIndex = 5;
            this.questionsCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(0, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Questions count: ";
            // 
            // questionIndex
            // 
            this.questionIndex.Location = new System.Drawing.Point(121, 22);
            this.questionIndex.Name = "questionIndex";
            this.questionIndex.Size = new System.Drawing.Size(51, 20);
            this.questionIndex.TabIndex = 3;
            this.questionIndex.ValueChanged += new System.EventHandler(this.QuestionIndex_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(403, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Questions Data";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dtnDelete
            // 
            this.dtnDelete.Location = new System.Drawing.Point(259, 19);
            this.dtnDelete.Name = "dtnDelete";
            this.dtnDelete.Size = new System.Drawing.Size(75, 23);
            this.dtnDelete.TabIndex = 1;
            this.dtnDelete.Text = "Delete";
            this.dtnDelete.UseVisualStyleBackColor = true;
            this.dtnDelete.Click += new System.EventHandler(this.DtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // questionText
            // 
            this.questionText.Dock = System.Windows.Forms.DockStyle.Top;
            this.questionText.Location = new System.Drawing.Point(3, 3);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(560, 299);
            this.questionText.TabIndex = 0;
            this.questionText.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFile,
            this.saveAs,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFile
            // 
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(114, 22);
            this.loadFile.Text = "Load";
            this.loadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(114, 22);
            this.saveAs.Text = "Save As";
            this.saveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(107, 22);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGame);
            this.tabControl1.Controls.Add(tabEditor);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(574, 430);
            this.tabControl1.TabIndex = 1;
            // 
            // tabGame
            // 
            this.tabGame.Controls.Add(this.startScreen);
            this.tabGame.Controls.Add(this.correctAnswersCount);
            this.tabGame.Controls.Add(this.label5);
            this.tabGame.Location = new System.Drawing.Point(4, 22);
            this.tabGame.Name = "tabGame";
            this.tabGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabGame.Size = new System.Drawing.Size(566, 404);
            this.tabGame.TabIndex = 1;
            this.tabGame.Text = "Game";
            this.tabGame.UseVisualStyleBackColor = true;
            // 
            // startScreen
            // 
            this.startScreen.Controls.Add(this.btnSelectTrue);
            this.startScreen.Controls.Add(this.btnSelectFalse);
            this.startScreen.Controls.Add(this.gameQuestionText);
            this.startScreen.Controls.Add(this.btnStartGame);
            this.startScreen.Controls.Add(this.answerCheck);
            this.startScreen.Location = new System.Drawing.Point(0, 0);
            this.startScreen.Name = "startScreen";
            this.startScreen.Size = new System.Drawing.Size(566, 352);
            this.startScreen.TabIndex = 7;
            this.startScreen.TabStop = false;
            // 
            // btnSelectTrue
            // 
            this.btnSelectTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectTrue.ForeColor = System.Drawing.Color.Green;
            this.btnSelectTrue.Location = new System.Drawing.Point(3, 287);
            this.btnSelectTrue.Name = "btnSelectTrue";
            this.btnSelectTrue.Size = new System.Drawing.Size(283, 23);
            this.btnSelectTrue.TabIndex = 2;
            this.btnSelectTrue.Text = "True";
            this.btnSelectTrue.UseVisualStyleBackColor = true;
            this.btnSelectTrue.Click += new System.EventHandler(this.BtnSelectTrue_Click);
            // 
            // btnSelectFalse
            // 
            this.btnSelectFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectFalse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSelectFalse.Location = new System.Drawing.Point(286, 287);
            this.btnSelectFalse.Name = "btnSelectFalse";
            this.btnSelectFalse.Size = new System.Drawing.Size(280, 23);
            this.btnSelectFalse.TabIndex = 3;
            this.btnSelectFalse.Text = "False";
            this.btnSelectFalse.UseVisualStyleBackColor = true;
            this.btnSelectFalse.Click += new System.EventHandler(this.BtnSelectFalse_Click);
            // 
            // gameQuestionText
            // 
            this.gameQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameQuestionText.Location = new System.Drawing.Point(27, 58);
            this.gameQuestionText.Name = "gameQuestionText";
            this.gameQuestionText.Size = new System.Drawing.Size(506, 136);
            this.gameQuestionText.TabIndex = 0;
            this.gameQuestionText.Text = "Please Load Questions\r\nAnd Press \"Start to Play Game\"";
            this.gameQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartGame.Location = new System.Drawing.Point(172, 235);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(244, 28);
            this.btnStartGame.TabIndex = 6;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // answerCheck
            // 
            this.answerCheck.AutoSize = true;
            this.answerCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerCheck.Location = new System.Drawing.Point(256, 194);
            this.answerCheck.Name = "answerCheck";
            this.answerCheck.Size = new System.Drawing.Size(0, 13);
            this.answerCheck.TabIndex = 1;
            // 
            // correctAnswersCount
            // 
            this.correctAnswersCount.AutoSize = true;
            this.correctAnswersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.correctAnswersCount.Location = new System.Drawing.Point(70, 370);
            this.correctAnswersCount.Name = "correctAnswersCount";
            this.correctAnswersCount.Size = new System.Drawing.Size(14, 13);
            this.correctAnswersCount.TabIndex = 5;
            this.correctAnswersCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correct:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loaded File: ";
            // 
            // loadedFilename
            // 
            this.loadedFilename.AutoSize = true;
            this.loadedFilename.Location = new System.Drawing.Point(86, 463);
            this.loadedFilename.Name = "loadedFilename";
            this.loadedFilename.Size = new System.Drawing.Size(0, 13);
            this.loadedFilename.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 482);
            this.Controls.Add(this.loadedFilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            tabEditor.ResumeLayout(false);
            tabEditor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionIndex)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabGame.ResumeLayout(false);
            this.tabGame.PerformLayout();
            this.startScreen.ResumeLayout(false);
            this.startScreen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFile;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox btnTrueOrFalse;
        private System.Windows.Forms.NumericUpDown questionIndex;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button dtnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox questionText;
        private System.Windows.Forms.Label questionsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loadedFilename;
        private System.Windows.Forms.Label correctAnswersCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.GroupBox startScreen;
        private System.Windows.Forms.GroupBox gameScreen;
        private System.Windows.Forms.Label gameQuestionText;
        private System.Windows.Forms.Button btnSelectFalse;
        private System.Windows.Forms.Button btnSelectTrue;
        private System.Windows.Forms.Label answerCheck;
    }
}

