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
    public partial class InsertRegistrationСontribution : Form
    {
        SqlConnection conn = null;
        public InsertRegistrationСontribution()
        {
            InitializeComponent();
        }

        private void InsertRegistrationСontribution_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "банкDataSet.View_3". При необходимости она может быть перемещена или удалена.
            this.view_3TableAdapter.Fill(this.банкDataSet.View_3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "банкDataSet.View_4". При необходимости она может быть перемещена или удалена.
            this.view_4TableAdapter.Fill(this.банкDataSet.View_4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "банкDataSet.View_2". При необходимости она может быть перемещена или удалена.
            this.view_2TableAdapter.Fill(this.банкDataSet.View_2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = Connection.ConnectionString;
                conn.Open();
                string ClientInsert = $"EXEC sp_InsertRegistrationСontribution {comboBox1.SelectedValue}, {comboBox2.SelectedValue}, '{textBox1.Text}','{textBox2.Text}',{textBox3.Text},{comboBox3.Text},{comboBox4.SelectedValue}";
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
