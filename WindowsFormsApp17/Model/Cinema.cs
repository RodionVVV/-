using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp17.Model
{
    public class Cinema
    {
        [Key]
        public int idCinema { get; set; }
        public int idFilm { get; set; }
        public int vacancies { get; set; }
    }
}
