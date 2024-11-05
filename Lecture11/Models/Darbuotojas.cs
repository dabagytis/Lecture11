using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_1.Models
{
    public class Darbuotojas
    {
        public string Vardas { get; set; }
        public long AsmensKodas { get; set; }
        public double BazinisAtlyginimas { get; set; }

        public Darbuotojas()
        {

        }

        public Darbuotojas(string vardas, long asmensKodas, double bazinisAtlyginimas)
        {
            Vardas = vardas;
            AsmensKodas = asmensKodas;
            BazinisAtlyginimas = bazinisAtlyginimas;
        }

        double vadybininkoAtlyginimas = 0;
        double programuotojoAtlyginimas = 0;

        public double SkaiciuotiAtlyginima()
        {
                if (this is Vadybininkas)
                {
                    vadybininkoAtlyginimas = BazinisAtlyginimas * 1.1;
                    return vadybininkoAtlyginimas;
                }
                else
                {
                    programuotojoAtlyginimas = BazinisAtlyginimas * 1.2;
                    return programuotojoAtlyginimas;
                }
        }
    }
}
