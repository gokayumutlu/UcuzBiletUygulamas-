using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcuzBiletProje.ENTITY
{
    class EKullanici
    {
        private int _kullaniciId;
        private string _adS;
        private string _password;
        private string _email;
        private string _telefon;


        public int kullaniciId
        {
            get
            {
                return this._kullaniciId;
            }
            set
            {
                this._kullaniciId = value;
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

        public string password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
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

    }
}
