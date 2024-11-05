using Lecture11_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_4.Repo
{
    public class FileRepo
    {
        private string _fileLocation;

        public FileRepo(string fileLocation)
        {
            _fileLocation = fileLocation;
        }

        public List<Knyga> GautiVisasKnygas()
        {
            List<Knyga> knygos = new List<Knyga>();
            using (StreamReader sr = new StreamReader(_fileLocation))
            {
                while (!sr.EndOfStream)
                {
                    string eilute = sr.ReadLine();
                    if (string.IsNullOrEmpty(eilute))
                    {
                        break;
                    }
                    string[] reiksmes = eilute.Split(';');

                    if (reiksmes[5] == "Elektronine Knyga")
                    {
                        knygos.Add(new ElektronineKnyga(int.Parse(reiksmes[0]), reiksmes[1], reiksmes[2], int.Parse(reiksmes[3]), reiksmes[4], double.Parse(reiksmes[6]), reiksmes[7]));
                    }
                    if (reiksmes[5] == "Popierine Knyga")
                    {
                        knygos.Add(new PopierineKnyga(int.Parse(reiksmes[0]), reiksmes[1], reiksmes[2], int.Parse(reiksmes[3]), reiksmes[4], int.Parse(reiksmes[6])));
                    }
                }
            }
            return knygos;
        }

        public void RasytiKnygasIFaila(List<Knyga> knygos)
        {
            using (StreamWriter sw = new StreamWriter(_fileLocation))
            {
                foreach (Knyga a in knygos)
                {
                    if (a is ElektronineKnyga)
                    {
                        ElektronineKnyga b = (ElektronineKnyga)a;
                        sw.WriteLine($"{b.Id};{b.Pavadinimas};{b.Autorius};{b.IsleidimoMetai};{b.Zanras};Elektronine Knyga;{b.FailoDydisMB};{b.Formatas}");
                    }
                    else if (a is PopierineKnyga)
                    {
                        PopierineKnyga c = (PopierineKnyga)a;
                        sw.WriteLine($"{c.Id};{c.Pavadinimas};{c.Autorius};{c.IsleidimoMetai};{c.Zanras};Popierine Knyga;{c.PuslapiuSkaicius}");
                    }
                }
                sw.Close();
            }
        }
    }
}