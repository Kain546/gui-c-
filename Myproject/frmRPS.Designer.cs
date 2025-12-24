namespace Tic_Tac_Toe_Game
{
    partial class frmRPS
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
            this.btnScissors = new Guna.UI2.WinForms.Guna2Button();
            this.btnPaper = new Guna.UI2.WinForms.Guna2Button();
            this.btnRock = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.lblUserChoice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblComputerChoice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pb_Computer = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pb_User = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblPlayerScoores = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblComputerScoores = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblWinner = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Computer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_User)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScissors
            // 
            this.btnScissors.BorderRadius = 10;
            this.btnScissors.BorderThickness = 1;
            this.btnScissors.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnScissors.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnScissors.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnScissors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnScissors.FillColor = System.Drawing.Color.Transparent;
            this.btnScissors.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissors.ForeColor = System.Drawing.Color.Black;
            this.btnScissors.Location = new System.Drawing.Point(21, 241);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(114, 48);
            this.btnScissors.TabIndex = 3;
            this.btnScissors.Tag = "S";
            this.btnScissors.Text = "Scissors";
            this.btnScissors.Click += new System.EventHandler(this.ChoiceEvent);
            // 
            // btnPaper
            // 
            this.btnPaper.BorderRadius = 10;
            this.btnPaper.BorderThickness = 1;
            this.btnPaper.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPaper.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPaper.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPaper.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPaper.FillColor = System.Drawing.Color.Transparent;
            this.btnPaper.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.ForeColor = System.Drawing.Color.Black;
            this.btnPaper.Location = new System.Drawing.Point(21, 159);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(114, 48);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.Tag = "P";
            this.btnPaper.Text = "Paper";
            this.btnPaper.Click += new System.EventHandler(this.ChoiceEvent);
            // 
            // btnRock
            // 
            this.btnRock.BorderRadius = 10;
            this.btnRock.BorderThickness = 1;
            this.btnRock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRock.FillColor = System.Drawing.Color.Transparent;
            this.btnRock.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.ForeColor = System.Drawing.Color.Black;
            this.btnRock.Location = new System.Drawing.Point(21, 77);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(114, 48);
            this.btnRock.TabIndex = 1;
            this.btnRock.Tag = "R";
            this.btnRock.Text = "Rock";
            this.btnRock.Click += new System.EventHandler(this.ChoiceEvent);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.BorderThickness = 2;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(674, 390);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(114, 48);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "End Game";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUserChoice
            // 
            this.lblUserChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblUserChoice.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblUserChoice.Location = new System.Drawing.Point(195, 77);
            this.lblUserChoice.Name = "lblUserChoice";
            this.lblUserChoice.Size = new System.Drawing.Size(140, 19);
            this.lblUserChoice.TabIndex = 9;
            this.lblUserChoice.TabStop = false;
            this.lblUserChoice.Text = "You choosed : none";
            // 
            // lblComputerChoice
            // 
            this.lblComputerChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerChoice.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblComputerChoice.Location = new System.Drawing.Point(520, 77);
            this.lblComputerChoice.Name = "lblComputerChoice";
            this.lblComputerChoice.Size = new System.Drawing.Size(186, 19);
            this.lblComputerChoice.TabIndex = 10;
            this.lblComputerChoice.TabStop = false;
            this.lblComputerChoice.Text = "Computer Choosed : none";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(432, 112);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1, 100);
            this.guna2GradientPanel1.TabIndex = 11;
            // 
            // pb_Computer
            // 
            this.pb_Computer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Computer.FillColor = System.Drawing.Color.Transparent;
            this.pb_Computer.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pb_Computer.ImageRotate = 0F;
            this.pb_Computer.Location = new System.Drawing.Point(549, 112);
            this.pb_Computer.Name = "pb_Computer";
            this.pb_Computer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pb_Computer.Size = new System.Drawing.Size(100, 100);
            this.pb_Computer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Computer.TabIndex = 7;
            this.pb_Computer.TabStop = false;
            // 
            // pb_User
            // 
            this.pb_User.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_User.FillColor = System.Drawing.Color.Transparent;
            this.pb_User.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pb_User.ImageRotate = 0F;
            this.pb_User.Location = new System.Drawing.Point(221, 112);
            this.pb_User.Name = "pb_User";
            this.pb_User.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pb_User.Size = new System.Drawing.Size(100, 100);
            this.pb_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_User.TabIndex = 6;
            this.pb_User.TabStop = false;
            // 
            // lblPlayerScoores
            // 
            this.lblPlayerScoores.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerScoores.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblPlayerScoores.Location = new System.Drawing.Point(213, 241);
            this.lblPlayerScoores.Name = "lblPlayerScoores";
            this.lblPlayerScoores.Size = new System.Drawing.Size(108, 19);
            this.lblPlayerScoores.TabIndex = 12;
            this.lblPlayerScoores.TabStop = false;
            this.lblPlayerScoores.Text = "Your Scores : 0";
            // 
            // lblComputerScoores
            // 
            this.lblComputerScoores.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerScoores.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblComputerScoores.Location = new System.Drawing.Point(532, 241);
            this.lblComputerScoores.Name = "lblComputerScoores";
            this.lblComputerScoores.Size = new System.Drawing.Size(147, 19);
            this.lblComputerScoores.TabIndex = 13;
            this.lblComputerScoores.TabStop = false;
            this.lblComputerScoores.Text = "Compter\'s Scores : 0";
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWinner.Location = new System.Drawing.Point(338, 319);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(187, 25);
            this.lblWinner.TabIndex = 14;
            this.lblWinner.TabStop = false;
            this.lblWinner.Text = "Final winner : none";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Red;
            this.guna2Button1.Location = new System.Drawing.Point(21, 390);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(114, 48);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "Reatart Game";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frmRPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblComputerScoores);
            this.Controls.Add(this.lblPlayerScoores);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.lblComputerChoice);
            this.Controls.Add(this.lblUserChoice);
            this.Controls.Add(this.pb_Computer);
            this.Controls.Add(this.pb_User);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRPS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.frmRPS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Computer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnScissors;
        private Guna.UI2.WinForms.Guna2Button btnPaper;
        private Guna.UI2.WinForms.Guna2Button btnRock;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pb_User;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pb_Computer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUserChoice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblComputerChoice;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPlayerScoores;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblComputerScoores;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWinner;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}