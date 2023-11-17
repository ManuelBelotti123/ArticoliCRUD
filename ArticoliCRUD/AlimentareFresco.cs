using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticoliCRUD
{
    internal class AlimentareFresco : ArticoloAlimentare
    {
        //attributi
        private int _numgiorni;

        //properties
        public int NumGiorni { get { return _numgiorni;} set { _numgiorni = value; } }

        //costruttore senza parametri
        public AlimentareFresco() : base()
        {
            NumGiorni = 0;
        }

        //costruttore con parametri
        public AlimentareFresco(int cd, string desc, double pu, DateTime data, int nmg) : base(cd, desc, pu, data)
        {
            NumGiorni = nmg;
        }

        //costruttore di copia
        public AlimentareFresco(AlimentareFresco ap) : base(ap)
        {
            NumGiorni = ap.NumGiorni;
        }
    }
}
