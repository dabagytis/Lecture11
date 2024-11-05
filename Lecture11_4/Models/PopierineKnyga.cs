using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_4.Models
{
    public class PopierineKnyga: Knyga
    {
        public int PuslapiuSkaicius { get; set; }

        public PopierineKnyga(int id, string pavadinimas, string autorius, int isleidimoMetai, string zanras, int puslapiuSkaicius): base(id, pavadinimas, autorius, isleidimoMetai, zanras)
        {
            PuslapiuSkaicius = puslapiuSkaicius;
        }

        public void SpausdintiPopierine()
        {
            Console.WriteLine($"ID: {Id}; Pavadinimas: {Pavadinimas}; Autorius: {Autorius}; Metai: {IsleidimoMetai}; Zanras: {Zanras}");
            Console.WriteLine($"Tipas: Popierine Knyga; Puslapiu Skaicius: {PuslapiuSkaicius}");
            Console.WriteLine();
        }
    }
}
