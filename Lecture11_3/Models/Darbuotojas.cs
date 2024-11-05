using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_3.Models
{
    public class Darbuotojas
    {
        public int Id { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public double Atlyginimas { get; set; }

        public Darbuotojas()
        {

        }

        public Darbuotojas(int id, string vardas, string pavarde, double atlyginimas)
        {
            Id = id;
            Vardas = vardas;
            Pavarde = pavarde;
            Atlyginimas = atlyginimas;
        }
    }
}
