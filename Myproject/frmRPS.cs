using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class frmRPS : Form
    {
        // Constructor: Initializes the Rock-Paper-Scissors form
        public frmRPS()
        {
            InitializeComponent();
        }

        // Variables to store player and computer choices
        string PlayerChoice;
        string ComputerChoice;

        // Options array for computer choices
        string[] Options = { "R", "P", "S", "R", "P", "S" };

        // Random number generator for computer choice
        Random random = new Random();

        // Scores for both player and computer
        int ComputerScore = 0;
        int PlayerScore = 0;

        // Event handler for "Logout" button click
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Return to the game page and close the current form
            frmGamePage frm = new frmGamePage();
            frm.Show();
            this.Close();
        }

        //function to stop the game if computer or player wins
        private void stopGame()
        {
            if(PlayerScore == 3 || ComputerScore == 3)
            { 

            if (PlayerScore == 3)
            {
                MessageBox.Show("You win", "Game is finished");
            }

            else if (ComputerScore == 3)
            {
                MessageBox.Show("Computer wins","Game is finished");
            }
                btnRock.Enabled = false;
                btnPaper.Enabled = false;
                btnScissors.Enabled = false;
            }
        }

        //function to restart the game
        private void ReastartGame()
        {
            btnRock.Enabled = true;
            btnPaper.Enabled = true;
            btnScissors.Enabled = true;
            ComputerScore = 0;
            PlayerScore = 0;

            lblComputerChoice.Text = "Computer Choosed : none";
            lblUserChoice.Text = "You choosed : none";
            lblComputerScoores.Text = "Compter's Scores : 0";
            lblPlayerScoores.Text = "Your Scores : 0";
            lblWinner.Text = "Final winner : none";
        }

        // Event handler for player's choice button click
        private void ChoiceEvent(object sender, EventArgs e)
        {
            // Determine which button was clicked
            Guna2Button CurrentButton = (Guna2Button)sender;

            // Retrieve the player's choice using the button's Tag property
            PlayerChoice = CurrentButton.Tag.ToString();

            // Generate a random choice for the computer
            int i = random.Next(0, Options.Length);
            ComputerChoice = Options[i];

            // Update UI with choices and images
            lblUserChoice.Text = "You Choose : " + UpdateTextandImage(PlayerChoice, pb_User);
            lblComputerChoice.Text = "Computer Choose : " + UpdateTextandImage(ComputerChoice, pb_Computer);

            // Check the winner after both choices are made
            CheckWinnner();
        }

        // Method to update text and image based on choice
        private string UpdateTextandImage(string text, Guna2CirclePictureBox image)
        {
            string Word = "";

            switch (text)
            {
                case "R":
                    Word = "Rock"; // Update choice text
                    image.Image = Properties.Resources.ROCK; // Display the Rock image
                    break;

                case "P":
                    Word = "Paper"; // Update choice text
                    image.Image = Properties.Resources.PAPER; // Display the Paper image
                    break;

                case "S":
                    Word = "Scissors"; // Update choice text
                    image.Image = Properties.Resources.SCISSORS; // Display the Scissors image
                    break;
            }

            return Word;
        }

        // Method to determine the winner based on player and computer choices
        private void CheckWinnner()
        {
            // Check conditions where the computer wins
            if (PlayerChoice == "R" && ComputerChoice == "P" ||
                PlayerChoice == "S" && ComputerChoice == "R" ||
                PlayerChoice == "P" && ComputerChoice == "S")
            {
                ComputerScore++; // Increment computer's score
            }

            // Check conditions where the player wins
            if (PlayerChoice == "P" && ComputerChoice == "R" ||
                PlayerChoice == "R" && ComputerChoice == "S" ||
                PlayerChoice == "S" && ComputerChoice == "P")
            {
                PlayerScore++; // Increment player's score
            }

            // Update score labels on the form
            lblComputerScoores.Text = "Computer's Scores : " + ComputerScore;
            lblPlayerScoores.Text = "Your Scores : " + PlayerScore;

            // Determine the overall winner based on scores
            if (PlayerScore > ComputerScore)
            {
                lblWinner.Text = "Final winner : You"; // Player wins
            }
            else if (PlayerScore < ComputerScore)
            {
                lblWinner.Text = "Final winner : CPU"; // Computer wins
            }
            else
            {
                lblWinner.Text = "Final winner : Draw!"; // Draw game
            }

            stopGame();
        }

         private void guna2Button1_Click(object sender, EventArgs e)
        {
            ReastartGame();
        }
        private void frmRPS_Load(object sender, EventArgs e)
        {
            
        }
    }
}