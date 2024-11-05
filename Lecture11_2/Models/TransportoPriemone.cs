using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_2.Models
{
    public class TransportoPriemone
    {
        public string Pavadinimas { get; set; }
        public int KuroSanaudos100km { get; set; }

        public TransportoPriemone()
        {

        }

        public TransportoPriemone(string pavadinimas, int kuroSanaudos100km)
        {
            Pavadinimas = pavadinimas;
            KuroSanaudos100km = kuroSanaudos100km;
        }

        public int ApskaiciuotiKuroSanaudas(int kelias)
        {
            int Sanaudos = KuroSanaudos100km * kelias / 100;
            return Sanaudos;
        }
    }
}
