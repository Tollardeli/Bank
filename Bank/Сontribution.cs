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
    public partial class Сontribution : Form
    {
        SqlConnection conn = null;
        public Сontribution()
        {
            InitializeComponent();
        }

        private void Сontribution_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "банкDataSet.ОбменныйКурсВалют". При необходимости она может быть перемещена или удалена.
            this.обменныйКурсВалютTableAdapter.Fill(this.банкDataSet.ОбменныйКурсВалют);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "банкDataSet.ВидыВкладов". При необходимости она может быть перемещена или удалена.
            this.видыВкладовTableAdapter.Fill(this.банкDataSet.ВидыВкладов);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertСontribution form = null;
            if (form == null) //Функция запрета на повторное открытие окна
            {
                form = new InsertСontribution();
                form.FormClosed += (x, y) => { form = null; }; //для избежания проблем с повторным открытием после закрытия
                form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            }
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateСontribution form = null;
            if (form == null) //Функция запрета на повторное открытие окна
            {
                form = new UpdateСontribution();
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
            int CodeСontribution = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Удалить данные о вкладах #" + Convert.ToString(CodeСontribution) + "? ", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        try
                        {
                            conn = new SqlConnection();
                            conn.ConnectionString = Connection.ConnectionString;
                            conn.Open();
                            string StaffCode = $"EXEC sp_Delete_Types_of_Deposits {CodeСontribution}";
                            SqlCommand command = new SqlCommand(StaffCode, conn);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally { conn.Close(); this.видыВкладовTableAdapter.Fill(this.банкDataSet.ВидыВкладов); }
                        break;
                    }
            }
        }
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.видыВкладовTableAdapter.Fill(this.банкDataSet.ВидыВкладов);
        }
    }
}
