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
    public partial class UpdateСontribution : Form
    {
        SqlConnection conn = null;
        public UpdateСontribution()
        {
            InitializeComponent();
        }

        private void UpdateСontribution_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "банкDataSet.ОбменныйКурсВалют". При необходимости она может быть перемещена или удалена.
            this.обменныйКурсВалютTableAdapter.Fill(this.банкDataSet.ОбменныйКурсВалют);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = Connection.ConnectionString;
                conn.Open();
                string ClientENunique = $"EXEC sp_Update_Types_of_Deposits {textBox1.Text}, {textBox2.Text}, {textBox3.Text},{textBox4.Text},{comboBox1.SelectedValue},{textBox5.Text}";
                SqlCommand command = new SqlCommand(ClientENunique, conn);
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
