using Lecture11_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_3.Repo
{
    public class FileRepo
    {
        private string _fileLocation;

        public FileRepo(string fileLocation)
        {
            _fileLocation = fileLocation;
        }

        public List<Darbuotojas> GautiVisusDarbuotojus()
        {
            List<Darbuotojas> darbuotojai = new List<Darbuotojas>();
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

                    if (reiksmes[4] == "Vadybininkas")
                    {
                        darbuotojai.Add(new Vadybininkas(int.Parse(reiksmes[0]), reiksmes[1], reiksmes[2], double.Parse(reiksmes[3]), reiksmes[5]));
                    }
                    if (reiksmes[4] == "Inzinierius")
                    {
                        darbuotojai.Add(new Inzinierius(int.Parse(reiksmes[0]), reiksmes[1], reiksmes[2], double.Parse(reiksmes[3]), reiksmes[5]));
                    }
                }
            }
            return darbuotojai;
        }
    }
}
