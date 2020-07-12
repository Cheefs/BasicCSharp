namespace Task7_1
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddOne = new System.Windows.Forms.Button();
            this.btnMiultiply = new System.Windows.Forms.Button();
            this.labelCurrentValue = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.goalLabel = new System.Windows.Forms.Label();
            this.goalValue = new System.Windows.Forms.Label();
            this.btnDropToStart = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.labelCommandsCount = new System.Windows.Forms.Label();
            this.commandsCount = new System.Windows.Forms.Label();
            this.perfectCount = new System.Windows.Forms.Label();
            this.labelPerfectCount = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(382, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNewGame});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(50, 20);
            this.Menu.Text = "Menu";
            // 
            // BtnNewGame
            // 
            this.BtnNewGame.Name = "BtnNewGame";
            this.BtnNewGame.Size = new System.Drawing.Size(132, 22);
            this.BtnNewGame.Text = "New Game";
            this.BtnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // btnAddOne
            // 
            this.btnAddOne.Location = new System.Drawing.Point(56, 53);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(75, 23);
            this.btnAddOne.TabIndex = 1;
            this.btnAddOne.Text = "+1";
            this.btnAddOne.UseVisualStyleBackColor = true;
            this.btnAddOne.Click += new System.EventHandler(this.BtnAddOne_Click);
            // 
            // btnMiultiply
            // 
            this.btnMiultiply.Location = new System.Drawing.Point(56, 82);
            this.btnMiultiply.Name = "btnMiultiply";
            this.btnMiultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMiultiply.TabIndex = 2;
            this.btnMiultiply.Text = "x2";
            this.btnMiultiply.UseVisualStyleBackColor = true;
            this.btnMiultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // labelCurrentValue
            // 
            this.labelCurrentValue.AutoSize = true;
            this.labelCurrentValue.Location = new System.Drawing.Point(298, 121);
            this.labelCurrentValue.Name = "labelCurrentValue";
            this.labelCurrentValue.Size = new System.Drawing.Size(13, 13);
            this.labelCurrentValue.TabIndex = 3;
            this.labelCurrentValue.Text = "0\r\n";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(233, 121);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(38, 13);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "Score:";
            // 
            // goalLabel
            // 
            this.goalLabel.AutoSize = true;
            this.goalLabel.Location = new System.Drawing.Point(233, 63);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(32, 13);
            this.goalLabel.TabIndex = 6;
            this.goalLabel.Text = "Goal:";
            // 
            // goalValue
            // 
            this.goalValue.AutoSize = true;
            this.goalValue.Location = new System.Drawing.Point(298, 63);
            this.goalValue.Name = "goalValue";
            this.goalValue.Size = new System.Drawing.Size(13, 13);
            this.goalValue.TabIndex = 5;
            this.goalValue.Text = "0\r\n";
            // 
            // btnDropToStart
            // 
            this.btnDropToStart.Location = new System.Drawing.Point(56, 208);
            this.btnDropToStart.Name = "btnDropToStart";
            this.btnDropToStart.Size = new System.Drawing.Size(75, 23);
            this.btnDropToStart.TabIndex = 7;
            this.btnDropToStart.Text = "Reset to 1";
            this.btnDropToStart.UseVisualStyleBackColor = true;
            this.btnDropToStart.Click += new System.EventHandler(this.BtnDropToStart_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(56, 121);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.Text = "Go Back";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // labelCommandsCount
            // 
            this.labelCommandsCount.AutoSize = true;
            this.labelCommandsCount.Location = new System.Drawing.Point(178, 213);
            this.labelCommandsCount.Name = "labelCommandsCount";
            this.labelCommandsCount.Size = new System.Drawing.Size(93, 13);
            this.labelCommandsCount.TabIndex = 9;
            this.labelCommandsCount.Text = "Commands Count:";
            // 
            // commandsCount
            // 
            this.commandsCount.AutoSize = true;
            this.commandsCount.Location = new System.Drawing.Point(298, 213);
            this.commandsCount.Name = "commandsCount";
            this.commandsCount.Size = new System.Drawing.Size(13, 13);
            this.commandsCount.TabIndex = 10;
            this.commandsCount.Text = "0\r\n";
            // 
            // perfectCount
            // 
            this.perfectCount.AutoSize = true;
            this.perfectCount.Location = new System.Drawing.Point(298, 189);
            this.perfectCount.Name = "perfectCount";
            this.perfectCount.Size = new System.Drawing.Size(13, 13);
            this.perfectCount.TabIndex = 12;
            this.perfectCount.Text = "0\r\n";
            // 
            // labelPerfectCount
            // 
            this.labelPerfectCount.AutoSize = true;
            this.labelPerfectCount.Location = new System.Drawing.Point(178, 189);
            this.labelPerfectCount.Name = "labelPerfectCount";
            this.labelPerfectCount.Size = new System.Drawing.Size(74, 13);
            this.labelPerfectCount.TabIndex = 11;
            this.labelPerfectCount.Text = "Perfect count:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.perfectCount);
            this.Controls.Add(this.labelPerfectCount);
            this.Controls.Add(this.commandsCount);
            this.Controls.Add(this.labelCommandsCount);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnDropToStart);
            this.Controls.Add(this.goalLabel);
            this.Controls.Add(this.goalValue);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelCurrentValue);
            this.Controls.Add(this.btnMiultiply);
            this.Controls.Add(this.btnAddOne);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem BtnNewGame;
        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.Button btnMiultiply;
        private System.Windows.Forms.Label labelCurrentValue;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.Label goalValue;
        private System.Windows.Forms.Button btnDropToStart;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label labelCommandsCount;
        private System.Windows.Forms.Label commandsCount;
        private System.Windows.Forms.Label perfectCount;
        private System.Windows.Forms.Label labelPerfectCount;
    }
}

