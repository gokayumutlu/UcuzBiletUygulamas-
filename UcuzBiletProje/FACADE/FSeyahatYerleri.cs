using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcuzBiletProje.ENTITY;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace UcuzBiletProje.FACADE
{
    class FSeyahatYerleri
    {
        public static List<ESeyahatYerleri> SeyahatYerleri()
        {
            List<ESeyahatYerleri> seyahatYeri = null;
            SqlCommand sqlCommand = null;
            SqlDataReader rdr=null;
            try
            {
                sqlCommand = new SqlCommand("Seyahat_Yerleri", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                {
                    sqlCommand.Connection.Open();
                }
                rdr = sqlCommand.ExecuteReader();
                if (rdr.HasRows)
                {
                    seyahatYeri = new List<ESeyahatYerleri>();
                    while (rdr.Read())
                    {
                        ESeyahatYerleri sY = new ESeyahatYerleri();
                        sY.yerId = Convert.ToInt32(rdr["yerId"].ToString());
                        sY.yerAdi = rdr["yerAdi"].ToString();

                        seyahatYeri.Add(sY);
                    }
                }
                else
                {
                    rdr.Close();
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                seyahatYeri = null;
            }
            finally
            {
                sqlCommand.Connection.Close();
                rdr.Close();
            }

            return seyahatYeri;
        }
    }
}
