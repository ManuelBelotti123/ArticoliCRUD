﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ArticoliCRUD
{
    internal class ArticoloAlimentare : Articolo
    {
        //attributi
        protected DateTime _datascadenza;

        //properties
        public DateTime DataScadenza { get { return _datascadenza; } set { _datascadenza = value; } }
        
        //costruttore senza parametri
        public ArticoloAlimentare() : base()
        {
            DataScadenza = DateTime.MinValue;
        }

        //costruttore con parametri
        public ArticoloAlimentare(int cd, string desc, double pu, DateTime data) : base(cd, desc, pu)
        {
            DataScadenza = data;
        }

        //costruttore di copia
        public ArticoloAlimentare(ArticoloAlimentare ap) : base(ap)
        {
            DataScadenza = ap.DataScadenza;
        }

        //metodo Clone
        public ArticoloAlimentare Clone()
        {
            return (ArticoloAlimentare)this.MemberwiseClone();
        }

        //metodo Equals
        public override bool Equals(object obj)
        {
            return Equals(obj as ArticoloAlimentare);
        }

        public bool Equals(ArticoloAlimentare art)
        {
            return art != null && Codice == art.Codice && Descrizione == art.Descrizione && PrezzoUnitario == art.PrezzoUnitario && DataScadenza == art.DataScadenza;
        }

        //metodo GetHashCode
        public override int GetHashCode()
        {
            return (Codice, Descrizione, PrezzoUnitario, DataScadenza).GetHashCode();
        }

        //metodo ToString
        public override string ToString()
        {
            return Codice.ToString() + "; " + Descrizione.ToString() + "; " + PrezzoUnitario.ToString() + "; " + DataScadenza.ToString();
        }
    }
}