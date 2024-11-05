using Lecture11_3.Models;
using Lecture11_3.Repo;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Lecture11_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileRepo fileRepo = new FileRepo("Darbuotojai.txt");

            List<Darbuotojas> darbuotojai = fileRepo.GautiVisusDarbuotojus();

            foreach (Darbuotojas a in darbuotojai)
            {
                if (a is Vadybininkas)
                {
                    ((Vadybininkas)a).SpausdintiVadybininka();
                }
                if (a is Inzinierius)
                {
                    ((Inzinierius)a).SpausdintiInzinieriu();
                }
            }
        }
    }
}