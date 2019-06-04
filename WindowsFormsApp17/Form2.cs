using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            Model1 dbModel = new Model1();

            foreach(var item in dbModel.Сinema)
            {
                listBox1.Items.Add(item.idCinema);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model1 dbModel = new Model1();

            var name = Convert.ToInt32(listBox1.Text);

            foreach (var item in dbModel.Сinema)
            {

                foreach (var item2 in dbModel.Film)
                {
                    if (name == item.idCinema)
                    {
                        label1.Text = "Номер кинозала: " + item.idCinema + "\n" +
                                      "Название фильма: " + item2.title + "\n" +
                                      "Количество свободных мест: " + item.vacancies;
                    }
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
