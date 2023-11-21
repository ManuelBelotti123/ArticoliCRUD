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
            return base.ToString() + "; Materiale: " + Materiale.ToString() + "; Riciclabile: " + Riciclable.ToString();
        }

        //metodo sconta
        public override double Sconta(bool c)
        {
            double ps = PrezzoUnitario;
            if (c)
            {
                ps = ps - (ps * 5) / 100;
            }
            if (Riciclable)
            {
                ps = ps - (ps * 10) / 100;
            }
            return Math.Round(ps, 2);
        }
    }
}
