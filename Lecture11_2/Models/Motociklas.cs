using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_2.Models
{
    public class Motociklas: TransportoPriemone
    {
        public Motociklas(string pavadinimas, int kuroSanaudos100km): base(pavadinimas, kuroSanaudos100km)
        {

        }
    }
}
