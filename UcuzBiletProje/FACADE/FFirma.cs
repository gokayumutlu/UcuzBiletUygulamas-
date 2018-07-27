using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcuzBiletProje.ENTITY;
namespace UcuzBiletProje.FACADE
{
    class FFirma
    {
        public static int Insert(EFirma eFirma)
        {
            SqlCommand sqlCommand = null;
            int girilen = 0;
            try
            {
                sqlCommand = new SqlCommand("Firma_Ekle", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                {
                    sqlCommand.Connection.Open();
                }
                sqlCommand.Parameters.AddWithValue("firmaAdi", eFirma.firmaAdi);
                
                girilen = sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Firma ekleme başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sqlCommand.Connection.Close();
            }
            return girilen;
        }

        public static int Delete(int Id)
        {
            int silme = 0;
            SqlCommand sqlCommand = null;
            try
            {
                sqlCommand = new SqlCommand("Firma_Sil", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                    sqlCommand.Connection.Open();
                sqlCommand.Parameters.AddWithValue("firmaId", Id);
                silme = sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Firma silme başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                silme = -1;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return silme;
        }

        public static int Update(EFirma eFirma)
        {
            SqlCommand sqlCommand = null;
            int degistirilen = 0;
            try
            {
                sqlCommand = new SqlCommand("Firma_Guncelle", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                {
                    sqlCommand.Connection.Open();
                }
                sqlCommand.Parameters.AddWithValue("firmaId", eFirma.firmaId);
                sqlCommand.Parameters.AddWithValue("firmaAdi", eFirma.firmaAdi);
                
                

                degistirilen = sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Firma güncelleme başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                degistirilen = -1;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }
            return degistirilen;
        }

        public static EFirma BirFirma(int Id)
        {
            EFirma firma = null;
            SqlCommand sqlCommand = null;
            try
            {
                sqlCommand = new SqlCommand("Firma_Getir", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                {
                    sqlCommand.Connection.Open();
                }
                sqlCommand.Parameters.AddWithValue("firmaId", Id);
                SqlDataReader rdr = sqlCommand.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        firma = new EFirma();
                        firma.firmaAdi = rdr["firmaAdi"].ToString();
                        
                    }
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                firma = null;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return firma;
        }

        public static List<EFirma> ButunFirmalar()
        {
            List<EFirma> firma = null;
            SqlCommand sqlCommand = null;
            try
            {
                sqlCommand = new SqlCommand("Firmalari_Getir", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                {
                    sqlCommand.Connection.Open();
                }
                SqlDataReader rdr = sqlCommand.ExecuteReader();
                if (rdr.HasRows)
                {
                    firma = new List<EFirma>();
                    while (rdr.Read())
                    {
                        EFirma f = new EFirma();
                        f.firmaAdi = rdr["firmaAdi"].ToString();
                        f.firmaId=Convert.ToInt32(rdr["firmaId"]);
                        
                        firma.Add(f);
                    }
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                firma = null;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return firma;
        }
    }
}
