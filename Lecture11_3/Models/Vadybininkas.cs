using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_3.Models
{
    public class Vadybininkas: Darbuotojas
    {
        public string Skyrius { get; set; }

        public Vadybininkas(int id, string vardas, string pavarde, double atlyginimas, string skyrius): base(id, vardas, pavarde, atlyginimas)
        {
            Skyrius = skyrius;
        }

        public void SpausdintiVadybininka()
        {
            Console.WriteLine($"ID: {Id}; Vardas: {Vardas} {Pavarde}; Atlyginimas: {Atlyginimas}eur; Pareigos: Vadybininkas; Skyrius: {Skyrius}");
        }
    }
}
