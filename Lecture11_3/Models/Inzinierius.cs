using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_3.Models
{
    public class Inzinierius: Darbuotojas
    {
        public string Specializacija { get; set; }

        public Inzinierius(int id, string vardas, string pavarde, double atlyginimas, string specializacija): base(id, vardas, pavarde, atlyginimas)
        {
            Specializacija = specializacija;
        }

        public void SpausdintiInzinieriu()
        {
            Console.WriteLine($"ID: {Id}; Vardas: {Vardas} {Pavarde}; Atlyginimas: {Atlyginimas}eur; Pareigos: Inzinierius; Specializacija: {Specializacija}");
        }
    }
}
