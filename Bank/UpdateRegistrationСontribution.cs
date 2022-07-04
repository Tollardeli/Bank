using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class UpdateRegistrationСontribution : Form
    {
        SqlConnection conn = null;
        public UpdateRegistrationСontribution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = Connection.ConnectionString;
                conn.Open();
                string ClientInsert = $"EXEC sp_UpdateRegistrationСontribution {textBox1.Text}, '{textBox4.Text}','{textBox5.Text}',{textBox6.Text},{comboBox1.Text}";
                SqlCommand command = new SqlCommand(ClientInsert, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); this.Close(); }
        }
    }
}
