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
    public partial class Staff : Form
    {
        SqlConnection conn = null;
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "банкDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.банкDataSet.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertStaff form = null;
            if (form == null) //Функция запрета на повторное открытие окна
            {
                form = new InsertStaff();
                form.FormClosed += (x, y) => { form = null; }; //для избежания проблем с повторным открытием после закрытия
                form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            }
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateStaff form = null;
            if (form == null) //Функция запрета на повторное открытие окна
            {
                form = new UpdateStaff();
                form.FormClosed += (x, y) => { form = null; }; //для избежания проблем с повторным открытием после закрытия
                form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            }
            form.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form.comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            form.textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int CodeStaff = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Удалить данные о сотрудниках #" + Convert.ToString(CodeStaff) + "? ", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        try
                        {
                            conn = new SqlConnection();
                            conn.ConnectionString = Connection.ConnectionString;
                            conn.Open();
                            string StaffCode = $"EXEC sp_DeleteStaff {CodeStaff}";
                            SqlCommand command = new SqlCommand(StaffCode, conn);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally { conn.Close(); this.сотрудникиTableAdapter.Fill(this.банкDataSet.Сотрудники); }
                        break;
                    }
            }
        }
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.сотрудникиTableAdapter.Fill(this.банкDataSet.Сотрудники);
        }
    }
}
