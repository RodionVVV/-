using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp17.Model
{
    public class Products
    {
        [Key]
        public int idProduct { get; set; }
        public string nameProduct { get; set; }
        public int priceProduct { get; set; }
    }
}
