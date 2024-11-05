using Lecture11_2.Models;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Lecture11_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Automobilis automobilis = new Automobilis("Honda Civic", 10);
            Motociklas motociklas = new Motociklas("Yamaha", 6);

            List<TransportoPriemone> transportas = new List<TransportoPriemone>();

            transportas.Add(automobilis);
            transportas.Add(motociklas);

            Console.WriteLine("Iveskite nuvaziuota atstuma (km):");
            int kelias = int.Parse(Console.ReadLine());
            Console.WriteLine();

            foreach (TransportoPriemone a in transportas)
            {
                if (a is Automobilis)
                {
                    Console.WriteLine($"Automobilis: {automobilis.Pavadinimas}; Nuvaziuotas atstumas: {kelias}km; Sunaudota kuro: {automobilis.ApskaiciuotiKuroSanaudas(kelias)}l");
                    Console.WriteLine();
                }
                if (a is Motociklas)
                {
                    Console.WriteLine($"Motociklas: {motociklas.Pavadinimas}; Nuvaziuotas atstumas: {kelias}km; Sunaudota kuro: {motociklas.ApskaiciuotiKuroSanaudas(kelias)}l");
                    Console.WriteLine();
                }
            }
        }
    }
}