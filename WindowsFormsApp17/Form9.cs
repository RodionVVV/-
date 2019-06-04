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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model1 dbModel = new Model1();

            Products product = new Products()
            {
                nameProduct = textBox1.Text,
                priceProduct = Convert.ToInt32(textBox2.Text)
            };

            dbModel.Products.Add(product);
            dbModel.SaveChanges();

            this.Close();
        }
    }
}
