using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tic_Tac_Toe_Game
{
    public partial class frmLogin : Form
    {
        // Constructor for initializing the login form
        public frmLogin()
        {
            InitializeComponent();
        }

        // Connection string to the SQL Server database
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OROS2KK;Initial Catalog=Login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        // Event handler for "Clear Fields" label click
        private void label3_Click(object sender, EventArgs e)
        {
            // Clear the username and password input fields
            txtUserName.Clear();
            txtPassword.Clear();

            // Set focus back to the username field for user convenience
            txtUserName.Focus();
        }

        // Event handler for "Exit Application" label click
        private void label1_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        // Event handler to toggle password visibility on picture click
        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            // Retrieve the current visibility status using the Tag property
            bool Show = Convert.ToBoolean(pictureBox4.Tag);

            // Toggle password visibility
            txtPassword.PasswordChar = Show ? '\0' : '*';

            // Update the Tag property to store the toggled state
            pictureBox4.Tag = Convert.ToString(!Show);
        }

        // Event handler for the "Login" button click
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username, password;

            // Retrieve user input from the text fields
            username = txtUserName.Text;
            password = txtPassword.Text;

            try
            {
                // SQL query to check if the entered username and password exist in the database
                string querry = "SELECT * FROM Users WHERE UserName = '" + username + "' AND Password='" + password + "' ";

                // Execute the query and fetch results
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                DataTable dTable = new DataTable(); 

                adapter.Fill(dTable);

                // Check if any matching rows were found
                if (dTable.Rows.Count > 0)
                {
                    // If login is successful, open the game page
                    frmGamePage frm = new frmGamePage();
                    frm.Show();

                    // Hide the login form
                    this.Hide();
                }
                else
                {
                    // Display an error message for invalid credentials
                    MessageBox.Show("Invalid password or username, try again", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the input fields and reset focus
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
            }
            catch
            {
                // Show an error message if an exception occurs
                MessageBox.Show("Error");
            }
            finally
            {
                // Ensure the database connection is closed after the operation
                conn.Close();
            }
        }
    }
}