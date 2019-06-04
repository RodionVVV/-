using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp17.Model
{
    public class FoodRevenue
    {
        [Key]
        public int idFoodRevenue { get; set; }
        public int idProduct { get; set; }
        public int idShow { get; set; }
        public int quantitySold { get; set; }
        public int profit { get; set; }
    }
}
