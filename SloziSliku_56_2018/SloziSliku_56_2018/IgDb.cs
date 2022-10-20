using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SloziSliku_56_2018
{
    public class IgDb
    {
        SqlConnection conn = ConnectionDb.Instance;

        public void upisi(string ime, int vrste, int kolone, int brPoteza)
        {
            string query = "insert into igraci values(@ime,@vrste,@kolone,@brPoteza)";
            SqlCommand command = new SqlCommand(query, conn);

            conn.Open();
            command.Parameters.AddWithValue("@ime",ime);
            command.Parameters.AddWithValue("@vrste", vrste);
            command.Parameters.AddWithValue("@kolone", kolone);
            command.Parameters.AddWithValue("@brPoteza", brPoteza);

            int rezultat = command.ExecuteNonQuery();
            conn.Close();

            if (rezultat > 0)
            {
                MessageBox.Show("Uspesno upisano!");
            }
            else
            {
                MessageBox.Show("Nije moguce upisati!");
            }
        }

        public List<Igrac> dajrezultate()
        {
            List<Igrac> igraci = new List<Igrac>();

            conn.Open();
            String query = @"select top 10 * 
                           from igraci 
                           order by brPoteza desc";

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Igrac i = new Igrac
                {
                    id = int.Parse(reader["id"].ToString()),
                    ime = reader["ime"].ToString(),
                    vrste = int.Parse(reader["vrste"].ToString()),
                    kolone = int.Parse(reader["kolone"].ToString()),
                    rezultat = int.Parse(reader["brPoteza"].ToString())

                };
                igraci.Add(i);
            }
            conn.Close();

            return igraci;
        }

    }
}
