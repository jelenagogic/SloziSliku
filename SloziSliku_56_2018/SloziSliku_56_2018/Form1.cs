using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SloziSliku_56_2018
{
    public partial class Form1 : Form
    {
        
        public bool kraj = false;
        public Image slika = null;
        public static int kolone = 3;
        public static int vrste = 3;
        public List<List<int>> polja; //polja
        public int debljinaLinija;
        Color bojaLinija;
        public int brPoteza = 0;
        public int x = 0, y = 0, ind = 1;
        public int levo, desno, gore, dole;
        public int pomLevo, pomDesno, pomGore, pomDole, desnoispis;
        List<PictureBox> slikaPolja = new List<PictureBox>(); 
        
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;

            polja = new List<List<int>>();
            int v = 0;
            for (int i = 0; i < vrste; i++)
            {
                List<int> vrsta = new List<int>();
                for (int j = 0; j < kolone; j++)
                {
                    v = 0;
                    vrsta.Add(v);
                }
                polja.Add(vrsta);
            }

            debljinaLinija = 1;
            pomLevo = pomDole = pomGore = desnoispis = 40;
            pomDesno = 110;
            bojaLinija = Color.FromArgb(255, 128, 0, 0);     
            vrsta3.Checked = true;
            kolona3.Checked = true;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics ggraphics = this.CreateGraphics();
            Rectangle polje = this.ClientRectangle;
            levo = polje.X + pomLevo;
            gore = polje.Y + pomGore;
            desno = polje.Width - (pomDesno + desnoispis);
            dole = polje.Height - pomDole;

            y = (dole - gore) / vrste;
            dole = gore + vrste * y;

            x = (desno - levo) / kolone;
            desno = levo + kolone * x;

            
            //crtaj
            Pen pen = new Pen(bojaLinija, debljinaLinija);
            int n;

            if (kolone > vrste) 
                n = kolone;
            else
                n = vrste;

            for (int i = 0; i <= n; i++)
            {
                e.Graphics.DrawLine(pen, levo, gore + i * y, desno + debljinaLinija - 1, gore + i * y);
                e.Graphics.DrawLine(pen, levo + i * x, gore, levo + (i * x), dole + debljinaLinija - 1);
            }
        }


        private void load_images()
        {
            int a = pomLevo + 1;
            int b = pomGore + 1;
           
            int x1 = 0;
            
            int y1 = -(slika.Height) / vrste;
            for (int i = 0; i < vrste; i++)
            {
                y1 += (slika.Height) / vrste;
                x1 = -(slika.Width) / kolone;
                for (int j = 0; j < kolone; j++)
                {
                    x1 += (slika.Width) / kolone;

                    Image slika1 = iseciSliku(slika, new Rectangle(x1, y1, slika.Width - x1 - debljinaLinija * kolone, slika.Height - y1 - debljinaLinija * vrste));

                    var slikaBox = new PictureBox
                    {
                        Name = "picBox" + i + "" + j,
                        Size = new Size(x - 2, y - 2),
                        Location = new Point(a, b),

                        Image = slika1
                    };

                    slikaBox.MouseDoubleClick += new MouseEventHandler(picture_MouseDoubleClick);

                    a += x;

                    slikaPolja.Add(slikaBox);
                    this.Controls.Add(slikaBox);
                }
                a = pomLevo + 1;
                b += y;

            }
            this.Refresh();
        }

        private static Image iseciSliku(Image img, Rectangle cropArea)
        {
            Bitmap bmslika = new Bitmap(img);
            Bitmap iseci = bmslika.Clone(cropArea, bmslika.PixelFormat);
            return (Image)(iseci);
        }

        private void picture_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PictureBox slika = (PictureBox)sender;
            Point pozicija = new Point(x, y);
            if (slikaPolja.LastOrDefault().Location.X == slika.Location.X)
            {
                if (slikaPolja.LastOrDefault().Location.Y == (slika.Location.Y + pozicija.Y) || slikaPolja.LastOrDefault().Location.Y == (slika.Location.Y - pozicija.Y))
                {
                    dodajPotez();
                    Point p = slika.Location;
                    slika.Location = slikaPolja.LastOrDefault().Location;
                    slikaPolja.LastOrDefault().Location = p;
                    this.Refresh();
                }
            }
            else if(slikaPolja.LastOrDefault().Location.Y == slika.Location.Y)
            {
                if (slikaPolja.LastOrDefault().Location.X == (slika.Location.X + pozicija.X) || slikaPolja.LastOrDefault().Location.X == (slika.Location.X - pozicija.X))
                {
                    dodajPotez();
                    Point p = slika.Location;
                    slika.Location = slikaPolja.LastOrDefault().Location;
                    slikaPolja.LastOrDefault().Location = p;
                    this.Refresh();
                }
            }
        }
        
        private void dodajPotez()
        {
            lbl_odigraniPotezi.Text = (++brPoteza).ToString();
        }

        private void btn_ucitajSliku_Click(object sender, EventArgs e)
        {

            OpenFileDialog dijalog = new OpenFileDialog();
            dijalog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (dijalog.ShowDialog() == DialogResult.OK)
            {
                string imeSlike;
                imeSlike = dijalog.FileName;
                imeSlike = Path.GetFileName(imeSlike);
     
                if (slika != null)
                {
                    obrisiSlike();
                }
                slika = Image.FromFile(dijalog.FileName);
                slika = dajSliku(slika, x, y);

                lbl_nazivSlike.Text = imeSlike.ToString();
                load_images();
                this.Refresh();
            }
        }

        public static Bitmap dajSliku(Image image, int x, int y)
        {
            var pravoug = new Rectangle(0, 0, x * kolone, y * vrste);
            var slika = new Bitmap(x * kolone, y * vrste);

            slika.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                var graphics = Graphics.FromImage(slika);

                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, pravoug, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
         
            return slika;
        }

     

        private void obrisiSlike()
        {
            List<Control> brisanje = new List<Control>();
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    brisanje.Add(control);
                }
            }
            for (int i = 0; i < brisanje.Count; i++)
            {
                this.Controls.Remove(brisanje[i]);
            }


            this.Refresh();
        }

        private void btn_bojaLinija_Click(object sender, EventArgs e)
        {
            ColorDialog izaberiBoju = new ColorDialog();
            if (izaberiBoju.ShowDialog() == DialogResult.OK)
            {
                bojaLinija = izaberiBoju.Color;
            }
            this.Refresh();
        }


        private void vrsta4_CheckedChanged(object sender, EventArgs e)
        {
            vrste = 4;
            if (slika != null)
            {
                ind = 0;
                obrisiSlike();
                load_images();
            }
            this.Refresh();
        }
        private void vrsta5_CheckedChanged(object sender, EventArgs e)
        {
            vrste = 5;
            if (slika != null)
            {
                ind = 0;
                obrisiSlike();
                load_images();
            }
            this.Refresh();
        }

        private void btn_sacuvaj_Click(object sender, EventArgs e)
        {
           
            Stanje stanje = new Stanje(vrste, kolone, bojaLinija, brPoteza, slika); // slikaPolja);
            //Stanje stanje = new Stanje(vrste, kolone,  bojaLinija, brPoteza); //, slikaPolja);
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string naziv = dialog.FileName;
                IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Stream stream = new FileStream(naziv, FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, stanje);

                stream.Close();
            }

        }

        private void btn_otvori_Click(object sender, EventArgs e)
        {
        
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string name = dialog.FileName;
                IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Stream stream = new FileStream(name, FileMode.Open, FileAccess.Read);
                Stanje s = (Stanje)formatter.Deserialize(stream);
                this.Refresh();
                kolone = s.Kolona;
                vrste = s.Vrsta;
                bojaLinija = (s.BojaLinija);      
                lbl_odigraniPotezi.Text = s.Br_poteza.ToString();
                slika = s.Slika;
                

                obrisiSlike();
                dajSliku(slika, kolone, vrste);
                load_images();
               // izrotiraj();
                stream.Close();
                Invalidate();
            }
        }

        private void btn_upisiIme_Click(object sender, EventArgs e)
        {
            if (lbl_unesiIme.Text != "")
            {
                string ime = lbl_unesiIme.Text;
                int k = kolone;
                int v = vrste;
                int pot = brPoteza;
                IgDb db = new IgDb();
                db.upisi(ime, v, k, pot);
            }
            else
            {
                MessageBox.Show("Unesite svoje ime!");
            }
          
        }

        private void btn_prikaziRezultate_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void kolona3_CheckedChanged(object sender, EventArgs e)
        {
            kolone = 3;

            if (slika != null)
            {
                ind = 0;
                obrisiSlike();
                load_images();
            }
            this.Refresh();
        }

        private void kolona4_CheckedChanged(object sender, EventArgs e)
        {
            kolone = 4;

            if (slika != null)
            {
                ind = 0;
                obrisiSlike();
                load_images();
            }
            this.Refresh();
        }

        private void kolona5_CheckedChanged(object sender, EventArgs e)
        {
            kolone = 5;

            if (slika != null)
            {
                ind = 0;
                obrisiSlike();
                load_images();
            }
            this.Refresh();
        }

        private void vrsta3_CheckedChanged(object sender, EventArgs e)
        {
            vrste = 3;
            if (slika != null)
            {
                ind = 0;
                obrisiSlike();
                load_images();
            }
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (slika == null)
            {
                MessageBox.Show("Morate ucitati sliku da biste poceli igru!");
            }
            else
            {
                brPoteza = 0;
                lbl_odigraniPotezi.Text = (brPoteza).ToString();
                izrotiraj();
            }
        }

        private List<Point> dajLokacije()
        {
            List<Point> lokacije = new List<Point>();

            for (int  i=0; i<slikaPolja.Count; i++)
            {
                lokacije.Add(slikaPolja[i].Location);        
            }

            return lokacije;
        }
        private void izrotiraj()
        {
            Random random = new Random();
            List<Point> lokacija = new List<Point>();

            if (ind == 0)
            {
                obrisiSlike();
                load_images();
                lokacija = dajLokacije();

                for (int i=0; i<slikaPolja.Count; i++)
                {
                    var k = random.Next(0, lokacija.Count - 1);
                    lokacija.RemoveAt(k);
                }
                slikaPolja.LastOrDefault().Image = null;
                this.Refresh();
            }
            else
            {
                lokacija = dajLokacije();
                for (int i = 0; i < slikaPolja.Count; i++)
                {
                    var k = random.Next(0, lokacija.Count);

                    slikaPolja[i].Location = lokacija[k];
                    lokacija.RemoveAt(k);
                }

                slikaPolja.LastOrDefault().Image = null;
                this.Refresh();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void btn_Kraj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
