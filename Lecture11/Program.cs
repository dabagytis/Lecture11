using Lecture11_1.Models;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Lecture11_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vadybininkas vadybininkas = new Vadybininkas("Jonas Jonaitis", 39566666666, 5000);
            Programuotojas programuotojas = new Programuotojas("Petras Petraitis", 39577777777, 4000);

            List<Darbuotojas> darbuotojai = new List<Darbuotojas>();

            darbuotojai.Add(vadybininkas);
            darbuotojai.Add(programuotojas);

            foreach(Darbuotojas a in darbuotojai)
            {
                if (a is Vadybininkas)
                {
                    Console.WriteLine($"Vardas: {((Vadybininkas)a).Vardas}; Atlyginimas: {((Vadybininkas)a).SkaiciuotiAtlyginima()}eur");
                }
                else if (a is Programuotojas)
                {
                    Console.WriteLine($"Vardas: {((Programuotojas)a).Vardas}; Atlyginimas: {((Programuotojas)a).SkaiciuotiAtlyginima()}eur");
                }
            }
        }
    }
}