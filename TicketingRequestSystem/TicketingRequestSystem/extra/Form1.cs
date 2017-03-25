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


namespace Database2
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=CATLI;Initial Catalog=burgerDatabase;Persist Security Info=True;User ID=administrator;Password=linux07141995";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string insertStatement = "Insert into discounts (code,percentage) values(@code,@percentage)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@code", (object)tboxCode.Text);
            insertCommand.Parameters.AddWithValue("@percentage", (object)tboxPercentage.Text);
            MessageBox.Show(insertCommand.ExecuteNonQuery().ToString());
            

        }
    }
}
