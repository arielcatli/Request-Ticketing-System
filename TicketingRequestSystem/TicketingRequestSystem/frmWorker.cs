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
    public partial class frmWorker : Form
    {
        string connectionString = "Data Source=CATLI;Initial Catalog=RequestTicketingSystem;Persist Security Info=True;User ID=administrator_arielcatli;Password=linux07141995";
        BindingSource RequestBindingDataSource;
        DataTable newData;
        SqlDataAdapter RequestDataAdapter;
        SqlConnection connection;
        string loggedUserName;
        int loggedUserID;
        DataSet filteredDataset;

        public frmWorker(string username, int userid)
        {
            InitializeComponent();
            loggedUserName = username;
            loggedUserID = userid;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the application?", "Request Ticketing System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void frmWorker_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'requestTicketingSystemDataSet1.Ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.requestTicketingSystemDataSet1.Ticket);
            btnLogout.Text = loggedUserName;
            //filteredDataset = new DataSet();
            connection = new SqlConnection(connectionString);
            connection.Open();
            string filterStatement = "select Ticket.ticketID, Ticket.requestorName, Ticket.requestorContactInformation, Ticket.ticketStatus, Ticket.ticketTime from Ticket where (Ticket.workerID = @workerID AND Ticket.ticketStatus = 'ASSIGNED')";
            SqlCommand filterCommand = new SqlCommand(filterStatement, connection);
            filterCommand.Parameters.AddWithValue("@workerID", loggedUserID);
            RequestDataAdapter = new SqlDataAdapter(filterCommand);
            //filteredDataset = new DataSet();
            //RequestDataAdapter.Fill(filteredDataset);
            newData = new DataTable();
            RequestDataAdapter.Fill(newData);
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();


            dgridRequests.DataSource = newData;


            filterStatement = "select Ticket.ticketID, Ticket.requestorName, Ticket.requestorContactInformation, Ticket.ticketStatus, Ticket.ticketTime from Ticket where (Ticket.workerID = @workerID AND Ticket.ticketStatus = 'WIP')";
            filterCommand = new SqlCommand(filterStatement, connection);
            filterCommand.Parameters.AddWithValue("@workerID", loggedUserID);
            RequestDataAdapter = new SqlDataAdapter(filterCommand);
            //filteredDataset = new DataSet();
            //RequestDataAdapter.Fill(filteredDataset);
            newData = new DataTable();
            RequestDataAdapter.Fill(newData);
            dgridAcceptedRequests.DataSource = newData;

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to accept the request?", "Accept Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ticketCode = (int)dgridRequests.CurrentRow.Cells[2].Value;
                connection = new SqlConnection(connectionString);
                string acceptStatement = "update ticket set ticketStatus = 'WIP' where ticketID = @ticketID";
                connection.Open();
                try
                {
                    SqlCommand acceptCommand = new SqlCommand(acceptStatement, connection);
                    acceptCommand.Parameters.AddWithValue("@ticketID", ticketCode);
                    acceptCommand.ExecuteNonQuery();
                    MessageBox.Show("The request: " + ticketCode.ToString() + " status has been successfully changed to 'WIP'.", "Successful Status Update");

                    //ticketTableAdapter.Fill(requestTicketingSystemDataSet1.Ticket);
                    //RequestDataAdapter.Update(newData);
                    //RequestDataAdapter.Fill(newData);
                    //dgridRequests.DataSource = newData;

                    string filterStatement = "select Ticket.ticketID, Ticket.requestorName, Ticket.requestorContactInformation, Ticket.ticketStatus, Ticket.ticketTime from Ticket where (Ticket.workerID = @workerID AND Ticket.ticketStatus = 'ASSIGNED')";
                    SqlCommand filterCommand = new SqlCommand(filterStatement, connection);
                    filterCommand.Parameters.AddWithValue("@workerID", loggedUserID);
                    RequestDataAdapter = new SqlDataAdapter(filterCommand);
                    //filteredDataset = new DataSet();
                    //RequestDataAdapter.Fill(filteredDataset);
                    newData = new DataTable();
                    RequestDataAdapter.Fill(newData);


                    dgridRequests.DataSource = newData;

                    filterStatement = "select Ticket.ticketID, Ticket.requestorName, Ticket.requestorContactInformation, Ticket.ticketStatus, Ticket.ticketTime from Ticket where (Ticket.workerID = @workerID AND Ticket.ticketStatus = 'WIP')";
                    filterCommand = new SqlCommand(filterStatement, connection);
                    filterCommand.Parameters.AddWithValue("@workerID", loggedUserID);
                    RequestDataAdapter = new SqlDataAdapter(filterCommand);
                    //filteredDataset = new DataSet();
                    //RequestDataAdapter.Fill(filteredDataset);
                    newData = new DataTable();
                    RequestDataAdapter.Fill(newData);
                    dgridAcceptedRequests.DataSource = newData;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There has been a problem updating the request.\n" + ex.Message, "Request Update Failed");

                }
            }




        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to decline the request?", "Decline Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ticketCode = (int)dgridRequests.CurrentRow.Cells[2].Value;
                connection = new SqlConnection(connectionString);
                string acceptStatement = "update ticket set ticketStatus = 'DECLINED' where ticketID = @ticketID";
                connection.Open();
                try
                {
                    SqlCommand acceptCommand = new SqlCommand(acceptStatement, connection);
                    acceptCommand.Parameters.AddWithValue("@ticketID", ticketCode);
                    acceptCommand.ExecuteNonQuery();
                    MessageBox.Show("The request: " + ticketCode.ToString() + " status has been successfully changed to 'DECLINED'.", "Successful Status Update");

                    //ticketTableAdapter.Fill(requestTicketingSystemDataSet1.Ticket);
                    //RequestDataAdapter.Update(newData);
                    //RequestDataAdapter.Fill(newData);
                    //dgridRequests.DataSource = newData;

                    string filterStatement = "select Ticket.ticketID, Ticket.requestorName, Ticket.requestorContactInformation, Ticket.ticketStatus, Ticket.ticketTime from Ticket where (Ticket.workerID = @workerID AND Ticket.ticketStatus = 'ASSIGNED')";
                    SqlCommand filterCommand = new SqlCommand(filterStatement, connection);
                    filterCommand.Parameters.AddWithValue("@workerID", loggedUserID);
                    RequestDataAdapter = new SqlDataAdapter(filterCommand);
                    //filteredDataset = new DataSet();
                    //RequestDataAdapter.Fill(filteredDataset);
                    newData = new DataTable();
                    RequestDataAdapter.Fill(newData);


                    dgridRequests.DataSource = newData;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There has been a problem updating the request.\n" + ex.Message, "Request Update Failed");

                }
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the acceptance of the request?", "Withdraw Acceptance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ticketCode = (int)dgridAcceptedRequests.CurrentRow.Cells[2].Value;
                connection = new SqlConnection(connectionString);
                string acceptStatement = "update ticket set ticketStatus = 'WITHDRAWED' where ticketID = @ticketID";
                connection.Open();
                try
                {
                    SqlCommand acceptCommand = new SqlCommand(acceptStatement, connection);
                    acceptCommand.Parameters.AddWithValue("@ticketID", ticketCode);
                    acceptCommand.ExecuteNonQuery();
                    MessageBox.Show("The request: " + ticketCode.ToString() + " status has been successfully changed to 'WITHDRAWED'.", "Successful Status Update");

                    //ticketTableAdapter.Fill(requestTicketingSystemDataSet1.Ticket);
                    //RequestDataAdapter.Update(newData);
                    //RequestDataAdapter.Fill(newData);
                    //dgridRequests.DataSource = newData;

                    string filterStatement = "select Ticket.ticketID, Ticket.requestorName, Ticket.requestorContactInformation, Ticket.ticketStatus, Ticket.ticketTime from Ticket where (Ticket.workerID = @workerID AND Ticket.ticketStatus = 'WIP')";
                    SqlCommand filterCommand = new SqlCommand(filterStatement, connection);
                    filterCommand.Parameters.AddWithValue("@workerID", loggedUserID);
                    RequestDataAdapter = new SqlDataAdapter(filterCommand);
                    //filteredDataset = new DataSet();
                    //RequestDataAdapter.Fill(filteredDataset);
                    newData = new DataTable();
                    RequestDataAdapter.Fill(newData);


                    dgridAcceptedRequests.DataSource = newData;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There has been a problem updating the request.\n" + ex.Message, "Request Update Failed");

                }
            }

        }

        private void btnViewPendingRequest_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            int ticketCode = (int)dgridRequests.CurrentRow.Cells[2].Value;
            string displayStatement = "Select * from Ticket where Ticket.ticketID = @ticketID";
            SqlCommand displayCommand = new SqlCommand(displayStatement, connection);
            displayCommand.Parameters.AddWithValue("@ticketID", ticketCode);
            SqlDataReader reader = displayCommand.ExecuteReader(CommandBehavior.CloseConnection);

            reader.Read();
            MessageBox.Show("TICKET CODE: " + reader["ticketID"] + "\n\nREQUESTOR NAME: " + reader["requestorName"]
                            + "\nREQUESTOR CONTACT INFORMATION: " + reader["requestorContactInformation"]
                            + "\n\nDEPARTMENT: " + reader["departmentID"] + "\n\nREQUEST: \n" + reader["request"]
                            + "\n\nREQUEST CREATED ON " + reader["ticketTime"] + "\nREQUEST SET DEADLINE ON " + reader["deadline"], "Request Information");
        }

        private void btnViewRequestInfo_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            int ticketCode = (int)dgridAcceptedRequests.CurrentRow.Cells[2].Value;
            string displayStatement = "Select * from Ticket where Ticket.ticketID = @ticketID";
            SqlCommand displayCommand = new SqlCommand(displayStatement, connection);
            displayCommand.Parameters.AddWithValue("@ticketID", ticketCode);
            SqlDataReader reader = displayCommand.ExecuteReader(CommandBehavior.CloseConnection);

            reader.Read();
            MessageBox.Show("TICKET CODE: " + reader["ticketID"] + "\n\nREQUESTOR NAME: " + reader["requestorName"]
                            + "\nREQUESTOR CONTACT INFORMATION: " + reader["requestorContactInformation"]
                            + "\n\nDEPARTMENT: " + reader["departmentID"] + "\n\nREQUEST: \n" + reader["request"]
                            + "\n\nREQUEST CREATED ON " + reader["ticketTime"] + "\nREQUEST SET DEADLINE ON " + reader["deadline"], "Request Information");
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to end the request?", "End Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ticketCode = (int)dgridAcceptedRequests.CurrentRow.Cells[2].Value;
                connection = new SqlConnection(connectionString);
                string acceptStatement = "update ticket set ticketStatus = 'DONE' where ticketID = @ticketID";
                connection.Open();
                try
                {
                    SqlCommand acceptCommand = new SqlCommand(acceptStatement, connection);
                    acceptCommand.Parameters.AddWithValue("@ticketID", ticketCode);
                    acceptCommand.ExecuteNonQuery();
                    MessageBox.Show("The request: " + ticketCode.ToString() + " status has been successfully changed to 'DONE'.", "Successful Status Update");

                    //ticketTableAdapter.Fill(requestTicketingSystemDataSet1.Ticket);
                    //RequestDataAdapter.Update(newData);
                    //RequestDataAdapter.Fill(newData);
                    //dgridRequests.DataSource = newData;

                    string filterStatement = "select Ticket.ticketID, Ticket.requestorName, Ticket.requestorContactInformation, Ticket.ticketStatus, Ticket.ticketTime from Ticket where (Ticket.workerID = @workerID AND Ticket.ticketStatus = 'WIP')";
                    SqlCommand filterCommand = new SqlCommand(filterStatement, connection);
                    filterCommand.Parameters.AddWithValue("@workerID", loggedUserID);
                    RequestDataAdapter = new SqlDataAdapter(filterCommand);
                    //filteredDataset = new DataSet();
                    //RequestDataAdapter.Fill(filteredDataset);
                    newData = new DataTable();
                    RequestDataAdapter.Fill(newData);


                    dgridAcceptedRequests.DataSource = newData;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There has been a problem updating the request.\n" + ex.Message, "Request Update Failed");

                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
