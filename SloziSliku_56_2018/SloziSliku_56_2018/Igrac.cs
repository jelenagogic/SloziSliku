using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloziSliku_56_2018
{
    public class Igrac
    {
        public int id;
        public string ime;
        public int rezultat;
        public int vrste;
        public int kolone;
       
        

        public override string ToString()
        {
            return "Ime: " + ime + "   Igra je na tabli dimenzija: " + vrste + " x " + kolone + "      Broj poteza:" + rezultat;
        }
    }
}
