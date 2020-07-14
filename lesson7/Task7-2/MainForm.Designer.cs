namespace Task7_2
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTryCount = new System.Windows.Forms.Label();
            this.btnEnterAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GuessNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "We get random number from 1 to 100\r\nYou need guess it.\r\n\r\nTry`s соunt is unlimite" +
    "d";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Try number:";
            // 
            // labelTryCount
            // 
            this.labelTryCount.AutoSize = true;
            this.labelTryCount.Location = new System.Drawing.Point(151, 142);
            this.labelTryCount.Name = "labelTryCount";
            this.labelTryCount.Size = new System.Drawing.Size(13, 13);
            this.labelTryCount.TabIndex = 3;
            this.labelTryCount.Text = "0";
            // 
            // btnEnterAnswer
            // 
            this.btnEnterAnswer.Location = new System.Drawing.Point(133, 113);
            this.btnEnterAnswer.Name = "btnEnterAnswer";
            this.btnEnterAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnEnterAnswer.TabIndex = 4;
            this.btnEnterAnswer.Text = "Enter Answer";
            this.btnEnterAnswer.UseVisualStyleBackColor = true;
            this.btnEnterAnswer.Click += new System.EventHandler(this.BtnEnterAnswer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 167);
            this.Controls.Add(this.btnEnterAnswer);
            this.Controls.Add(this.labelTryCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTryCount;
        private System.Windows.Forms.Button btnEnterAnswer;
    }
}

