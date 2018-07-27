using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcuzBiletProje.ENTITY;
using UcuzBiletProje.FACADE;
namespace UcuzBiletProje.BLL
{
    class BFirmaYetkilisi
    {
        

        

        

        
        public static List<EFirmaYetkilisi> ButunKullanicilar()
        {
            return FFirmaYetkilisi.FirmaGorevlileri();
        }
    }
}
