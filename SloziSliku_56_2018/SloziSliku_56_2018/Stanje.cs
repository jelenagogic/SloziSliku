using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SloziSliku_56_2018
{
    [Serializable]
    public class Stanje
    {
        private int br_poteza;
        private Color bojaLinija;
        private int kolona;
        private int vrsta;
        private Image slika;

        public int Kolona { get => kolona; set => kolona = value; }
        public int Vrsta { get => vrsta; set => vrsta = value; }
        public int Br_poteza { get => br_poteza; set => br_poteza = value; }
        public Color BojaLinija { get => bojaLinija; set => bojaLinija = value; }
        public Image Slika { get => slika; set => slika = value; }
        //public List<PictureBox> SlikaPolja { get => slikaPolja; set => slikaPolja = value; }

        //List<PictureBox> slikaPolja = new List<PictureBox>();


        public Stanje(int kolona, int vrsta,  Color boja, int br_poteza,Image slika)//, List<PictureBox> polja)
        {
            this.kolona = kolona;
            this.vrsta = vrsta;
            this.bojaLinija = boja;
            this.br_poteza = br_poteza;
            this.slika = slika;
           // this.slikaPolja = polja;
        }

        public Stanje()
        { }
    }
}
