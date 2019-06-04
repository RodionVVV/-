using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp17.Model;

namespace WindowsFormsApp17
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Model1 bdcinema = new Model1();

            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || Convert.ToInt32(textBox3.TextLength) == 0 || Convert.ToInt32(textBox4.TextLength) == 0)
            {
                MessageBox.Show("заполните все поля");
                return;
            }

            Film film = new Film()
            {
                title = textBox1.Text,
                genre = textBox2.Text,
                prStartDate = dateTimePicker1.Value,
                prEndDate = dateTimePicker2.Value,
                rentalPrice = Convert.ToInt32(textBox3.Text),
                ticketPrice = Convert.ToInt32(textBox4.Text)
            };

                bdcinema.Film.Add(film);
                bdcinema.SaveChanges();

                this.Close();
        }
    }
}
