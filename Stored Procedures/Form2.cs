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
        Form lastForm;
        public Form2(Form lastForm)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.lastForm = lastForm;
            connection = new SqlConnection(connectionString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RemplirNumClientCombo();
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

        private void NumClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "spComptesParClient";
            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("@numClient", SqlDbType.Int));
            command.Parameters["@numClient"].Value = NumClient.Text;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                ComptesdataGridView.Rows.Clear();
                while (reader.Read())
                {
                    ComptesdataGridView.Rows.Add(reader["num_compte"], reader["solde"], reader["typeC"]);
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Read();
                connection.Close();
            }
        }

        private void TestReturnValue_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("spIsClientExist", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@numClient", NumClient.Text);
            command.Parameters.Add("@result",SqlDbType.Int);
            command.Parameters["@result"].Direction = ParameterDirection.ReturnValue;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                returnValueTxt.Text = command.Parameters["@result"].Value.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lastForm.Visible = true;
            this.Close();
        }

        private void TestOutput_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("CountComptes", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@numClient", NumClient.Text);
            command.Parameters.Add(new SqlParameter("@nbrCompte",SqlDbType.Int));
            command.Parameters["@nbrCompte"].Direction = ParameterDirection.Output;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                outputTxt.Text = command.Parameters["@nbrCompte"].Value.ToString();
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            lastForm.Visible = true;
        }
    }
}
