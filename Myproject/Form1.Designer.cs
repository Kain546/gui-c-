namespace Tic_Tac_Toe_Game
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTurn = new System.Windows.Forms.Label();
            this.lbWinner = new System.Windows.Forms.Label();
            this.pbIMage5 = new System.Windows.Forms.PictureBox();
            this.pbIMage2 = new System.Windows.Forms.PictureBox();
            this.pbIMage8 = new System.Windows.Forms.PictureBox();
            this.pbIMage1 = new System.Windows.Forms.PictureBox();
            this.pbIMage4 = new System.Windows.Forms.PictureBox();
            this.pbIMage7 = new System.Windows.Forms.PictureBox();
            this.pbIMage3 = new System.Windows.Forms.PictureBox();
            this.pbIMage6 = new System.Windows.Forms.PictureBox();
            this.pbIMage9 = new System.Windows.Forms.PictureBox();
            this.btnEndGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(136, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(117, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Winner";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Black;
            this.btnRestartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestartGame.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.Yellow;
            this.btnRestartGame.Location = new System.Drawing.Point(89, 401);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(179, 37);
            this.btnRestartGame.TabIndex = 3;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(440, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tic-Tac-Tao Game";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.Game;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(73, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.ForeColor = System.Drawing.Color.White;
            this.lbTurn.Location = new System.Drawing.Point(116, 236);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(125, 35);
            this.lbTurn.TabIndex = 17;
            this.lbTurn.Text = "Player1";
            this.lbTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.ForeColor = System.Drawing.Color.Lime;
            this.lbWinner.Location = new System.Drawing.Point(114, 346);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(128, 35);
            this.lbWinner.TabIndex = 18;
            this.lbWinner.Text = "No one!";
            // 
            // pbIMage5
            // 
            this.pbIMage5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIMage5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbIMage5.InitialImage = null;
            this.pbIMage5.Location = new System.Drawing.Point(618, 211);
            this.pbIMage5.Name = "pbIMage5";
            this.pbIMage5.Size = new System.Drawing.Size(122, 125);
            this.pbIMage5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIMage5.TabIndex = 8;
            this.pbIMage5.TabStop = false;
            this.pbIMage5.Tag = "Q";
            this.pbIMage5.Click += new System.EventHandler(this.pbIMage_Click);
            // 
            // pbIMage2
            // 
            this.pbIMage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIMage2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbIMage2.InitialImage = null;
            this.pbIMage2.Location = new System.Drawing.Point(618, 70);
            this.pbIMage2.Name = "pbIMage2";
            this.pbIMage2.Size = new System.Drawing.Size(122, 125);
            this.pbIMage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIMage2.TabIndex = 9;
            this.pbIMage2.TabStop = false;
            this.pbIMage2.Tag = "Q";
            this.pbIMage2.Click += new System.EventHandler(this.pbIMage_Click);
            // 
            // pbIMage8
            // 
            this.pbIMage8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIMage8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbIMage8.InitialImage = null;
            this.pbIMage8.Location = new System.Drawing.Point(618, 356);
            this.pbIMage8.Name = "pbIMage8";
            this.pbIMage8.Size = new System.Drawing.Size(122, 125);
            this.pbIMage8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIMage8.TabIndex = 10;
            this.pbIMage8.TabStop = false;
            this.pbIMage8.Tag = "Q";
            this.pbIMage8.Click += new System.EventHandler(this.pbIMage_Click);
            // 
            // pbIMage1
            // 
            this.pbIMage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIMage1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbIMage1.InitialImage = null;
            this.pbIMage1.Location = new System.Drawing.Point(466, 70);
            this.pbIMage1.Name = "pbIMage1";
            this.pbIMage1.Size = new System.Drawing.Size(122, 125);
            this.pbIMage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIMage1.TabIndex = 11;
            this.pbIMage1.TabStop = false;
            this.pbIMage1.Tag = "Q";
            this.pbIMage1.Click += new System.EventHandler(this.pbIMage_Click);
            // 
            // pbIMage4
            // 
            this.pbIMage4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIMage4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbIMage4.InitialImage = null;
            this.pbIMage4.Location = new System.Drawing.Point(466, 211);
            this.pbIMage4.Name = "pbIMage4";
            this.pbIMage4.Size = new System.Drawing.Size(122, 125);
            this.pbIMage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIMage4.TabIndex = 12;
            this.pbIMage4.TabStop = false;
            this.pbIMage4.Tag = "Q";
            this.pbIMage4.Click += new System.EventHandler(this.pbIMage_Click);
            // 
            // pbIMage7
            // 
            this.pbIMage7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIMage7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbIMage7.InitialImage = null;
            this.pbIMage7.Location = new System.Drawing.Point(466, 356);
            this.pbIMage7.Name = "pbIMage7";
            this.pbIMage7.Size = new System.Drawing.Size(122, 125);
            this.pbIMage7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIMage7.TabIndex = 13;
            this.pbIMage7.TabStop = false;
            this.pbIMage7.Tag = "Q";
            this.pbIMage7.Click += new System.EventHandler(this.pbIMage_Click);
            // 
            // pbIMage3
            // 
            this.pbIMage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIMage3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbIMage3.InitialImage = null;
            this.pbIMage3.Location = new System.Drawing.Point(767, 70);
            this.pbIMage3.Name = "pbIMage3";
            this.pbIMage3.Size = new System.Drawing.Size(122, 125);
            this.pbIMage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIMage3.TabIndex = 14;
            this.pbIMage3.TabStop = false;
            this.pbIMage3.Tag = "Q";
            this.pbIMage3.Click += new System.EventHandler(this.pbIMage_Click);
            // 
            // pbIMage6
            // 
            this.pbIMage6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIMage6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbIMage6.InitialImage = null;
            this.pbIMage6.Location = new System.Drawing.Point(767, 211);
            this.pbIMage6.Name = "pbIMage6";
            this.pbIMage6.Size = new System.Drawing.Size(122, 125);
            this.pbIMage6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIMage6.TabIndex = 15;
            this.pbIMage6.TabStop = false;
            this.pbIMage6.Tag = "Q";
            this.pbIMage6.Click += new System.EventHandler(this.pbIMage_Click);
            // 
            // pbIMage9
            // 
            this.pbIMage9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIMage9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbIMage9.InitialImage = null;
            this.pbIMage9.Location = new System.Drawing.Point(767, 356);
            this.pbIMage9.Name = "pbIMage9";
            this.pbIMage9.Size = new System.Drawing.Size(122, 125);
            this.pbIMage9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIMage9.TabIndex = 16;
            this.pbIMage9.TabStop = false;
            this.pbIMage9.Tag = "Q";
            this.pbIMage9.Click += new System.EventHandler(this.pbIMage_Click);
            // 
            // btnEndGame
            // 
            this.btnEndGame.BackColor = System.Drawing.Color.Black;
            this.btnEndGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEndGame.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndGame.ForeColor = System.Drawing.Color.Yellow;
            this.btnEndGame.Location = new System.Drawing.Point(89, 463);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(179, 37);
            this.btnEndGame.TabIndex = 19;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.UseVisualStyleBackColor = false;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1073, 512);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.pbIMage9);
            this.Controls.Add(this.pbIMage6);
            this.Controls.Add(this.pbIMage3);
            this.Controls.Add(this.pbIMage7);
            this.Controls.Add(this.pbIMage4);
            this.Controls.Add(this.pbIMage1);
            this.Controls.Add(this.pbIMage8);
            this.Controls.Add(this.pbIMage2);
            this.Controls.Add(this.pbIMage5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMage9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.PictureBox pbIMage5;
        private System.Windows.Forms.PictureBox pbIMage2;
        private System.Windows.Forms.PictureBox pbIMage8;
        private System.Windows.Forms.PictureBox pbIMage1;
        private System.Windows.Forms.PictureBox pbIMage4;
        private System.Windows.Forms.PictureBox pbIMage7;
        private System.Windows.Forms.PictureBox pbIMage3;
        private System.Windows.Forms.PictureBox pbIMage6;
        private System.Windows.Forms.PictureBox pbIMage9;
        private System.Windows.Forms.Button btnEndGame;
    }
}

