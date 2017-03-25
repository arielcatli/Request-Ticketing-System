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

namespace TicketingRequestSystem
{
    public partial class frmOperator : Form
    {
        int loggedUserID;
        string loggedUserName;
        string connectionString = "Data Source=CATLI;Initial Catalog=RequestTicketingSystem;Persist Security Info=True;User ID=administrator_arielcatli;Password=linux07141995";
        SqlConnection connection;
        public frmOperator(int userID, string username)
        {
            InitializeComponent();
            this.lblDate.Text = DateTime.Now.ToLongDateString();
            this.lblTime.Text = DateTime.Now.ToLongTimeString();
            this.dtDeadline.MinDate = DateTime.Today;
            loggedUserID = userID;
            loggedUserName = username;
            //MessageBox.Show(loggedUserID.ToString() + " " + loggedUserName);
            btnLogout.Text = loggedUserName;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the application?", "Request Ticketing System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void frmOperator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'requestTicketingSystemDataSet11.Ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter1.Fill(this.requestTicketingSystemDataSet11.Ticket);

            requestTicketingSystemDataSet.Clear();
            requestTicketingSystemDataSet1.Clear();
            // TODO: This line of code loads data into the 'requestTicketingSystemDataSet1.Ticket' table. You can move, or remove it, as needed.
            //this.ticketTableAdapter.Fill(this.requestTicketingSystemDataSet1.Ticket);
            // TODO: This line of code loads data into the 'requestTicketingSystemDataSet.Worker' table. You can move, or remove it, as needed.
            this.workerTableAdapter.Fill(this.requestTicketingSystemDataSet.Worker);
            // TODO: This line of code loads data into the 'requestTicketingSystemDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.requestTicketingSystemDataSet.Department);

        }

