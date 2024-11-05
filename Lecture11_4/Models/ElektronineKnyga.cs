using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_4.Models
{
    public class ElektronineKnyga: Knyga
    {
        public double FailoDydisMB { get; set; }
        public string Formatas { get; set; }

        public ElektronineKnyga(int id, string pavadinimas, string autorius, int isleidimoMetai, string zanras, double failoDydisMB, string formatas): base(id, pavadinimas, autorius, isleidimoMetai, zanras)
        {
            FailoDydisMB = failoDydisMB;
            Formatas = formatas;
        }

        public void SpausdintiElektronine()
        {
            Console.WriteLine($"ID: {Id}; Pavadinimas: {Pavadinimas}; Autorius: {Autorius}; Metai: {IsleidimoMetai}; Zanras: {Zanras}");
            Console.WriteLine($"Tipas: Elektronine Knyga; Failo Dydis: {FailoDydisMB}; Formatas: {Formatas}");
            Console.WriteLine();
        }
    }
}
