﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11_4.Models
{
    public class Knyga
    {
        public int Id { get; set; }
        public string Pavadinimas { get; set; }
        public string Autorius { get; set; }
        public int IsleidimoMetai { get; set; }
        public string Zanras { get; set; }

        public Knyga()
        {

        }

        public Knyga(int id, string pavadinimas, string autorius, int isleidimoMetai, string zanras)
        {
            Id = id;
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            IsleidimoMetai = isleidimoMetai;
            Zanras = zanras;
        }
    }
}