        private void comboxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboxWorker.Items.Clear();
            connection = new SqlConnection(connectionString);
            connection.Open();
            string fillComboxWorkerStatement = "Select Worker.lastName,Worker.workerID from Worker where Worker.departmentID = @departmentID";
            try
            {
                SqlCommand fillComBoxWorkerCommand = new SqlCommand(fillComboxWorkerStatement, connection);
                fillComBoxWorkerCommand.Parameters.AddWithValue("@departmentID", comboxDepartment.SelectedValue.ToString());
                //MessageBox.Show(comboxDepartment.SelectedValue.ToString());
                SqlDataReader reader = fillComBoxWorkerCommand.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    comboxWorker.Items.Add(new Worker() { LastName = reader["lastName"].ToString(), WorkerID = (int)reader["workerID"] });
                    comboxWorker.DisplayMember = "LastName";
                    comboxWorker.ValueMember = "WorkerID";
                    
                }
                reader.Close();
            }
            catch (NullReferenceException)
            {

               
            }
           
        }

        private void tboxRequestorName_Enter(object sender, EventArgs e)
        {
            tboxRequestorName.Text = "";
        }

        

        private void tboxRequestorContactInfo_Enter(object sender, EventArgs e)
        {
            tboxRequestorContactInfo.Text = "";
        }

        private void tboxRequest_Enter(object sender, EventArgs e)
        {
            tboxRequest.Text = "";
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (filledUp())
            {
                try
                {
                    Worker worker = comboxWorker.SelectedItem as Worker;
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    string assignStatement = "Insert Into Ticket (ticketTime,workerID,departmentID,ticketStatus,request,deadline,requestorName,requestorContactInformation) "
                        + "values (@ticketTime,@workerID,@departmentID,@ticketStatus,@request,@deadline,@requestorName,@requestorContactInformation)";
                    SqlCommand assignCommand = new SqlCommand(assignStatement, connection);
                    assignCommand.Parameters.AddWithValue("@ticketTime", DateTime.Now);
                    assignCommand.Parameters.AddWithValue("@workerID", worker.WorkerID);
                    assignCommand.Parameters.AddWithValue("@departmentID", comboxDepartment.SelectedValue.ToString());
                    assignCommand.Parameters.AddWithValue("@ticketStatus", "ASSIGNED");
                    assignCommand.Parameters.AddWithValue("@request", tboxRequest.Text);
                    assignCommand.Parameters.AddWithValue("@deadline", dtDeadline.Value);
                    assignCommand.Parameters.AddWithValue("@requestorName", tboxRequestorName.Text);
                    assignCommand.Parameters.AddWithValue("@requestorContactInformation", tboxRequestorContactInfo.Text);
                    assignCommand.ExecuteNonQuery();
                    string getLatestStatement = "Select MAX(Ticket.ticketID) from Ticket";
                    SqlCommand getLatestCommand = new SqlCommand(getLatestStatement, connection);
                    //SqlDataReader reader = getLatestCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    MessageBox.Show("The request has been successfully assigned.\n\nTICKET CODE: " + getLatestCommand.ExecuteScalar().ToString(), "Assignment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                    
                }
                catch (SqlException)
                {
                    MessageBox.Show("There is an error connecting to the database. Please make sure that there is a connection.", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            

            
        }

        

       

        private void button1_Click(object sender, EventArgs e)
        {
            int ticketID = 0;
            if (int.TryParse(tboxTrackID.Text, out ticketID))
            {
                lblViewArea.Text = "";
                connection = new SqlConnection(connectionString);
                connection.Open();
                string trackStatement =
                    "Select Ticket.ticketID,Worker.LastName,Ticket.departmentID,Ticket.ticketStatus,Ticket.requestorName,Ticket.request,Ticket.deadline"
                   + " from Ticket "
                   + "inner join Worker "
                   + "on Worker.workerID = Ticket.workerID "
                   + " where ticketID = @ticketID";
                SqlCommand trackCommand = new SqlCommand(trackStatement, connection);
                trackCommand.Parameters.AddWithValue("@ticketID", ticketID);
                SqlDataReader reader = trackCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (reader.Read())
                {
                    lblViewArea.Text = ("TICKET CODE: " + reader["ticketID"].ToString() + "\nREQUESTOR NAME: " + reader["requestorName"] + "\nWORKER: " + reader["lastName"].ToString()
                                    + "\nDEPARTMENT: " + reader["departmentID"] + "\nREQUEST STATUS: " + reader["ticketStatus"] + "\nDEADLINE: " + reader["deadline"] + "\n\nREQUEST: " + reader["request"]);
                }
                else
                    MessageBox.Show("There are no request found with a ticket code of " + tboxTrackID.Text, "No Request Found");
                reader.Close();
            }
            else
            {
                MessageBox.Show("You must enter a valid ticket code", "Invalid Ticket Code");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tboxTrackID.Text != "" && tboxTrackID.Text !="Ticket Code")
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string deleteStatement = "Delete from Ticket where ticketID = @ticketID";
                SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
                deleteCommand.Parameters.AddWithValue("@ticketID", (object)tboxTrackID.Text);
                if (deleteCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("The request: " + tboxTrackID.Text + " is successfully deleted.", "Successfully Deleted");


                }
            }
            else
                MessageBox.Show("The ticket code must be provided.", "Ticket Code Not Valid");
            

        }

        private void tboxTrackID_Enter(object sender, EventArgs e)
        {
            tboxTrackID.Text = "";
        }

        private bool filledUp()
        {
            if (tboxRequestorName.Text == "" || tboxRequestorName.Text == "Requestor name")
            {
                MessageBox.Show("There must be a requestor name.", "Incomplete Information");
                tboxRequestorName.Focus();
                return false;
            }

            if (tboxRequestorContactInfo.Text == "" || tboxRequestorContactInfo.Text == "Requestor contact information")
            {
                MessageBox.Show("There must be a requestor contact information.", "Incomplete Information");
                tboxRequestorContactInfo.Focus();
                return false;
            }

            if (tboxRequest.Text == "" || tboxRequest.Text == "Request...")
            {
                MessageBox.Show("There must be a request.", "Incomplete Information");
                tboxRequest.Focus();
                return false;
            }

            
            return true;

        }

        
    }
}