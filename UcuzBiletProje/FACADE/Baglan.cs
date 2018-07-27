using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcuzBiletProje.FACADE
{
    class Baglan
    {
        public static readonly SqlConnection Con = new SqlConnection("Data Source=DESKTOP-RPUTUBP;Initial Catalog=son;Integrated Security=True");
    }
}
