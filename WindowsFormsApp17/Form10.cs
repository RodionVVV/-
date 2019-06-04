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
    public partial class Form10 : Form
    {
        public Form10()
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

            FoodRevenue foodRev = new FoodRevenue()
            {
                idProduct = Convert.ToInt32(textBox1.Text),
                quantitySold = Convert.ToInt32(textBox2.Text),
                profit = Convert.ToInt32(label5.Text)
            };
        }
    }
}
