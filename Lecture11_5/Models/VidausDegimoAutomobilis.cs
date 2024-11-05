using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_5.Models
{
    public class VidausDegimoAutomobilis: Automobilis
    {
        public string KuroTipas { get; set; }

        public VidausDegimoAutomobilis(int id, string marke, string modelis, int metai, double kaina, string kuroTipas): base (id, marke, modelis, metai, kaina)
        {
            KuroTipas = kuroTipas;
        }

        public void SpausdintiVidausDegimo()
        {
            Console.WriteLine($"ID: {Id}; Pavadinimas: {Marke} {Modelis}; Metai; {Metai}; Kaina: {Kaina}eur");
            Console.WriteLine($"Tipas: Vidaus Degimo Automobilis; Kuro tipas: {KuroTipas}");
            Console.WriteLine();
        }
    }
}
