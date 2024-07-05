namespace GameTicTacToe
{
    partial class Menu
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
            this.label3 = new System.Windows.Forms.Label();
            this.zeroes = new System.Windows.Forms.Label();
            this.Crosses = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(461, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 38);
            this.label3.TabIndex = 16;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // zeroes
            // 
            this.zeroes.AutoSize = true;
            this.zeroes.Font = new System.Drawing.Font("Mistral", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroes.ForeColor = System.Drawing.Color.Lime;
            this.zeroes.Location = new System.Drawing.Point(366, 174);
            this.zeroes.Name = "zeroes";
            this.zeroes.Size = new System.Drawing.Size(49, 56);
            this.zeroes.TabIndex = 15;
            this.zeroes.Text = "O";
            this.zeroes.Click += new System.EventHandler(this.zeroes_Click);
            // 
            // Crosses
            // 
            this.Crosses.AutoSize = true;
            this.Crosses.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crosses.ForeColor = System.Drawing.Color.Red;
            this.Crosses.Location = new System.Drawing.Point(79, 174);
            this.Crosses.Name = "Crosses";
            this.Crosses.Size = new System.Drawing.Size(55, 55);
            this.Crosses.TabIndex = 14;
            this.Crosses.Text = "X";
            this.Crosses.Click += new System.EventHandler(this.Crosses_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(92, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Who will start the game?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 73);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tic Tac Toe Game";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(498, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zeroes);
            this.Controls.Add(this.Crosses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label zeroes;
        private System.Windows.Forms.Label Crosses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}