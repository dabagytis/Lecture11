using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_5.Models
{
    public class Automobilis
    {
        public int Id { get; set; }
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Metai { get; set; }
        public double Kaina { get; set; }

        public Automobilis()
        {

        }

        public Automobilis(int id, string marke, string modelis, int metai, double kaina)
        {
            Id = id;
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            Kaina = kaina;
        }
    }
}
