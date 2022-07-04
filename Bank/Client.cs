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
    public partial class Client : Form
    {
        SqlConnection conn = null;
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "банкDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.банкDataSet.Клиенты);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertClient form = null;
            if (form == null) //Функция запрета на повторное открытие окна
            {
                form = new InsertClient();
                form.FormClosed += (x, y) => { form = null; }; //для избежания проблем с повторным открытием после закрытия
                form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            }
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateClient form = null;
            if (form == null) //Функция запрета на повторное открытие окна
            {
                form = new UpdateClient();
                form.FormClosed += (x, y) => { form = null; }; //для избежания проблем с повторным открытием после закрытия
                form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            }
            form.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int CodeClient = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Удалить данные о клиенте #" + Convert.ToString(CodeClient) + "? ", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        try
                        {
                            conn = new SqlConnection();
                            conn.ConnectionString = Connection.ConnectionString;
                            conn.Open();
                            string ClientCode = $"EXEC sp_DeleteClient {CodeClient}";
                            SqlCommand command = new SqlCommand(ClientCode, conn);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally { conn.Close(); this.клиентыTableAdapter.Fill(this.банкDataSet.Клиенты); }
                        break;
                    }
            }
        }
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.клиентыTableAdapter.Fill(this.банкDataSet.Клиенты);
        }
    }
}
