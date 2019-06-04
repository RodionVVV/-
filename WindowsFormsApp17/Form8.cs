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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();

            Model1 dbModel = new Model1();

            foreach(var item in dbModel.Film)
            {
                listBox1.Items.Add(item.title);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model1 dbModel = new Model1();

            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            Cinema cinema = new Cinema()
            {
                idFilm = Convert.ToInt32(textBox1.Text),
                vacancies = Convert.ToInt32(textBox2.Text)
            };

            dbModel.Сinema.Add(cinema);
            dbModel.SaveChanges();

            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model1 dbModel = new Model1();

            var name = listBox1.Text;

            foreach(var item in dbModel.Film)
            {
                if (name == item.title)
                {
                    textBox1.Text = item.idFilm.ToString();
                }
            }
        }
    }
}
