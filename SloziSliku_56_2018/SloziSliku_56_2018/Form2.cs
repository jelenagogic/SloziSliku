using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SloziSliku_56_2018
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            popunigrid();
        }

        private void popunigrid()
        {
            dataGridView1.Rows.Clear();
            IgDb db = new IgDb();
            List<Igrac> igraci = db.dajrezultate();

            foreach (var igrac in igraci)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = igrac.ime;
                row.Cells[1].Value = igrac.vrste + " x " + igrac.kolone;
                row.Cells[2].Value = igrac.rezultat;
                row.Tag = igrac.id;
                dataGridView1.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }
    }
}
