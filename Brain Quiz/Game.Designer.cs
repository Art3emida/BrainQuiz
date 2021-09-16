namespace Brain_Quiz
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QuestionField = new System.Windows.Forms.Label();
            this.Answer4 = new System.Windows.Forms.Button();
            this.Answer3 = new System.Windows.Forms.Button();
            this.Answer1 = new System.Windows.Forms.Button();
            this.Answer2 = new System.Windows.Forms.Button();
            this.QuestionTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeCaption = new System.Windows.Forms.Label();
            this.TimeLeft = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.QuestionField);
            this.groupBox1.Controls.Add(this.Answer4);
            this.groupBox1.Controls.Add(this.Answer3);
            this.groupBox1.Controls.Add(this.Answer1);
            this.groupBox1.Controls.Add(this.Answer2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(151, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 364);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // QuestionField
            // 
            this.QuestionField.BackColor = System.Drawing.Color.Azure;
            this.QuestionField.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QuestionField.Location = new System.Drawing.Point(22, 25);
            this.QuestionField.Name = "QuestionField";
            this.QuestionField.Size = new System.Drawing.Size(412, 153);
            this.QuestionField.TabIndex = 5;
            this.QuestionField.Text = "label1";
            this.QuestionField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Answer4
            // 
            this.Answer4.BackColor = System.Drawing.Color.DodgerBlue;
            this.Answer4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Answer4.Location = new System.Drawing.Point(254, 290);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(180, 59);
            this.Answer4.TabIndex = 4;
            this.Answer4.Tag = "4";
            this.Answer4.Text = "button4";
            this.Answer4.UseVisualStyleBackColor = false;
            this.Answer4.Click += new System.EventHandler(this.ChosenQuestion);
            // 
            // Answer3
            // 
            this.Answer3.BackColor = System.Drawing.Color.Gold;
            this.Answer3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Answer3.Location = new System.Drawing.Point(22, 290);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(194, 59);
            this.Answer3.TabIndex = 3;
            this.Answer3.Tag = "3";
            this.Answer3.Text = "button3";
            this.Answer3.UseVisualStyleBackColor = false;
            this.Answer3.Click += new System.EventHandler(this.ChosenQuestion);
            // 
            // Answer1
            // 
            this.Answer1.BackColor = System.Drawing.Color.Firebrick;
            this.Answer1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Answer1.Location = new System.Drawing.Point(22, 203);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(194, 58);
            this.Answer1.TabIndex = 1;
            this.Answer1.Tag = "1";
            this.Answer1.Text = "button1";
            this.Answer1.UseVisualStyleBackColor = false;
            this.Answer1.Click += new System.EventHandler(this.ChosenQuestion);
            // 
            // Answer2
            // 
            this.Answer2.BackColor = System.Drawing.Color.SeaGreen;
            this.Answer2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Answer2.Location = new System.Drawing.Point(254, 203);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(180, 58);
            this.Answer2.TabIndex = 2;
            this.Answer2.Tag = "2";
            this.Answer2.Text = "button2";
            this.Answer2.UseVisualStyleBackColor = false;
            this.Answer2.Click += new System.EventHandler(this.ChosenQuestion);
            // 
            // QuestionTimer
            // 
            this.QuestionTimer.Interval = 1000;
            this.QuestionTimer.Tick += new System.EventHandler(this.QuestionTimerTick);
            // 
            // TimeCaption
            // 
            this.TimeCaption.AutoSize = true;
            this.TimeCaption.BackColor = System.Drawing.Color.Transparent;
            this.TimeCaption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeCaption.Location = new System.Drawing.Point(549, 422);
            this.TimeCaption.Name = "TimeCaption";
            this.TimeCaption.Size = new System.Drawing.Size(147, 19);
            this.TimeCaption.TabIndex = 6;
            this.TimeCaption.Text = "Осталось времени: ";
            // 
            // TimeLeft
            // 
            this.TimeLeft.AutoSize = true;
            this.TimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.TimeLeft.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLeft.ForeColor = System.Drawing.Color.GhostWhite;
            this.TimeLeft.Location = new System.Drawing.Point(693, 417);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(34, 26);
            this.TimeLeft.TabIndex = 7;
            this.TimeLeft.Text = "30";
            this.TimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::Brain_Quiz.Properties.Resources.Menu_Screen1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimeLeft);
            this.Controls.Add(this.TimeCaption);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brain Quizz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnWindowClose);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Answer2;
        private System.Windows.Forms.Button Answer1;
        private System.Windows.Forms.Button Answer3;
        private System.Windows.Forms.Button Answer4;
        private System.Windows.Forms.Label QuestionField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer QuestionTimer;
        private System.Windows.Forms.Label TimeCaption;
        private System.Windows.Forms.Label TimeLeft;
    }
}

