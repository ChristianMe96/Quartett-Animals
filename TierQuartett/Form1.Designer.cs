namespace TierQuartett
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.player1Pnl = new System.Windows.Forms.Panel();
            this.rdbBodySizePl1 = new System.Windows.Forms.RadioButton();
            this.rdbAgePl1 = new System.Windows.Forms.RadioButton();
            this.btnReadyPl1 = new System.Windows.Forms.Button();
            this.rdbWeightPl1 = new System.Windows.Forms.RadioButton();
            this.rdbSpeedPl1 = new System.Windows.Forms.RadioButton();
            this.tbxBodySizePl1 = new System.Windows.Forms.TextBox();
            this.tbxWeightPl1 = new System.Windows.Forms.TextBox();
            this.tbxSpeedPl1 = new System.Windows.Forms.TextBox();
            this.tbxAgePl1 = new System.Windows.Forms.TextBox();
            this.lblAnimalPl1 = new System.Windows.Forms.Label();
            this.player2Pnl = new System.Windows.Forms.Panel();
            this.rdbBodySizePl2 = new System.Windows.Forms.RadioButton();
            this.rdbAgePl2 = new System.Windows.Forms.RadioButton();
            this.btnReadyPl2 = new System.Windows.Forms.Button();
            this.rdbWeightPl2 = new System.Windows.Forms.RadioButton();
            this.rdbSpeedPl2 = new System.Windows.Forms.RadioButton();
            this.tbxBodySizePl2 = new System.Windows.Forms.TextBox();
            this.tbxWeightPl2 = new System.Windows.Forms.TextBox();
            this.tbxSpeedPl2 = new System.Windows.Forms.TextBox();
            this.lblAnimalPl2 = new System.Windows.Forms.Label();
            this.tbxAgePl2 = new System.Windows.Forms.TextBox();
            this.tbxNamePl1 = new System.Windows.Forms.TextBox();
            this.btnNamePl1 = new System.Windows.Forms.Button();
            this.lblNamePl1 = new System.Windows.Forms.Label();
            this.lblNamePl2 = new System.Windows.Forms.Label();
            this.btnNamePl2 = new System.Windows.Forms.Button();
            this.tbxNamePl2 = new System.Windows.Forms.TextBox();
            this.tbxFight = new System.Windows.Forms.Button();
            this.player1Pnl.SuspendLayout();
            this.player2Pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(315, 393);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Spiel starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // player1Pnl
            // 
            this.player1Pnl.Controls.Add(this.rdbBodySizePl1);
            this.player1Pnl.Controls.Add(this.rdbAgePl1);
            this.player1Pnl.Controls.Add(this.btnReadyPl1);
            this.player1Pnl.Controls.Add(this.rdbWeightPl1);
            this.player1Pnl.Controls.Add(this.rdbSpeedPl1);
            this.player1Pnl.Controls.Add(this.tbxBodySizePl1);
            this.player1Pnl.Controls.Add(this.tbxWeightPl1);
            this.player1Pnl.Controls.Add(this.tbxSpeedPl1);
            this.player1Pnl.Controls.Add(this.tbxAgePl1);
            this.player1Pnl.Controls.Add(this.lblAnimalPl1);
            this.player1Pnl.Location = new System.Drawing.Point(68, 60);
            this.player1Pnl.Name = "player1Pnl";
            this.player1Pnl.Size = new System.Drawing.Size(267, 265);
            this.player1Pnl.TabIndex = 2;
            this.player1Pnl.Visible = false;
            // 
            // rdbBodySizePl1
            // 
            this.rdbBodySizePl1.AutoSize = true;
            this.rdbBodySizePl1.Location = new System.Drawing.Point(14, 187);
            this.rdbBodySizePl1.Name = "rdbBodySizePl1";
            this.rdbBodySizePl1.Size = new System.Drawing.Size(69, 17);
            this.rdbBodySizePl1.TabIndex = 20;
            this.rdbBodySizePl1.TabStop = true;
            this.rdbBodySizePl1.Text = "BodySize";
            this.rdbBodySizePl1.UseVisualStyleBackColor = true;
            // 
            // rdbAgePl1
            // 
            this.rdbAgePl1.AutoSize = true;
            this.rdbAgePl1.Location = new System.Drawing.Point(15, 145);
            this.rdbAgePl1.Name = "rdbAgePl1";
            this.rdbAgePl1.Size = new System.Drawing.Size(44, 17);
            this.rdbAgePl1.TabIndex = 19;
            this.rdbAgePl1.TabStop = true;
            this.rdbAgePl1.Text = "Age";
            this.rdbAgePl1.UseVisualStyleBackColor = true;
            // 
            // btnReadyPl1
            // 
            this.btnReadyPl1.Location = new System.Drawing.Point(68, 225);
            this.btnReadyPl1.Name = "btnReadyPl1";
            this.btnReadyPl1.Size = new System.Drawing.Size(75, 23);
            this.btnReadyPl1.TabIndex = 18;
            this.btnReadyPl1.Text = "Bereit";
            this.btnReadyPl1.UseVisualStyleBackColor = true;
            this.btnReadyPl1.Visible = false;
            this.btnReadyPl1.Click += new System.EventHandler(this.btnReadyPl1_Click);
            // 
            // rdbWeightPl1
            // 
            this.rdbWeightPl1.AutoSize = true;
            this.rdbWeightPl1.Location = new System.Drawing.Point(15, 102);
            this.rdbWeightPl1.Name = "rdbWeightPl1";
            this.rdbWeightPl1.Size = new System.Drawing.Size(59, 17);
            this.rdbWeightPl1.TabIndex = 17;
            this.rdbWeightPl1.TabStop = true;
            this.rdbWeightPl1.Text = "Weight";
            this.rdbWeightPl1.UseVisualStyleBackColor = true;
            // 
            // rdbSpeedPl1
            // 
            this.rdbSpeedPl1.AutoSize = true;
            this.rdbSpeedPl1.Location = new System.Drawing.Point(15, 58);
            this.rdbSpeedPl1.Name = "rdbSpeedPl1";
            this.rdbSpeedPl1.Size = new System.Drawing.Size(56, 17);
            this.rdbSpeedPl1.TabIndex = 16;
            this.rdbSpeedPl1.TabStop = true;
            this.rdbSpeedPl1.Text = "Speed";
            this.rdbSpeedPl1.UseVisualStyleBackColor = true;
            // 
            // tbxBodySizePl1
            // 
            this.tbxBodySizePl1.Location = new System.Drawing.Point(106, 187);
            this.tbxBodySizePl1.Name = "tbxBodySizePl1";
            this.tbxBodySizePl1.ReadOnly = true;
            this.tbxBodySizePl1.Size = new System.Drawing.Size(118, 20);
            this.tbxBodySizePl1.TabIndex = 15;
            // 
            // tbxWeightPl1
            // 
            this.tbxWeightPl1.Location = new System.Drawing.Point(106, 104);
            this.tbxWeightPl1.Name = "tbxWeightPl1";
            this.tbxWeightPl1.ReadOnly = true;
            this.tbxWeightPl1.Size = new System.Drawing.Size(118, 20);
            this.tbxWeightPl1.TabIndex = 13;
            // 
            // tbxSpeedPl1
            // 
            this.tbxSpeedPl1.Location = new System.Drawing.Point(106, 58);
            this.tbxSpeedPl1.Name = "tbxSpeedPl1";
            this.tbxSpeedPl1.ReadOnly = true;
            this.tbxSpeedPl1.Size = new System.Drawing.Size(118, 20);
            this.tbxSpeedPl1.TabIndex = 12;
            // 
            // tbxAgePl1
            // 
            this.tbxAgePl1.Location = new System.Drawing.Point(106, 145);
            this.tbxAgePl1.Name = "tbxAgePl1";
            this.tbxAgePl1.ReadOnly = true;
            this.tbxAgePl1.Size = new System.Drawing.Size(118, 20);
            this.tbxAgePl1.TabIndex = 9;
            // 
            // lblAnimalPl1
            // 
            this.lblAnimalPl1.AutoSize = true;
            this.lblAnimalPl1.Location = new System.Drawing.Point(65, 17);
            this.lblAnimalPl1.Name = "lblAnimalPl1";
            this.lblAnimalPl1.Size = new System.Drawing.Size(51, 13);
            this.lblAnimalPl1.TabIndex = 3;
            this.lblAnimalPl1.Text = "Tiername";
            // 
            // player2Pnl
            // 
            this.player2Pnl.Controls.Add(this.rdbBodySizePl2);
            this.player2Pnl.Controls.Add(this.rdbAgePl2);
            this.player2Pnl.Controls.Add(this.btnReadyPl2);
            this.player2Pnl.Controls.Add(this.rdbWeightPl2);
            this.player2Pnl.Controls.Add(this.rdbSpeedPl2);
            this.player2Pnl.Controls.Add(this.tbxBodySizePl2);
            this.player2Pnl.Controls.Add(this.tbxWeightPl2);
            this.player2Pnl.Controls.Add(this.tbxSpeedPl2);
            this.player2Pnl.Controls.Add(this.lblAnimalPl2);
            this.player2Pnl.Controls.Add(this.tbxAgePl2);
            this.player2Pnl.Location = new System.Drawing.Point(421, 60);
            this.player2Pnl.Name = "player2Pnl";
            this.player2Pnl.Size = new System.Drawing.Size(301, 265);
            this.player2Pnl.TabIndex = 3;
            this.player2Pnl.Visible = false;
            // 
            // rdbBodySizePl2
            // 
            this.rdbBodySizePl2.AutoSize = true;
            this.rdbBodySizePl2.Location = new System.Drawing.Point(15, 187);
            this.rdbBodySizePl2.Name = "rdbBodySizePl2";
            this.rdbBodySizePl2.Size = new System.Drawing.Size(69, 17);
            this.rdbBodySizePl2.TabIndex = 13;
            this.rdbBodySizePl2.TabStop = true;
            this.rdbBodySizePl2.Text = "BodySize";
            this.rdbBodySizePl2.UseVisualStyleBackColor = true;
            // 
            // rdbAgePl2
            // 
            this.rdbAgePl2.AutoSize = true;
            this.rdbAgePl2.Location = new System.Drawing.Point(15, 149);
            this.rdbAgePl2.Name = "rdbAgePl2";
            this.rdbAgePl2.Size = new System.Drawing.Size(44, 17);
            this.rdbAgePl2.TabIndex = 12;
            this.rdbAgePl2.TabStop = true;
            this.rdbAgePl2.Text = "Age";
            this.rdbAgePl2.UseVisualStyleBackColor = true;
            // 
            // btnReadyPl2
            // 
            this.btnReadyPl2.Location = new System.Drawing.Point(106, 225);
            this.btnReadyPl2.Name = "btnReadyPl2";
            this.btnReadyPl2.Size = new System.Drawing.Size(75, 23);
            this.btnReadyPl2.TabIndex = 11;
            this.btnReadyPl2.Text = "Bereit";
            this.btnReadyPl2.UseVisualStyleBackColor = true;
            this.btnReadyPl2.Visible = false;
            this.btnReadyPl2.Click += new System.EventHandler(this.btnReadyPl2_Click);
            // 
            // rdbWeightPl2
            // 
            this.rdbWeightPl2.AutoSize = true;
            this.rdbWeightPl2.Location = new System.Drawing.Point(15, 105);
            this.rdbWeightPl2.Name = "rdbWeightPl2";
            this.rdbWeightPl2.Size = new System.Drawing.Size(59, 17);
            this.rdbWeightPl2.TabIndex = 10;
            this.rdbWeightPl2.TabStop = true;
            this.rdbWeightPl2.Text = "Weight";
            this.rdbWeightPl2.UseVisualStyleBackColor = true;
            // 
            // rdbSpeedPl2
            // 
            this.rdbSpeedPl2.AutoSize = true;
            this.rdbSpeedPl2.Location = new System.Drawing.Point(15, 56);
            this.rdbSpeedPl2.Name = "rdbSpeedPl2";
            this.rdbSpeedPl2.Size = new System.Drawing.Size(56, 17);
            this.rdbSpeedPl2.TabIndex = 9;
            this.rdbSpeedPl2.TabStop = true;
            this.rdbSpeedPl2.Text = "Speed";
            this.rdbSpeedPl2.UseVisualStyleBackColor = true;
            // 
            // tbxBodySizePl2
            // 
            this.tbxBodySizePl2.Location = new System.Drawing.Point(106, 187);
            this.tbxBodySizePl2.Name = "tbxBodySizePl2";
            this.tbxBodySizePl2.ReadOnly = true;
            this.tbxBodySizePl2.Size = new System.Drawing.Size(118, 20);
            this.tbxBodySizePl2.TabIndex = 7;
            // 
            // tbxWeightPl2
            // 
            this.tbxWeightPl2.Location = new System.Drawing.Point(106, 104);
            this.tbxWeightPl2.Name = "tbxWeightPl2";
            this.tbxWeightPl2.ReadOnly = true;
            this.tbxWeightPl2.Size = new System.Drawing.Size(118, 20);
            this.tbxWeightPl2.TabIndex = 5;
            // 
            // tbxSpeedPl2
            // 
            this.tbxSpeedPl2.Location = new System.Drawing.Point(106, 58);
            this.tbxSpeedPl2.Name = "tbxSpeedPl2";
            this.tbxSpeedPl2.ReadOnly = true;
            this.tbxSpeedPl2.Size = new System.Drawing.Size(118, 20);
            this.tbxSpeedPl2.TabIndex = 4;
            // 
            // lblAnimalPl2
            // 
            this.lblAnimalPl2.AutoSize = true;
            this.lblAnimalPl2.Location = new System.Drawing.Point(76, 17);
            this.lblAnimalPl2.Name = "lblAnimalPl2";
            this.lblAnimalPl2.Size = new System.Drawing.Size(51, 13);
            this.lblAnimalPl2.TabIndex = 2;
            this.lblAnimalPl2.Text = "Tiername";
            // 
            // tbxAgePl2
            // 
            this.tbxAgePl2.Location = new System.Drawing.Point(106, 148);
            this.tbxAgePl2.Name = "tbxAgePl2";
            this.tbxAgePl2.ReadOnly = true;
            this.tbxAgePl2.Size = new System.Drawing.Size(118, 20);
            this.tbxAgePl2.TabIndex = 0;
            // 
            // tbxNamePl1
            // 
            this.tbxNamePl1.Location = new System.Drawing.Point(136, 25);
            this.tbxNamePl1.Name = "tbxNamePl1";
            this.tbxNamePl1.Size = new System.Drawing.Size(100, 20);
            this.tbxNamePl1.TabIndex = 4;
            // 
            // btnNamePl1
            // 
            this.btnNamePl1.Location = new System.Drawing.Point(252, 22);
            this.btnNamePl1.Name = "btnNamePl1";
            this.btnNamePl1.Size = new System.Drawing.Size(83, 23);
            this.btnNamePl1.TabIndex = 5;
            this.btnNamePl1.Text = "Auswählen";
            this.btnNamePl1.UseVisualStyleBackColor = true;
            this.btnNamePl1.Click += new System.EventHandler(this.btnNamePl1_Click);
            // 
            // lblNamePl1
            // 
            this.lblNamePl1.AutoSize = true;
            this.lblNamePl1.Location = new System.Drawing.Point(65, 28);
            this.lblNamePl1.Name = "lblNamePl1";
            this.lblNamePl1.Size = new System.Drawing.Size(65, 13);
            this.lblNamePl1.TabIndex = 6;
            this.lblNamePl1.Text = "Spielername";
            // 
            // lblNamePl2
            // 
            this.lblNamePl2.AutoSize = true;
            this.lblNamePl2.Location = new System.Drawing.Point(431, 31);
            this.lblNamePl2.Name = "lblNamePl2";
            this.lblNamePl2.Size = new System.Drawing.Size(65, 13);
            this.lblNamePl2.TabIndex = 9;
            this.lblNamePl2.Text = "Spielername";
            // 
            // btnNamePl2
            // 
            this.btnNamePl2.Location = new System.Drawing.Point(618, 25);
            this.btnNamePl2.Name = "btnNamePl2";
            this.btnNamePl2.Size = new System.Drawing.Size(83, 23);
            this.btnNamePl2.TabIndex = 8;
            this.btnNamePl2.Text = "Auswählen";
            this.btnNamePl2.UseVisualStyleBackColor = true;
            this.btnNamePl2.Click += new System.EventHandler(this.btnNamePl2_Click);
            // 
            // tbxNamePl2
            // 
            this.tbxNamePl2.Location = new System.Drawing.Point(502, 28);
            this.tbxNamePl2.Name = "tbxNamePl2";
            this.tbxNamePl2.Size = new System.Drawing.Size(100, 20);
            this.tbxNamePl2.TabIndex = 7;
            // 
            // tbxFight
            // 
            this.tbxFight.Location = new System.Drawing.Point(340, 205);
            this.tbxFight.Name = "tbxFight";
            this.tbxFight.Size = new System.Drawing.Size(75, 23);
            this.tbxFight.TabIndex = 10;
            this.tbxFight.Text = "Kämpfen";
            this.tbxFight.UseVisualStyleBackColor = true;
            this.tbxFight.Visible = false;
            this.tbxFight.Click += new System.EventHandler(this.tbxFight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxFight);
            this.Controls.Add(this.lblNamePl2);
            this.Controls.Add(this.btnNamePl2);
            this.Controls.Add(this.tbxNamePl2);
            this.Controls.Add(this.lblNamePl1);
            this.Controls.Add(this.btnNamePl1);
            this.Controls.Add(this.tbxNamePl1);
            this.Controls.Add(this.player2Pnl);
            this.Controls.Add(this.player1Pnl);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.player1Pnl.ResumeLayout(false);
            this.player1Pnl.PerformLayout();
            this.player2Pnl.ResumeLayout(false);
            this.player2Pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel player1Pnl;
        private System.Windows.Forms.Label lblAnimalPl1;
        private System.Windows.Forms.Panel player2Pnl;
        private System.Windows.Forms.TextBox tbxWeightPl2;
        private System.Windows.Forms.TextBox tbxSpeedPl2;
        private System.Windows.Forms.Label lblAnimalPl2;
        private System.Windows.Forms.TextBox tbxAgePl2;
        private System.Windows.Forms.TextBox tbxBodySizePl2;
        private System.Windows.Forms.TextBox tbxBodySizePl1;
        private System.Windows.Forms.TextBox tbxWeightPl1;
        private System.Windows.Forms.TextBox tbxSpeedPl1;
        private System.Windows.Forms.TextBox tbxAgePl1;
        private System.Windows.Forms.RadioButton rdbWeightPl1;
        private System.Windows.Forms.RadioButton rdbSpeedPl1;
        private System.Windows.Forms.RadioButton rdbWeightPl2;
        private System.Windows.Forms.RadioButton rdbSpeedPl2;
        private System.Windows.Forms.Button btnReadyPl1;
        private System.Windows.Forms.Button btnReadyPl2;
        private System.Windows.Forms.TextBox tbxNamePl1;
        private System.Windows.Forms.Button btnNamePl1;
        private System.Windows.Forms.Label lblNamePl1;
        private System.Windows.Forms.Label lblNamePl2;
        private System.Windows.Forms.Button btnNamePl2;
        private System.Windows.Forms.TextBox tbxNamePl2;
        private System.Windows.Forms.Button tbxFight;
        private System.Windows.Forms.RadioButton rdbBodySizePl1;
        private System.Windows.Forms.RadioButton rdbAgePl1;
        private System.Windows.Forms.RadioButton rdbBodySizePl2;
        private System.Windows.Forms.RadioButton rdbAgePl2;
    }
}

