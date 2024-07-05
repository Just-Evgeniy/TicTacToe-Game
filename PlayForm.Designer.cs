namespace GameTicTacToe
{
    partial class PlayForm
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
            this.Rounds = new System.Windows.Forms.Label();
            this.numbersOfRound = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CrossPoints = new System.Windows.Forms.Label();
            this.ZerosPoints = new System.Windows.Forms.Label();
            this.zeroes = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Label();
            this.StartAgain = new System.Windows.Forms.Button();
            this.Square8 = new System.Windows.Forms.Button();
            this.Square9 = new System.Windows.Forms.Button();
            this.Square5 = new System.Windows.Forms.Button();
            this.Square4 = new System.Windows.Forms.Button();
            this.Square1 = new System.Windows.Forms.Button();
            this.Square2 = new System.Windows.Forms.Button();
            this.Square3 = new System.Windows.Forms.Button();
            this.Square6 = new System.Windows.Forms.Button();
            this.Square7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rounds
            // 
            this.Rounds.AutoSize = true;
            this.Rounds.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rounds.ForeColor = System.Drawing.Color.Gold;
            this.Rounds.Location = new System.Drawing.Point(597, 212);
            this.Rounds.Name = "Rounds";
            this.Rounds.Size = new System.Drawing.Size(29, 34);
            this.Rounds.TabIndex = 37;
            this.Rounds.Text = "0";
            // 
            // numbersOfRound
            // 
            this.numbersOfRound.AutoSize = true;
            this.numbersOfRound.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersOfRound.ForeColor = System.Drawing.Color.Gold;
            this.numbersOfRound.Location = new System.Drawing.Point(489, 209);
            this.numbersOfRound.Name = "numbersOfRound";
            this.numbersOfRound.Size = new System.Drawing.Size(114, 37);
            this.numbersOfRound.TabIndex = 36;
            this.numbersOfRound.Text = "Round:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(515, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 56);
            this.label6.TabIndex = 35;
            this.label6.Text = "X:";
            // 
            // CrossPoints
            // 
            this.CrossPoints.AutoSize = true;
            this.CrossPoints.Font = new System.Drawing.Font("Mistral", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrossPoints.ForeColor = System.Drawing.Color.Gold;
            this.CrossPoints.Location = new System.Drawing.Point(565, 97);
            this.CrossPoints.Name = "CrossPoints";
            this.CrossPoints.Size = new System.Drawing.Size(45, 56);
            this.CrossPoints.TabIndex = 34;
            this.CrossPoints.Text = "0";
            // 
            // ZerosPoints
            // 
            this.ZerosPoints.AutoSize = true;
            this.ZerosPoints.Font = new System.Drawing.Font("Mistral", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZerosPoints.ForeColor = System.Drawing.Color.Gold;
            this.ZerosPoints.Location = new System.Drawing.Point(565, 153);
            this.ZerosPoints.Name = "ZerosPoints";
            this.ZerosPoints.Size = new System.Drawing.Size(45, 56);
            this.ZerosPoints.TabIndex = 33;
            this.ZerosPoints.Text = "0";
            // 
            // zeroes
            // 
            this.zeroes.AutoSize = true;
            this.zeroes.Font = new System.Drawing.Font("Mistral", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroes.ForeColor = System.Drawing.Color.Gold;
            this.zeroes.Location = new System.Drawing.Point(509, 153);
            this.zeroes.Name = "zeroes";
            this.zeroes.Size = new System.Drawing.Size(59, 56);
            this.zeroes.TabIndex = 32;
            this.zeroes.Text = "O:";
            // 
            // btExit
            // 
            this.btExit.AutoSize = true;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.ForeColor = System.Drawing.Color.Tomato;
            this.btExit.Location = new System.Drawing.Point(525, 390);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(76, 38);
            this.btExit.TabIndex = 31;
            this.btExit.Text = "Exit";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // StartAgain
            // 
            this.StartAgain.BackColor = System.Drawing.Color.Gold;
            this.StartAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartAgain.Location = new System.Drawing.Point(519, 30);
            this.StartAgain.Name = "StartAgain";
            this.StartAgain.Size = new System.Drawing.Size(101, 46);
            this.StartAgain.TabIndex = 30;
            this.StartAgain.Text = "Start again";
            this.StartAgain.UseVisualStyleBackColor = false;
            this.StartAgain.Click += new System.EventHandler(this.StartAgain_Click);
            // 
            // Square8
            // 
            this.Square8.BackColor = System.Drawing.Color.White;
            this.Square8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square8.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Square8.ForeColor = System.Drawing.Color.White;
            this.Square8.Location = new System.Drawing.Point(179, 297);
            this.Square8.Name = "Square8";
            this.Square8.Size = new System.Drawing.Size(149, 132);
            this.Square8.TabIndex = 29;
            this.Square8.Text = "N";
            this.Square8.UseVisualStyleBackColor = false;
            // 
            // Square9
            // 
            this.Square9.BackColor = System.Drawing.Color.White;
            this.Square9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square9.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Square9.ForeColor = System.Drawing.Color.White;
            this.Square9.Location = new System.Drawing.Point(334, 297);
            this.Square9.Name = "Square9";
            this.Square9.Size = new System.Drawing.Size(149, 132);
            this.Square9.TabIndex = 28;
            this.Square9.Text = "N";
            this.Square9.UseVisualStyleBackColor = false;
            // 
            // Square5
            // 
            this.Square5.BackColor = System.Drawing.Color.White;
            this.Square5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square5.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Square5.ForeColor = System.Drawing.Color.White;
            this.Square5.Location = new System.Drawing.Point(179, 159);
            this.Square5.Name = "Square5";
            this.Square5.Size = new System.Drawing.Size(149, 132);
            this.Square5.TabIndex = 27;
            this.Square5.Text = "N";
            this.Square5.UseVisualStyleBackColor = false;
            // 
            // Square4
            // 
            this.Square4.BackColor = System.Drawing.Color.White;
            this.Square4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square4.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Square4.ForeColor = System.Drawing.Color.White;
            this.Square4.Location = new System.Drawing.Point(24, 159);
            this.Square4.Name = "Square4";
            this.Square4.Size = new System.Drawing.Size(149, 132);
            this.Square4.TabIndex = 26;
            this.Square4.Text = "N";
            this.Square4.UseVisualStyleBackColor = false;
            // 
            // Square1
            // 
            this.Square1.BackColor = System.Drawing.Color.White;
            this.Square1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Square1.ForeColor = System.Drawing.Color.White;
            this.Square1.Location = new System.Drawing.Point(24, 21);
            this.Square1.Name = "Square1";
            this.Square1.Size = new System.Drawing.Size(149, 132);
            this.Square1.TabIndex = 25;
            this.Square1.Text = "N";
            this.Square1.UseVisualStyleBackColor = false;
            // 
            // Square2
            // 
            this.Square2.BackColor = System.Drawing.Color.White;
            this.Square2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square2.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Square2.ForeColor = System.Drawing.Color.White;
            this.Square2.Location = new System.Drawing.Point(179, 21);
            this.Square2.Name = "Square2";
            this.Square2.Size = new System.Drawing.Size(149, 132);
            this.Square2.TabIndex = 24;
            this.Square2.Text = "N";
            this.Square2.UseVisualStyleBackColor = false;
            // 
            // Square3
            // 
            this.Square3.BackColor = System.Drawing.Color.White;
            this.Square3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square3.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Square3.ForeColor = System.Drawing.Color.White;
            this.Square3.Location = new System.Drawing.Point(334, 21);
            this.Square3.Name = "Square3";
            this.Square3.Size = new System.Drawing.Size(149, 132);
            this.Square3.TabIndex = 23;
            this.Square3.Text = "N";
            this.Square3.UseVisualStyleBackColor = false;
            // 
            // Square6
            // 
            this.Square6.BackColor = System.Drawing.Color.White;
            this.Square6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square6.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Square6.ForeColor = System.Drawing.Color.White;
            this.Square6.Location = new System.Drawing.Point(334, 159);
            this.Square6.Name = "Square6";
            this.Square6.Size = new System.Drawing.Size(149, 132);
            this.Square6.TabIndex = 22;
            this.Square6.Text = "N";
            this.Square6.UseVisualStyleBackColor = false;
            // 
            // Square7
            // 
            this.Square7.BackColor = System.Drawing.Color.White;
            this.Square7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square7.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Square7.ForeColor = System.Drawing.Color.White;
            this.Square7.Location = new System.Drawing.Point(24, 297);
            this.Square7.Name = "Square7";
            this.Square7.Size = new System.Drawing.Size(149, 132);
            this.Square7.TabIndex = 21;
            this.Square7.Text = "N";
            this.Square7.UseVisualStyleBackColor = false;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.Rounds);
            this.Controls.Add(this.numbersOfRound);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CrossPoints);
            this.Controls.Add(this.ZerosPoints);
            this.Controls.Add(this.zeroes);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.StartAgain);
            this.Controls.Add(this.Square8);
            this.Controls.Add(this.Square9);
            this.Controls.Add(this.Square5);
            this.Controls.Add(this.Square4);
            this.Controls.Add(this.Square1);
            this.Controls.Add(this.Square2);
            this.Controls.Add(this.Square3);
            this.Controls.Add(this.Square6);
            this.Controls.Add(this.Square7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rounds;
        private System.Windows.Forms.Label numbersOfRound;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CrossPoints;
        private System.Windows.Forms.Label ZerosPoints;
        private System.Windows.Forms.Label zeroes;
        private System.Windows.Forms.Label btExit;
        private System.Windows.Forms.Button StartAgain;
        private System.Windows.Forms.Button Square8;
        private System.Windows.Forms.Button Square9;
        private System.Windows.Forms.Button Square5;
        private System.Windows.Forms.Button Square4;
        private System.Windows.Forms.Button Square1;
        private System.Windows.Forms.Button Square2;
        private System.Windows.Forms.Button Square3;
        private System.Windows.Forms.Button Square6;
        private System.Windows.Forms.Button Square7;
    }
}

