using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client form = new Client();
            Hide();
            form.ShowDialog(this);
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staff form = new Staff();
            Hide();
            form.ShowDialog(this);
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExchangeRate form = new ExchangeRate();
            Hide();
            form.ShowDialog(this);
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Сontribution form = new Сontribution();
            Hide();
            form.ShowDialog(this);
            Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistrationСontribution form = new RegistrationСontribution();
            Hide();
            form.ShowDialog(this);
            Show();
        }
    }
}
