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
    public partial class ExchangeRate : Form
    {
        SqlConnection conn = null;
        public ExchangeRate()
        {
            InitializeComponent();
        }

        private void ExchangeRate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "банкDataSet.ОбменныйКурсВалют". При необходимости она может быть перемещена или удалена.
            this.обменныйКурсВалютTableAdapter.Fill(this.банкDataSet.ОбменныйКурсВалют);
            panel1.Hide();
            panel2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = Connection.ConnectionString;
                conn.Open();
                string ClientInsert = $"EXEC sp_Insert_Exchange_Rates {textBox1.Text}, {textBox2.Text}";
                SqlCommand command = new SqlCommand(ClientInsert, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Используйте точку, а не запятую");
            }
            finally { conn.Close(); this.обменныйКурсВалютTableAdapter.Fill(this.банкDataSet.ОбменныйКурсВалют); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = Connection.ConnectionString;
                conn.Open();
                string ClientInsert = $"EXEC sp_Update_Exchange_Rates {textBox3.Text}, {textBox4.Text},{textBox5.Text}";
                SqlCommand command = new SqlCommand(ClientInsert, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { conn.Close(); this.обменныйКурсВалютTableAdapter.Fill(this.банкDataSet.ОбменныйКурсВалют); }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int CodeExchangeRate = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Удалить данные о валюте #" + Convert.ToString(CodeExchangeRate) + "? ", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        try
                        {
                            conn = new SqlConnection();
                            conn.ConnectionString = Connection.ConnectionString;
                            conn.Open();
                            string ExchangeRateCode = $"EXEC sp_Delete_Exchange_Rates {CodeExchangeRate}";
                            SqlCommand command = new SqlCommand(ExchangeRateCode, conn);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally { conn.Close(); this.обменныйКурсВалютTableAdapter.Fill(this.банкDataSet.ОбменныйКурсВалют); }
                        break;
                    }
            }
        }
    }
}
