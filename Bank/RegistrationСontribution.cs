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
    public partial class RegistrationСontribution : Form
    {
        SqlConnection conn = null;
        public RegistrationСontribution()
        {
            InitializeComponent();
        }

        private void RegistrationСontribution_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "банкDataSet.ВидыВкладов". При необходимости она может быть перемещена или удалена.
            this.видыВкладовTableAdapter.Fill(this.банкDataSet.ВидыВкладов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "банкDataSet.View_1". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.банкDataSet.View_1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertRegistrationСontribution form = null;
            if (form == null) //Функция запрета на повторное открытие окна
            {
                form = new InsertRegistrationСontribution();
                form.FormClosed += (x, y) => { form = null; }; //для избежания проблем с повторным открытием после закрытия
                form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            }
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateRegistrationСontribution form = null;
            if (form == null) //Функция запрета на повторное открытие окна
            {
                form = new UpdateRegistrationСontribution();
                form.FormClosed += (x, y) => { form = null; }; //для избежания проблем с повторным открытием после закрытия
                form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            }
            form.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            form.textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            form.comboBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            form.textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int CodeRegistrationСontribution = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Удалить данные о регистрационном вкладе #" + Convert.ToString(CodeRegistrationСontribution) + "? ", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        try
                        {
                            conn = new SqlConnection();
                            conn.ConnectionString = Connection.ConnectionString;
                            conn.Open();
                            string RegistrationСontributionCode = $"EXEC sp_DeleteRegistrationСontribution {CodeRegistrationСontribution}";
                            SqlCommand command = new SqlCommand(RegistrationСontributionCode, conn);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally { conn.Close(); this.view_1TableAdapter.Fill(this.банкDataSet.View_1); }
                        break;
                    }
            }
        }
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.view_1TableAdapter.Fill(this.банкDataSet.View_1);
        }
    }
}
