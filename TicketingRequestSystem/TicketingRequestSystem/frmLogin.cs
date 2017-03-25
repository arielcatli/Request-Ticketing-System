using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace TicketingRequestSystem
{
    
    
    public partial class frmLogin : Form
    {
        
        bool isUserAuthenticated;
        UserAccount user;
        string connectionString = "Data Source=CATLI;Initial Catalog=RequestTicketingSystem;Persist Security Info=True;User ID=administrator_arielcatli;Password=linux07141995";
        string testMessage = "";

        public frmLogin()
        {
            InitializeComponent();
            
         
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the application?", "Request Ticketing System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Tag = null;
                this.Close();
            }
        }

        private void tboxUsername_Enter(object sender, EventArgs e)
        {
            if(tboxUsername.Text == "username")
                tboxUsername.Text = "";
        }

        private void tboxUsername_Leave(object sender, EventArgs e)
        {
            if(tboxUsername.Text == "")
                tboxUsername.Text = "username";
        }

        private void tboxPassword_Enter(object sender, EventArgs e)
        {
            if(tboxPassword.Text == "password")
                tboxPassword.Text = "";
        }

       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (test(tboxUsername.Text, tboxPassword.Text, out testMessage))
            {
                MessageBox.Show(testMessage, "Successful Login");
                isUserAuthenticated = true;

                this.Close();
            }
            else
            {
                lblIncorrect.Visible = true;
                tboxUsername.Text = "username";
                tboxPassword.Text = "password";
                isUserAuthenticated = false;
            }
        }

        private bool test(string username, string password, out string testMessage)
        {
            SqlConnection connection;
            try
            {
                connection = new SqlConnection(connectionString);
               
                connection.Open();
                string checkLoginStatement = "Select UserAccount.username,UserAccount.password,Worker.firstName,Worker.lastName,UserAccount.workerID,Worker.workerType from UserAccount "
                    + "Inner join Worker "
                    + "on UserAccount.workerID = Worker.workerID "
                    + "Where(username = @username )";//AND password = @password
                SqlCommand checkLoginCommand= new SqlCommand(checkLoginStatement, connection);
                checkLoginCommand.Parameters.AddWithValue("@username", (object)tboxUsername.Text);
                
                SqlDataReader reader = checkLoginCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (reader.Read())
                {

                   
                    if (tboxPassword.Text == Encrypt.DecryptString(reader["password"].ToString().Trim(),tboxPassword.Text).Trim())
                    {
                        testMessage = "Welcome, " + reader["firstName"].ToString().Trim() + " " + (reader["lastName"].ToString().Trim()) + "!";
                        user = new UserAccount();
                        user.UserID = Convert.ToInt32(reader["workerID"]);
                        user.Username = reader["firstName"].ToString().Trim() + " " + reader["lastName"].ToString().Trim();
                        user.UserType = reader["workerType"].ToString().Trim();
                        this.Tag = user;
                        reader.Close();
                       
                        return true;
                    }
                    else
                    {
                        testMessage = "";
                        reader.Close();
                        return false;
                    }
                }
                else
                {
                    reader.Close();
                    testMessage = "";
                    return false;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("There is an error connecting to the database. Please make sure that there is a reliable connection to the database.\n\n" + e.GetType() + e.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                testMessage = "";
                return false;
            }
            

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            
        }
    }
}
