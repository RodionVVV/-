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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model1 dbModel = new Model1();

            if (textBox2.TextLength == 0 || textBox3.TextLength == 0)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            Show show = new Show()
            {
                idCinema = Convert.ToInt32(textBox2.Text),
                showStartTime = dateTimePicker1.Value,
                showEndTime = dateTimePicker2.Value,
                occupiedPlaces = Convert.ToInt32(textBox3.Text),
                profit = Convert.ToInt32(label7.Text)
            };

            dbModel.Show.Add(show);
            dbModel.SaveChanges();        
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Model1 dbModel = new Model1();

            //var cin = Convert.ToInt32(textBox2.Text);

                foreach (var item2 in dbModel.Сinema)
                {

                    if (Convert.ToInt32(textBox2.Text) > item2.idCinema)
                    {
                        MessageBox.Show("Нет такого кинозала");
                        textBox2.Text = "1";                  
                    }

                break;
                }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Model1 dbModel = new Model1();

            var cin = Convert.ToInt32(textBox2.Text);
            var cin2 = Convert.ToInt32(textBox3.Text);


            foreach (var item in dbModel.Film)
            {

                foreach (var item2 in dbModel.Сinema)
                {
                    if (cin2 > item2.vacancies)
                    {
                        MessageBox.Show("В этом кинозале нет столько мест");
                        textBox3.Text = "0";
                    }
                    

                    if (cin == item.idFilm)
                    {
                        label7.Text = Convert.ToString(item.ticketPrice * Convert.ToInt32(textBox3.Text));
                    }

                }
                break;
            }
            
        }
    }
}
