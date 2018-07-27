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
    class FKullanici
    {
        public static int Insert(EKullanici eKullanici)
        {
            SqlCommand sqlCommand = null;
            int girilen=0;
            try
            {
                sqlCommand = new SqlCommand("Kullanici_Ekle", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                {
                    sqlCommand.Connection.Open();
                }
                sqlCommand.Parameters.AddWithValue("adS",eKullanici.adS);
                sqlCommand.Parameters.AddWithValue("email", eKullanici.email);
                sqlCommand.Parameters.AddWithValue("telefon", eKullanici.telefon);
                sqlCommand.Parameters.AddWithValue("password", eKullanici.password);
                girilen = sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Ekleme başarılı");
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
                sqlCommand = new SqlCommand("Kullanici_Sil", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                    sqlCommand.Connection.Open();
                sqlCommand.Parameters.AddWithValue("kullaniciId", Id);
                silme = sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Silme başarılı");
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

        public static int Update(EKullanici eKullanici)
        {
            SqlCommand sqlCommand = null;
            int degistirilen = 0;
            try
            {
                sqlCommand = new SqlCommand("Kitap_Update", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                {
                    sqlCommand.Connection.Open();
                }
                sqlCommand.Parameters.AddWithValue("adS", eKullanici.adS);
                sqlCommand.Parameters.AddWithValue("email", eKullanici.email);
                sqlCommand.Parameters.AddWithValue("telefon", eKullanici.telefon);
                
                degistirilen = sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Güncelleme başarılı");
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

        public static EKullanici BirKullanici(int Id)
        {
            EKullanici kullanici = null;
            SqlCommand sqlCommand = null;
            try
            {
                sqlCommand = new SqlCommand("Kullanici_Getir", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                {
                    sqlCommand.Connection.Open();
                }
                sqlCommand.Parameters.AddWithValue("ID", Id);
                SqlDataReader rdr = sqlCommand.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        kullanici = new EKullanici();
                        kullanici.adS = rdr["adS"].ToString();
                        kullanici.email = rdr["email"].ToString();
                        kullanici.telefon = rdr["telefon"].ToString();
                        
                    }
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                kullanici = null;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return kullanici;
        }

        public static List<EKullanici> ButunKullanicilar()
        {
            List<EKullanici> kullanici = null;
            SqlCommand sqlCommand = null;
            try
            {
                sqlCommand = new SqlCommand("Kullanici_Listesi", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                {
                    sqlCommand.Connection.Open();
                }
                SqlDataReader rdr = sqlCommand.ExecuteReader();
                if (rdr.HasRows)
                {
                    kullanici = new List<EKullanici>();
                    while (rdr.Read())
                    {
                        EKullanici kul = new EKullanici();
                        kul.kullaniciId = Convert.ToInt32(rdr["kullaniciId"]);
                        kul.adS = rdr["adS"].ToString();
                        kul.email = rdr["email"].ToString();
                        kul.telefon = rdr["telefon"].ToString();
                       
                        kullanici.Add(kul);
                    }
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                kullanici = null;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return kullanici;
        }

        public static List<EKullanici> FirmaGorevlileri()
        {
            List<EKullanici> fGorevlileri = null;
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
                    fGorevlileri = new List<EKullanici>();
                    while (rdr.Read())
                    {
                        EKullanici kul = new EKullanici();
                        kul.kullaniciId = Convert.ToInt32(rdr["kullaniciId"]);
                        kul.adS = rdr["adS"].ToString();
                        kul.email = rdr["email"].ToString();
                        kul.telefon = rdr["telefon"].ToString();

                        fGorevlileri.Add(kul);
                        
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
