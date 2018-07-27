using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcuzBiletProje.ENTITY;
using UcuzBiletProje.FACADE;
namespace UcuzBiletProje.BLL
{
    class BKullanici
    {
        public static int Insert(EKullanici eKullanici)
        {
            if(eKullanici.email !=null && eKullanici.email.Trim().Length > 0 && eKullanici.password!=null && eKullanici.password.Trim().Length>0)
            {
                return FKullanici.Insert(eKullanici);
            }
            return -1;
        }

        public static int Delete(int Id)
        {
            if (Id > 0)
                return FKullanici.Delete(Id);
            else return -1;
        }

        public static int Update(EKullanici eKullanici)
        {

            if (eKullanici.adS != null && eKullanici.email.Trim().Length > 0 && eKullanici.kullaniciId > 0)
            {
                return FKullanici.Update(eKullanici);
            }
            return -1;
        }

        public static EKullanici BirKullanici(int Id)
        {
            if (Id > 0)
                return FKullanici.BirKullanici(Id);
            else return null;
        }
        public static List<EKullanici> ButunKullanicilar()
        {
            return FKullanici.ButunKullanicilar();
        }

        public static List<EKullanici> FirmaGorevlileri()
        {
            return FKullanici.FirmaGorevlileri();
        }
    }
}
