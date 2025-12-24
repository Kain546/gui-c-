using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class frmGame : Form
    {
        // Constructor for initializing the game form
        public frmGame()
        {
            InitializeComponent();
        }

        // Counter to track the number of moves made
        private int Counter = 0;

        // Method to reset a PictureBox (cell) to its default state
        private void ResetImages(PictureBox img)
        {
            img.Enabled = true;                // Re-enable the PictureBox
            img.Image = Resources.QuestionMark; // Set default "?" image
            img.BackColor = Color.Transparent; // Reset background color
            img.Tag = "Q";                     // Default tag for empty cell
        }

        // Method to restart the game and reset all cells
        private void RestartGame()
        {
            // Loop through all 9 PictureBoxes and reset them
            for (int i = 1; i <= 9; i++)
            {
                ResetImages((PictureBox)this.Controls["pbIMage" + i]);
            }

            // Reset game state
            Counter = 0;                       // Reset move counter
            lbTurn.Text = "Player1";           // Set turn to Player 1
            lbWinner.Text = "No one";          // Clear winner label
        }

        // Method to disable all PictureBoxes (end the game)
        private void StopGame()
        {
            pbIMage1.Enabled = false;
            pbIMage2.Enabled = false;
            pbIMage3.Enabled = false;
            pbIMage4.Enabled = false;
            pbIMage5.Enabled = false;
            pbIMage6.Enabled = false;
            pbIMage7.Enabled = false;
            pbIMage8.Enabled = false;
            pbIMage9.Enabled = false;
        }

        // Helper method to check if a cell has already been selected
        private bool CheckIfChoiced(string TagValue)
        {
            if (TagValue == "Q") // "Q" indicates an empty cell
            {
                return false;    // Cell is free
            }
            return true;         // Cell has already been selected
        }

        // Method to update a player's choice when they click a PictureBox
        private void UpdateChoice(PictureBox PbImage)
        {
            // Check if the selected cell is already occupied
            if (CheckIfChoiced(PbImage.Tag.ToString()))
            {
                // Show error message for an invalid move
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ++Counter; // Increment move counter

                // Check if it's Player1's turn
                if (lbTurn.Text == "Player1")
                {
                    PbImage.Image = Resources.X;  // Set "X" image
                    lbTurn.Text = "Player2";      // Change turn to Player2
                    PbImage.Tag = "X";            // Mark the cell with "X"
                    CheckWinner();                // Check for a winner
                    return;
                }

                // Check if it's Player2's turn
                if (lbTurn.Text == "Player2")
                {
                    PbImage.Image = Resources.O;  // Set "O" image
                    lbTurn.Text = "Player1";      // Change turn to Player1
                    PbImage.Tag = "O";            // Mark the cell with "O"
                    CheckWinner();                // Check for a winner
                    return;
                }
            }
        }

        // Method to compare three cells to check for a winning condition
        private bool CheckValue(PictureBox Pbox1, PictureBox Pbox2, PictureBox Pbox3)
        {
            // Check if all three cells have the same value (non-empty)
            if ((Pbox1.Tag.ToString() == Pbox2.Tag.ToString()) && (Pbox1.Tag.ToString() == Pbox3.Tag.ToString()))
            {
                if (Pbox1.Tag.ToString() == "Q")
                {
                    return false; // Ignore empty cells
                }

                // Determine the winner
                if (Pbox1.Tag.ToString() == "X")
                    lbWinner.Text = "Player1"; // Player1 wins
                if (Pbox1.Tag.ToString() == "O")
                    lbWinner.Text = "Player2"; // Player2 wins

                // Highlight winning cells
                Pbox1.BackColor = Color.YellowGreen;
                Pbox2.BackColor = Color.YellowGreen;
                Pbox3.BackColor = Color.YellowGreen;

                // Display game over message
                MessageBox.Show("Game Over!!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbTurn.Text = "Finished"; // Mark game as finished
                StopGame();               // Disable further moves
                return true;
            }

            return false; // No winner found
        }

        // Method to check all possible winning combinations
        private void CheckWinner()
        {
            // Horizontal, vertical, and diagonal win checks
            if (CheckValue(pbIMage1, pbIMage2, pbIMage3)) return;
            if (CheckValue(pbIMage4, pbIMage5, pbIMage6)) return;
            if (CheckValue(pbIMage7, pbIMage8, pbIMage9)) return;
            if (CheckValue(pbIMage1, pbIMage4, pbIMage7)) return;
            if (CheckValue(pbIMage2, pbIMage5, pbIMage8)) return;
            if (CheckValue(pbIMage3, pbIMage6, pbIMage9)) return;
            if (CheckValue(pbIMage3, pbIMage5, pbIMage7)) return;
            if (CheckValue(pbIMage1, pbIMage5, pbIMage9)) return;

            // Check for a draw when all cells are filled
            if (Counter == 9)
            {
                MessageBox.Show("Game Over!!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWinner.Text = "  Draw";     // Set game as a draw
                lbTurn.Text = "Finished";    // Mark game as finished
                StopGame();                  // Disable further moves
                return;
            }
        }

        // Event handler to draw the game grid (board) on the form
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color PenColor = Color.FromArgb(250, 250, 250, 250); // Pen color
            Pen Pen = new Pen(PenColor) { Width = 10 };          // Pen thickness

            // Round end caps for better aesthetics
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Draw grid lines
            e.Graphics.DrawLine(Pen, 600, 80, 600, 500);  // First vertical line
            e.Graphics.DrawLine(Pen, 750, 80, 750, 500);  // Second vertical line
            e.Graphics.DrawLine(Pen, 450, 200, 900, 200); // First horizontal line
            e.Graphics.DrawLine(Pen, 450, 350, 900, 350); // Second horizontal line
        }

        // Event handler for clicking on a cell (PictureBox)
        private void pbIMage_Click(object sender, EventArgs e)
        {
            UpdateChoice((PictureBox)sender); // Update the clicked cell
        }

        // Event handler for restarting the game
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        // Event handler for ending the game and returning to the main menu
        private void btnEndGame_Click(object sender, EventArgs e)
        {
            frmGamePage frm = new frmGamePage();
            frm.Show();
            this.Close();
        }
    }
}
