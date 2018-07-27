using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcuzBiletProje.ENTITY;
using System.Windows.Forms;
namespace UcuzBiletProje.FACADE
{
    class FFirmaYetkilisi
    {
        public static List<EFirmaYetkilisi> FirmaGorevlileri()
        {
            List<EFirmaYetkilisi> fGorevlileri = null;
            SqlCommand sqlCommand = null;
            try
            {
                sqlCommand = new SqlCommand("Firma_Yetkilileri_Getir", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                {
                    sqlCommand.Connection.Open();
                }
                SqlDataReader rdr = sqlCommand.ExecuteReader();
                if (rdr.HasRows)
                {
                    fGorevlileri = new List<EFirmaYetkilisi>();
                    while (rdr.Read())
                    {
                        EFirmaYetkilisi fY = new EFirmaYetkilisi();
                        fY.fyetkiliId = Convert.ToInt32(rdr["fyetkiliId"]);
                        fY.adS = rdr["adS"].ToString();
                        fY.email = rdr["email"].ToString();
                        fY.telefon = rdr["telefon"].ToString();
                        fY.firmaAdi = rdr["firmaAdi"].ToString();
                        fGorevlileri.Add(fY);

                    }
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                fGorevlileri = null;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return fGorevlileri;
        }
    }
}
