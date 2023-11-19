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
        public int NumGiorni 
        { 
            get { return _numgiorni;} 
            set 
            { 
                if (value <= 5 && value > 0) 
                {
                    _numgiorni = value;
                }
                else
                {
                    _numgiorni = 5;
                }
            } 
        }

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

        //metodo Clone
        public AlimentareFresco Clone()
        {
            return (AlimentareFresco)this.MemberwiseClone();
        }

        //metodo Equals
        public override bool Equals(object obj)
        {
            return Equals(obj as AlimentareFresco);
        }

        public bool Equals(AlimentareFresco art)
        {
            return art != null && Codice == art.Codice && Descrizione == art.Descrizione && PrezzoUnitario == art.PrezzoUnitario && DataScadenza == art.DataScadenza && NumGiorni == art.NumGiorni;
        }

        //metodo GetHashCode
        public override int GetHashCode()
        {
            return (Codice, Descrizione, PrezzoUnitario, DataScadenza, NumGiorni).GetHashCode();
        }

        //metodo ToString
        public override string ToString()
        {
            return Codice.ToString() + "; " + Descrizione.ToString() + "; " + PrezzoUnitario.ToString() + "; " + DataScadenza.ToString() + "; " + NumGiorni.ToString();
        }

    }
}
