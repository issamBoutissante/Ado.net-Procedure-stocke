using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Stored_Procedures
{
    public partial class Form2 : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["BanqueConnection"].ConnectionString;
        SqlConnection connection;
        SqlDataReader reader;
        SqlCommand command;
        public Form2()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        void RemplirNumClientCombo()
        {
            command = new SqlCommand("select * from client", connection);
            try
            {
                connection.Open();
                reader=command.ExecuteReader();
                while (reader.Read())
                {
                    NumClient.Items.Add(reader["num_client"]);
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                connection.Close();
            }
        }
    }
}
