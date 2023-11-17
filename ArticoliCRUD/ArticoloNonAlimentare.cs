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

        //metodo Clone
        public ArticoloNonAlimentare Clone()
        {
            return (ArticoloNonAlimentare)this.MemberwiseClone();
        }

        //metodo Equals
        public override bool Equals(object obj)
        {
            return Equals(obj as ArticoloNonAlimentare);
        }

        public bool Equals(ArticoloNonAlimentare art)
        {
            return art != null && Codice == art.Codice && Descrizione == art.Descrizione && PrezzoUnitario == art.PrezzoUnitario && Materiale == art.Materiale && Riciclable == art.Riciclable;
        }

        //metodo GetHashCode
        public override int GetHashCode()
        {
            return (Codice, Descrizione, PrezzoUnitario, Materiale, Riciclable).GetHashCode();
        }

        //metodo ToString
        public override string ToString()
        {
            return Codice.ToString() + "; " + Descrizione.ToString() + "; " + PrezzoUnitario.ToString() + "; " + Materiale.ToString() + "; " + Riciclable.ToString();
        }

        //metodo sconta
        public override double Sconta(bool cartafd)
        {
            if (cartafd)
            {
                if (Riciclable)
                {
                    return PrezzoUnitario - (PrezzoUnitario * 10) / 100;
                }
                else
                {
                    PrezzoUnitario = PrezzoUnitario - (PrezzoUnitario * 5) / 100;
                }
            }
            return -1;
        }
    }
}
