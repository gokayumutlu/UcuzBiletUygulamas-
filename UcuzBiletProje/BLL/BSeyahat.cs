using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcuzBiletProje.ENTITY;
using UcuzBiletProje.FACADE;
namespace UcuzBiletProje.BLL
{
    class BSeyahat
    {

        public static List<ESeyahat> ASizSeyahatler()
        {
            return FSeyahat.ASizSeyahatler();
        }

        public static int Insert(ESeyahat eSeyahat)
        {
            if (eSeyahat.firmaAdi!=null && eSeyahat.firmaId>0 && eSeyahat.nereden!=null && eSeyahat.nereye!=null && eSeyahat.sure>0 && eSeyahat.ucret>0 && eSeyahat.tarih!=null && eSeyahat.aktarmali!=null)
            {
                return FSeyahat.seyahatEkle(eSeyahat);
            }
            return -1;
        }

        public static List<ESeyahat> ButunSeyahatler()
        {
            return FSeyahat.ButunSeyahatler();
        }

        public static List<ESeyahat> SeyahatNeredenNereye(string nereden, string nereye)
        {
            return FSeyahat.SeyahatNeredenNereye(nereden,nereye);
        }

        public static List<ESeyahat> FSeyahatler(int firmaId)
        {
            return FSeyahat.FSeyahatler(firmaId);
        }

    }
}
