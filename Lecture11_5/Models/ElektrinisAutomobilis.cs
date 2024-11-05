using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_5.Models
{
    public class ElektrinisAutomobilis: Automobilis
    {
        public double BaterijosTalpa { get; set; }
        public int MaxNuotolis { get; set; }

        public ElektrinisAutomobilis(int id, string marke, string modelis, int metai, double kaina, double baterijosTalpa, int maxNuotolis) : base(id, marke, modelis, metai, kaina)
        {
            BaterijosTalpa = baterijosTalpa;
            MaxNuotolis = maxNuotolis;
        }

        public void SpausdintiElektrini()
        {
            Console.WriteLine($"ID: {Id}; Pavadinimas: {Marke} {Modelis}; Metai; {Metai}; Kaina: {Kaina}eur");
            Console.WriteLine($"Tipas: Elektrinis Automobilis; Baterijos talpa: {BaterijosTalpa}; Maksimalus nuotolis vienu ikrovimu: {MaxNuotolis}km");
            Console.WriteLine();
        }
    }
}
