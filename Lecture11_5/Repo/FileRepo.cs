using Lecture11_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_5.Repo
{
    public class FileRepo
    {
        private string _fileLocation;

        public FileRepo(string fileLocation)
        {
            _fileLocation = fileLocation;
        }

        public List<Automobilis> GautiAutomobilius()
        {
            List<Automobilis> automobiliai = new List<Automobilis>();
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

                    if (reiksmes[5] == "Elektrinis Automobilis")
                    {
                        automobiliai.Add(new ElektrinisAutomobilis(int.Parse(reiksmes[0]), reiksmes[1], reiksmes[2], int.Parse(reiksmes[3]), double.Parse(reiksmes[4]), double.Parse(reiksmes[6]), int.Parse(reiksmes[7])));
                    }
                    if (reiksmes[5] == "Vidaus Degimo Automobilis")
                    {
                        automobiliai.Add(new VidausDegimoAutomobilis(int.Parse(reiksmes[0]), reiksmes[1], reiksmes[2], int.Parse(reiksmes[3]), double.Parse(reiksmes[4]), reiksmes[6]));
                    }
                }
            }
            return automobiliai;
        }

        public void RasytiIFaila(List<Automobilis> automobiliai)
        {
            using (StreamWriter sw = new StreamWriter(_fileLocation))
            {
                foreach (Automobilis a in automobiliai)
                {
                    if (a is ElektrinisAutomobilis)
                    {
                        ElektrinisAutomobilis b = (ElektrinisAutomobilis)a;
                        sw.WriteLine($"{b.Id};{b.Marke};{b.Modelis};{b.Metai};{b.Kaina};Elektrinis Automobilis;{b.BaterijosTalpa};{b.MaxNuotolis}");
                    }
                    else if (a is VidausDegimoAutomobilis)
                    {
                        VidausDegimoAutomobilis c = (VidausDegimoAutomobilis)a;
                        sw.WriteLine($"{c.Id};{c.Marke};{c.Modelis};{c.Metai};{c.Kaina};Vidaus Degimo Automobilis;{c.KuroTipas}");
                    }
                }
                sw.Close();
            }
        }
    }
}
