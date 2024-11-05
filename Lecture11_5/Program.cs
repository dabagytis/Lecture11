using Lecture11_5.Models;
using Lecture11_5.Repo;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Lecture11_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileRepo fileRepo = new FileRepo("Automobiliai.txt");

            List<Automobilis> automobiliai = fileRepo.GautiAutomobilius();

            while (true)
            {
                Console.WriteLine("Meniu");
                Console.WriteLine("1. Peržiūrėti visus automobilius");
                Console.WriteLine("2. Pridėti naują automobilį");
                Console.WriteLine("3. Išsaugoti automobilių informaciją į failą");
                Console.WriteLine("4. Baigti programą");
                Console.WriteLine();
                Console.WriteLine("Pasirinkite norima numeri:");
                int parinktis = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (parinktis)
                {
                    case 1:
                        foreach (Automobilis a in automobiliai)
                        {
                            if (a is ElektrinisAutomobilis)
                            {
                                ((ElektrinisAutomobilis)a).SpausdintiElektrini();
                            }

                            else if (a is VidausDegimoAutomobilis)
                            {
                                ((VidausDegimoAutomobilis)a).SpausdintiVidausDegimo();
                            }
                        }
                        continue;

                    case 2:
                        Console.WriteLine("Ar automobilis elektrinis, ar vidaus degimo?");
                        string tipas = Console.ReadLine();
                        Console.WriteLine("Iveskite automobilio ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Iveskite automobilio marke:");
                        string marke = Console.ReadLine();
                        Console.WriteLine("Iveskite automobilio modeli:");
                        string modelis = Console.ReadLine();
                        Console.WriteLine("Iveskite automobilio isleidimo metus:");
                        int metai = int.Parse(Console.ReadLine());
                        Console.WriteLine("Iveskite automobilio kaina:");
                        double kaina = double.Parse(Console.ReadLine());
                        if (tipas.ToLower() == "elektrinis")
                        {
                            Console.WriteLine("Iveskite automobilio baterijos talpa (mb):");
                            double baterijosTalpa = double.Parse(Console.ReadLine());
                            Console.WriteLine("Iveskite maksimalu nuotoli, kuri automobilis gali nuvaziuoti vienu krovimu:");
                            int maxNuotolis = int.Parse(Console.ReadLine());
                            automobiliai.Add(new ElektrinisAutomobilis(id, marke, modelis, metai, kaina, baterijosTalpa, maxNuotolis));
                        }
                        else if (tipas.ToLower() == "vidaus degimo")
                        {
                            Console.WriteLine("Iveskite automobilio kuro tipa:");
                            string kuroTipas = Console.ReadLine();
                            automobiliai.Add(new VidausDegimoAutomobilis(id, marke, modelis, metai, kaina, kuroTipas));
                        }
                        else
                        {
                            Console.WriteLine("Klaida, bandykite is naujo");
                            continue;
                        }
                        Console.WriteLine("Automobilis pridetas i sarasa");
                        Console.WriteLine();
                        continue;

                    case 3:
                        fileRepo.RasytiIFaila(automobiliai);
                        Console.WriteLine("Duomenys irasyti i faila");
                        Console.WriteLine();
                        continue;

                    case 4:
                        return;
                }
            }
        }
    }
}