using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace UcuzBiletProje.FACADE
{
    class Kontrol
    {
        static string firmaAdi;
        static int firmaId;
        public static Boolean MLogin(string email, string password)
        {
            SqlCommand command = null;
            SqlDataReader rdr=null;
            try
            {
                command = new SqlCommand("Password_C", Baglan.Con);
                command.CommandType = CommandType.StoredProcedure;
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }

                command.Parameters.AddWithValue("email", email);
                rdr = command.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        string password2 = rdr["password"].ToString();
                        if (password == password2)
                        {
                            return true;
                        }
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
                
            }
            finally
            {
                rdr.Close();
            }
            

            return false;
        }

        public static Boolean FLogin(string email, string password)
        {
            SqlCommand command = null;
            SqlDataReader rdr=null;
            try
            {
                command = new SqlCommand("FPassword_C", Baglan.Con);
                command.CommandType = CommandType.StoredProcedure;
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }

                command.Parameters.AddWithValue("email", email);
                rdr = command.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        string password2 = rdr["password"].ToString();
                        firmaAdi = rdr["firmaAdi"].ToString();
                        firmaId = Convert.ToInt32(rdr["firmaId"]);
                        if (password == password2)
                        {
                            return true;
                        }
                    }
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                rdr.Close();
            }
            return false;
        }

        public static Boolean ULogin(string email, string password)
        {
            SqlCommand command = null;
            SqlDataReader rdr = null;
            try
            {
                command = new SqlCommand("UPassword_C", Baglan.Con);
                command.CommandType = CommandType.StoredProcedure;
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }

                command.Parameters.AddWithValue("email", email);
                rdr = command.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        string password2 = rdr["password"].ToString();
                        if (password == password2)
                        {
                            return true;
                        }
                    }
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                rdr.Close();
            }

            return false;
        }

        public static string FirmaAdi()
        {
            return firmaAdi;
        }

        public static int FirmaId()
        {
            return firmaId;
        }

    }
}
