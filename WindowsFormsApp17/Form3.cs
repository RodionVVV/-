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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            Model1 dbModel = new Model1();

            foreach (var item in dbModel.Film)
            {
                listBox1.Items.Add(item.title);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model1 dbModel = new Model1();

            var name = listBox1.Text;

            foreach(var item in dbModel.Film)
            {
                if (name == item.title)
                {
                    label1.Text = "Название: " + item.title + "\n" +
                                  "Жанр: " + item.genre + "\n" +
                                  "Дата начала проката: " + item.prStartDate + "\n" +
                                  "Дата окончания проката: " + item.prEndDate + "\n" +
                                  "Цена проката: " + item.rentalPrice + "\n" +
                                  "Цена билета: " + item.ticketPrice;
                }
            }
        }
    }
}
