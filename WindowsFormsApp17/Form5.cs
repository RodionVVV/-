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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_WindowsFormsApp17_Model1DataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this._WindowsFormsApp17_Model1DataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кинотеатрDataSet1.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.кинотеатрDataSet1.Продукты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();

            form9.Show();
        }
    }
}
