using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcuzBiletProje.ENTITY
{
    class EFirma
    {
        private int _firmaId;
        private string _firmaAdi;

        public int firmaId
        {
            get
            {
                return this._firmaId;
            }
            set
            {
                this._firmaId = value;
            }
        }

        public string firmaAdi
        {
            get
            {
                return this._firmaAdi;
            }
            set
            {
                this._firmaAdi = value;
            }
        }
    }
}
