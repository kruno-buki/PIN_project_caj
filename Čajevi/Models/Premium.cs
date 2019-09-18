using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Čajevi.Models
{
    public class Premium
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Unesite ime")]
        [Display(Name = "Ime proizvoda")]

        public string ime { get; set; }
        [Required(ErrorMessage = "Unesite podrijetlo proizvoda")]
        [Display(Name = "Podrijetlo proizvoda")]

        public string podrijetlo { get; set; }
        [Required(ErrorMessage = "Unesite vrstu čaja")]
        [Display(Name = "VRSTA")]

        public string vrsta { get; set; }
        [Required(ErrorMessage = "Unesite godinu proizvodnje")]
        [Display(Name = "Godina")]

        public int godina { get; set; }
        [Required(ErrorMessage = "Unesite ukupnu težinu proizvoda")]
        [Display(Name = "Težina")]

        public float kilaza { get; set; }
        [Display(Name = "Komada")]

        [Required(ErrorMessage = "Unesite ukupnu količinu komada")]
        public int komada { get; set; }
    }
}
