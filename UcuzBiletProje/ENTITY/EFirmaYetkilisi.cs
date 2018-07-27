using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcuzBiletProje.ENTITY
{
    class EFirmaYetkilisi
    {
        private int _fYetkiliId;
        private string _adS;
        private string _email;
        private string _telefon;
        private string _firmaAdi;


        public int fyetkiliId
        {
            get
            {
                return this._fYetkiliId;
            }
            set
            {
                this._fYetkiliId = value;
            }
        }

        public string adS
        {
            get
            {
                return this._adS;
            }
            set
            {
                this._adS = value;
            }
        }

        

        public string email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }

        public string telefon
        {
            get
            {
                return this._telefon;
            }
            set
            {
                this._telefon = value;
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
