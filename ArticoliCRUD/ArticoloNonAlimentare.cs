using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticoliCRUD
{
    internal class ArticoloNonAlimentare : Articolo
    {
        //attributi
        private string _materiale;
        private bool _riciclabile;

        //properties
        public string Materiale { get { return _materiale; } set { _materiale = value; } }
        public bool Riciclable { get { return _riciclabile; } set { _riciclabile = value; } }

        //costruttore senza parametri
        public ArticoloNonAlimentare() : base()
        {
            Materiale = string.Empty;
            Riciclable = false;
        }

        //costruttore con parametri
        public ArticoloNonAlimentare(int cd, string desc, double pu, string mat, bool r) : base(cd, desc, pu)
        {
            Materiale = mat;
            Riciclable = r;
        }

        //costruttore di copia
        public ArticoloNonAlimentare(ArticoloNonAlimentare ap) : base(ap)
        {
            Materiale = ap.Materiale;
            Riciclable = ap.Riciclable;
        }




    }
}
