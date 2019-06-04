using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp17.Model
{
    public class Film
    {
        [Key]
        public int idFilm { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public DateTime prStartDate { get; set; }
        public DateTime prEndDate { get; set; }
        public int rentalPrice { get; set; }
        public int ticketPrice { get; set; }
    }
}
