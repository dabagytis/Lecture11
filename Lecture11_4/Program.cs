using Lecture11_4.Models;
using Lecture11_4.Repo;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Lecture11_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileRepo fileRepo = new FileRepo("Knygos.txt");

            List<Knyga> knygos = fileRepo.GautiVisasKnygas();

            while (true)
            {
                Console.WriteLine("Meniu");
                Console.WriteLine("1. Peržiūrėti visas knygas");
                Console.WriteLine("2. Filtruoti knygas pagal žanrą");
                Console.WriteLine("3. Rikiuoti knygas pagal išleidimo metus");
                Console.WriteLine("4. Ieškoti knygos pagal autorių ar pavadinimą");
                Console.WriteLine("5. Pridėti naują knygą");
                Console.WriteLine("6. Išsaugoti visų knygų informaciją į failą");
                Console.WriteLine();
                Console.WriteLine("Pasirinkite norima numeri:");
                int parinktis = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (parinktis)
                {
                    case 1:
                        foreach (Knyga a in knygos)
                        {
                            if (a is ElektronineKnyga)
                            {
                                ((ElektronineKnyga)a).SpausdintiElektronine();
                            }

                            if (a is PopierineKnyga)
                            {
                                ((PopierineKnyga)a).SpausdintiPopierine();
                            }
                        }
                        continue;

                    case 2:
                        Console.WriteLine("Iveskite knygos zanra:");
                        string zanrasPaieskai = Console.ReadLine();

                        foreach (Knyga a in knygos)
                        {
                            if (a.Zanras.Contains(zanrasPaieskai))
                            {
                                if(a is ElektronineKnyga)
                                {
                                    ((ElektronineKnyga)a).SpausdintiElektronine();
                                }
                                if(a is PopierineKnyga)
                                {
                                    ((PopierineKnyga)a).SpausdintiPopierine();
                                }
                            }
                        }
                        continue;

                    case 3:
                        knygos = KnyguRikiavimas(knygos);
                        continue;

                    case 4:
                        Console.WriteLine("Iveskite knygos autoriu ar pavadinima");
                        string paieska = Console.ReadLine();

                        foreach (Knyga a in knygos)
                        {
                            if (a.Pavadinimas.Contains(paieska) || a.Autorius.Contains(paieska))
                            {
                                if (a is ElektronineKnyga)
                                {
                                    ((ElektronineKnyga)a).SpausdintiElektronine();
                                }
                                else
                                {
                                    ((PopierineKnyga)a).SpausdintiPopierine();
                                }
                            }
                        }
                        continue;

                    case 5:
                        Console.WriteLine("Ar knyga elektronine, ar popierine?");
                        string tipas = Console.ReadLine();
                        Console.WriteLine("Iveskite knygos ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Iveskite knygos pavadinima:");
                        string pavadinimas = Console.ReadLine();
                        Console.WriteLine("Iveskite knygos autoriu:");
                        string autorius = Console.ReadLine();
                        Console.WriteLine("Iveskite knygos isleidimo metus:");
                        int isleidimoMetai = int.Parse(Console.ReadLine());
                        Console.WriteLine("Iveskite knygos zanra:");
                        string zanras = Console.ReadLine();
                        if (tipas == "Elektronine")
                        {
                            Console.WriteLine("Nurodykite failo dydi (mb):");
                            double failoDydisMB = double.Parse(Console.ReadLine());
                            Console.WriteLine("Iveskite knygos formata:");
                            string formatas = Console.ReadLine();
                            knygos.Add(new ElektronineKnyga(id, pavadinimas, autorius, isleidimoMetai, zanras, failoDydisMB, formatas));
                        }
                        else if (tipas == "Popierine")
                        {
                            Console.WriteLine("Iveskite knygos puslapiu skaiciu:");
                            int puslapiuSkaicius = int.Parse(Console.ReadLine());
                            knygos.Add(new PopierineKnyga(id, pavadinimas, autorius, isleidimoMetai, zanras, puslapiuSkaicius));
                        }
                        else
                        {
                            Console.WriteLine("Klaida, bandykite is naujo");
                            continue;
                        }
                        Console.WriteLine("Nauja knyga prideta prie bibliotekos");
                        Console.WriteLine();
                        continue;

                    case 6:
                        fileRepo.RasytiKnygasIFaila(knygos);
                        Console.WriteLine("Duomenys irasyti i faila");
                        Console.WriteLine();
                        continue;
                }
            }
        }

        public static List<Knyga> KnyguRikiavimas(List<Knyga> knygos)
        {
            int masyvas = knygos.Count;

            for (int i = 0; i < masyvas - 1; i++)
            {
                for (int j = 0; j < masyvas - i - 1; j++)
                {
                    if (knygos[j].IsleidimoMetai > knygos[j + 1].IsleidimoMetai)
                    {
                        Knyga tempKnyga = knygos[j];
                        knygos[j] = knygos[j + 1];
                        knygos[j + 1] = tempKnyga;
                    }
                }
            }
            return knygos;
        }
    }
}