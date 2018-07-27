using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcuzBiletProje.ENTITY
{
    class ESeyahat
    {
        private int _sId;
        private int _firmaId;
        private string _firmaAdi;
        private int _sure;
        private DateTime _tarih;
        private int _ucret;
        private string _nereden;
        private string _nereye;
        private int _aktarmali;

        public int sId { get => _sId; set => _sId = value; }
        public int firmaId { get => _firmaId; set => _firmaId = value; }
        public string firmaAdi { get => _firmaAdi; set => _firmaAdi = value; }
        public int sure { get => _sure; set => _sure = value; }
        public DateTime tarih { get => _tarih; set => _tarih = value; }
        public int ucret { get => _ucret; set => _ucret = value; }
        public string nereden { get => _nereden; set => _nereden = value; }
        public string nereye { get => _nereye; set => _nereye = value; }
        public int aktarmali { get => _aktarmali; set => _aktarmali = value; }
        
    }
}
