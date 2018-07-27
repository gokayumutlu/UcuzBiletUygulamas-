using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcuzBiletProje.ENTITY;
using UcuzBiletProje.FACADE;
namespace UcuzBiletProje.BLL
{
    class BFirma
    {
        public static int Insert(EFirma eFirma)
        {
            if (eFirma.firmaAdi.Trim().Length > 0)
            {
                return FFirma.Insert(eFirma);
            }
            return -1;
        }

        public static int Delete(int Id)
        {
            if (Id > 0)
                return FFirma.Delete(Id);
            else return -1;
        }

        public static int Update(EFirma eFirma)
        {

            if (eFirma.firmaAdi != null && eFirma.firmaAdi.Trim().Length > 0)
            {
                return FFirma.Update(eFirma);
            }
            return -1;
        }

        public static EFirma BirFirma(int Id)
        {
            if (Id > 0)
                return FFirma.BirFirma(Id);
            else return null;
        }
        public static List<EFirma> ButunFirmalar()
        {
            return FFirma.ButunFirmalar();
        }
    }
}
