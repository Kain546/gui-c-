using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class frmGamePage : Form
    {
        // Constructor for the frmGamePage class
        public frmGamePage()
        {
            InitializeComponent();
        }

        // Event handler for the "XO Game" button click
        private void btnXOGame_Click(object sender, EventArgs e)
        {
            // Create an instance of the Tic-Tac-Toe game form
            frmGame frm = new frmGame();
            // Show the Tic-Tac-Toe game form
            frm.Show();
            // Hide the current game page form
            this.Hide();
        }

        // Event handler for the "Rock-Paper-Scissors" game button click
        private void btnRPSGame_Click(object sender, EventArgs e)
        {
            // Create an instance of the Rock-Paper-Scissors game form
            frmRPS frm = new frmRPS();
            // Show the Rock-Paper-Scissors game form
            frm.Show();
            // Hide the current game page form
            this.Hide();
        }

        // Event handler for the "Logout" button click
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Create an instance of the login form
            frmLogin frm = new frmLogin();
            // Show the login form
            frm.Show();
            // Close the current game page form to log the user out
            this.Close();
        }

        private void frmGamePage_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("t");
        }
    }
}
