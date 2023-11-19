using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticoliCRUD
{
    internal class Articolo : IEquatable<Articolo>
    {
        //attributi
        protected int _codice;
        protected string _descrizione;
        protected double _prezzounitario;

        //properties
        public int Codice { get { return _codice; } set { _codice = value; } }
        public string Descrizione { get { return _descrizione; } set { _descrizione = value; } }
        public double PrezzoUnitario { get { return _prezzounitario; } set { _prezzounitario = value; } }

        //costruttore senza parametri
        public Articolo()
        {
            Codice = 0;
            Descrizione = string.Empty;
            PrezzoUnitario = 0;
        }

        //costruttore con parametri
        public Articolo(int cd, string desc, double pu)
        {
            Codice = cd;
            Descrizione = desc;
            PrezzoUnitario = pu;
        }

        //costruttore di copia
        public Articolo(Articolo ap)
        {
            Codice = ap.Codice;
            Descrizione = ap.Descrizione;
            PrezzoUnitario = ap.PrezzoUnitario;
        }

        //metodo Clone
        public Articolo Clone()
        {
            return (Articolo)this.MemberwiseClone();
        }

        //metodo Equals
        public override bool Equals(object obj)
        {
            return Equals(obj as Articolo);
        }

        public bool Equals(Articolo art)
        {
            return art != null && Codice == art.Codice && Descrizione == art.Descrizione && PrezzoUnitario == art.PrezzoUnitario;
        }

        //metodo GetHashCode
        public override int GetHashCode()
        {
            return (Codice, Descrizione, PrezzoUnitario).GetHashCode();
        }

        //metodo ToString
        public override string ToString()
        {
            return Codice.ToString() + "; " + Descrizione.ToString() + "; " + PrezzoUnitario.ToString();
        }

        //metodo sconta
        public virtual double Sconta()
        {
            return PrezzoUnitario - (PrezzoUnitario * 5) / 100;
        }

    }
}
