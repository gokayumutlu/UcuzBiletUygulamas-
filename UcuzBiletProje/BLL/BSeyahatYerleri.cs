using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcuzBiletProje.ENTITY;
using UcuzBiletProje.FACADE;
namespace UcuzBiletProje.BLL
{
    class BSeyahatYerleri
    {
        public static List<ESeyahatYerleri> SeyahatYerleri()
        {
            return FSeyahatYerleri.SeyahatYerleri();
        }
    }
}
