using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcuzBiletProje.ENTITY
{
    class ESeyahatYerleri
    {
        private int _yerId;
        private string _yerAdi;

        public int yerId
        {
            get
            {
                return this._yerId;
            }
            set
            {
                this._yerId = value;
            }
        }

        public string yerAdi
        {
            get
            {
                return this._yerAdi;
            }
            set
            {
                this._yerAdi = value;
            }
        }
    }
}
