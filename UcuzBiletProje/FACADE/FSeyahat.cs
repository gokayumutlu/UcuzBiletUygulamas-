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
    class FSeyahat
    {
        public static List<ESeyahat> ButunSeyahatler()
        {
            List<ESeyahat> seyahat = null;
            SqlCommand sqlCommand = null;
            try
            {
                sqlCommand = new SqlCommand("Seyahat_Listesi", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                {
                    sqlCommand.Connection.Open();
                }
                SqlDataReader rdr = sqlCommand.ExecuteReader();
                if (rdr.HasRows)
                {
                    seyahat = new List<ESeyahat>();
                    while (rdr.Read())
                    {
                        ESeyahat s = new ESeyahat();

                        s.sId = Convert.ToInt32(rdr["seyahatId"]);
                        s.firmaId = Convert.ToInt32(rdr["firmaId"]);
                        s.firmaAdi = rdr["firmaAdi"].ToString();
                        s.nereden = rdr["nereden"].ToString();
                        s.nereye = rdr["nereye"].ToString();
                        s.sure = Convert.ToInt32(rdr["sure"]);
                        s.ucret = Convert.ToInt32(rdr["ucret"]);
                        s.tarih = Convert.ToDateTime(rdr["tarih"]);
                        s.aktarmali = Convert.ToInt32(rdr["aktamali"]);

                        seyahat.Add(s);
                    }
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                seyahat = null;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return seyahat;
        }

        public static List<ESeyahat> ASizSeyahatler()
        {
            List<ESeyahat> seyahat = null;
            SqlCommand sqlCommand = null;
            SqlDataReader rdr = null;
            try
            {
                sqlCommand = new SqlCommand("Aktarmasiz_Seyahat_Listesi", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                {
                    sqlCommand.Connection.Open();
                }
                rdr = sqlCommand.ExecuteReader();
                if (rdr.HasRows)
                {
                    seyahat = new List<ESeyahat>();
                    while (rdr.Read())
                    {
                        ESeyahat s = new ESeyahat();

                        s.sId = Convert.ToInt32(rdr["seyahatId"]);
                        s.firmaId = Convert.ToInt32(rdr["firmaId"]);
                        s.firmaAdi = rdr["firmaAdi"].ToString();
                        s.nereden = rdr["nereden"].ToString();
                        s.nereye = rdr["nereye"].ToString();
                        s.sure = Convert.ToInt32(rdr["sure"]);
                        s.ucret = Convert.ToInt32(rdr["ucret"]);
                        s.tarih = Convert.ToDateTime(rdr["tarih"]);
                        s.aktarmali = Convert.ToInt32(rdr["aktamali"]);

                        seyahat.Add(s);
                    }
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                seyahat = null;
            }
            finally
            {
                sqlCommand.Connection.Close();
                rdr.Close();
            }

            return seyahat;
        }


        public static List<ESeyahat> SeyahatNeredenNereye(string nereden, string nereye)
        {
            List<ESeyahat> seyahat = null;
            SqlCommand sqlCommand = null;
            SqlDataReader rdr = null;
            try
            {
                sqlCommand = new SqlCommand("Seyahat_Nereden_Nereye", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                {
                    sqlCommand.Connection.Open();
                }
                sqlCommand.Parameters.AddWithValue("nereden",nereden);
                sqlCommand.Parameters.AddWithValue("nereye", nereye);
                rdr = sqlCommand.ExecuteReader();
                if (rdr.HasRows)
                {
                    seyahat = new List<ESeyahat>();
                    while (rdr.Read())
                    {
                        ESeyahat s = new ESeyahat();

                        s.sId = Convert.ToInt32(rdr["seyahatId"]);
                        s.firmaId = Convert.ToInt32(rdr["firmaId"]);
                        s.firmaAdi = rdr["firmaAdi"].ToString();
                        s.nereden = rdr["nereden"].ToString();
                        s.nereye = rdr["nereye"].ToString();
                        s.sure = Convert.ToInt32(rdr["sure"]);
                        s.ucret = Convert.ToInt32(rdr["ucret"]);
                        s.tarih = Convert.ToDateTime(rdr["tarih"]);
                        s.aktarmali = Convert.ToInt32(rdr["aktamali"]);

                        seyahat.Add(s);
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
                seyahat = null;
            }
            finally
            {
                sqlCommand.Connection.Close();
                rdr.Close();
            }

            return seyahat;
        }


        public static int seyahatEkle(ESeyahat eSeyahat)
        {
            SqlCommand sqlCommand = null;
            int eklenen = 0;
            try
            {
                sqlCommand = new SqlCommand("Seyahat_Ekle", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                {
                    sqlCommand.Connection.Open();
                }

                sqlCommand.Parameters.AddWithValue("firmaId", eSeyahat.firmaId);
                sqlCommand.Parameters.AddWithValue("firmaAdi", eSeyahat.firmaAdi);
                sqlCommand.Parameters.AddWithValue("nereden", eSeyahat.nereden);
                sqlCommand.Parameters.AddWithValue("nereye", eSeyahat.nereye);
                sqlCommand.Parameters.AddWithValue("sure", eSeyahat.sure);
                sqlCommand.Parameters.AddWithValue("ucret", eSeyahat.ucret);
                sqlCommand.Parameters.AddWithValue("tarih", eSeyahat.tarih);
                sqlCommand.Parameters.AddWithValue("aktamali", eSeyahat.aktarmali);
                eklenen = sqlCommand.ExecuteNonQuery();
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
            return eklenen;
        }


        public static List<ESeyahat> FSeyahatler(int firmaId)
        {
            List<ESeyahat> seyahat = null;
            SqlCommand sqlCommand = null;
            try
            {
                sqlCommand = new SqlCommand("FSeyahatleri", Baglan.Con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlCommand.Connection.State != ConnectionState.Open)
                {
                    sqlCommand.Connection.Open();
                }
                sqlCommand.Parameters.AddWithValue("firmaId", firmaId);
                SqlDataReader rdr = sqlCommand.ExecuteReader();
                if (rdr.HasRows)
                {
                    seyahat = new List<ESeyahat>();
                    while (rdr.Read())
                    {
                        ESeyahat s = new ESeyahat();

                        s.sId = Convert.ToInt32(rdr["seyahatId"]);
                        s.firmaId = Convert.ToInt32(rdr["firmaId"]);
                        s.firmaAdi = rdr["firmaAdi"].ToString();
                        s.nereden = rdr["nereden"].ToString();
                        s.nereye = rdr["nereye"].ToString();
                        s.sure = Convert.ToInt32(rdr["sure"]);
                        s.ucret = Convert.ToInt32(rdr["ucret"]);
                        s.tarih = Convert.ToDateTime(rdr["tarih"]);
                        s.aktarmali = Convert.ToInt32(rdr["aktamali"]);

                        seyahat.Add(s);
                    }
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                seyahat = null;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return seyahat;
        }
    }
}
