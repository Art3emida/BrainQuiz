namespace Brain_Quiz
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.ButtonLoadTheme2 = new System.Windows.Forms.Button();
            this.ButtonLoadTheme1 = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(227, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brain Quiz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.Color.MediumPurple;
            this.ButtonStart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStart.Location = new System.Drawing.Point(294, 143);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(162, 74);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Старт!";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ShowThemes);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.BackColor = System.Drawing.Color.MediumPurple;
            this.ButtonHelp.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonHelp.Location = new System.Drawing.Point(294, 257);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(162, 71);
            this.ButtonHelp.TabIndex = 2;
            this.ButtonHelp.Text = "Помощь";
            this.ButtonHelp.UseVisualStyleBackColor = false;
            this.ButtonHelp.Click += new System.EventHandler(this.OpenHelpWindow);
            // 
            // ButtonLoadTheme2
            // 
            this.ButtonLoadTheme2.BackColor = System.Drawing.Color.MediumPurple;
            this.ButtonLoadTheme2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLoadTheme2.Location = new System.Drawing.Point(403, 143);
            this.ButtonLoadTheme2.Name = "ButtonLoadTheme2";
            this.ButtonLoadTheme2.Size = new System.Drawing.Size(162, 74);
            this.ButtonLoadTheme2.TabIndex = 3;
            this.ButtonLoadTheme2.Tag = "World";
            this.ButtonLoadTheme2.Text = "Вокруг света";
            this.ButtonLoadTheme2.UseVisualStyleBackColor = false;
            this.ButtonLoadTheme2.Visible = false;
            this.ButtonLoadTheme2.Click += new System.EventHandler(this.StartGame);
            // 
            // ButtonLoadTheme1
            // 
            this.ButtonLoadTheme1.BackColor = System.Drawing.Color.MediumPurple;
            this.ButtonLoadTheme1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLoadTheme1.Location = new System.Drawing.Point(189, 143);
            this.ButtonLoadTheme1.Name = "ButtonLoadTheme1";
            this.ButtonLoadTheme1.Size = new System.Drawing.Size(162, 74);
            this.ButtonLoadTheme1.TabIndex = 4;
            this.ButtonLoadTheme1.Tag = "Languages";
            this.ButtonLoadTheme1.Text = "Языки";
            this.ButtonLoadTheme1.UseVisualStyleBackColor = false;
            this.ButtonLoadTheme1.Visible = false;
            this.ButtonLoadTheme1.Click += new System.EventHandler(this.StartGame);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.MediumPurple;
            this.ButtonExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExit.Location = new System.Drawing.Point(294, 343);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(162, 71);
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.Text = "Выход";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.Exit);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Brain_Quiz.Properties.Resources.Menu_Screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonLoadTheme1);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonLoadTheme2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brain Quiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Button ButtonLoadTheme2;
        private System.Windows.Forms.Button ButtonLoadTheme1;
        private System.Windows.Forms.Button ButtonExit;
    }
}