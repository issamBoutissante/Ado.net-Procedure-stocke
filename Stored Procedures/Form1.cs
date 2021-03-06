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
    public partial class Form1 : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["BanqueConnection"].ConnectionString;
        SqlConnection connection;
        SqlDataReader reader;
        SqlCommand command;

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            connection = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RemplirClientCombo();   
        }
        void RemplirClientCombo()
        {
            command = new SqlCommand("select * from client", connection);
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NumClient.Items.Add(reader["num_client"]);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                connection.Close();
            }
        }

        private void NumClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "spComptesParClient";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@numClient",NumClient.Text);
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                ComptesdataGridView.Rows.Clear();
                while (reader.Read())
                {
                    ComptesdataGridView.Rows.Add(reader["num_compte"], reader["solde"], reader["TypeC"]);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                connection.Close();
            }
        }

        private void NestPage_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
            this.Visible=false;
        }
    }
}
