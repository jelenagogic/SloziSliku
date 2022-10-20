using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SloziSliku_56_2018
{
    class ConnectionDb
    {
        private static SqlConnection instance = null;
        private static readonly object padlock = new object();

        public static SqlConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SqlConnection(Properties.Settings.Default.connection);
                        }
                    }
                }
                return instance;
            }
        }
    }
}
