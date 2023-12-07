using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticoliCRUD
{
    internal class Scontrino
    {
        //attributi
        private Articolo[] _scontr;
        private int _elementioccupati;

        //properties
        public Articolo[] Scontr
        {
            get { return _scontr; }
            set { _scontr = value; }
        }
        public int ElementiOccupati
        {
            get { return _elementioccupati; }
            set { _elementioccupati = value; }
        }

        //costruttori
        public Scontrino()
        {
            Scontr = null;
        }
        public Scontrino(int dim)
        {
            Scontr = new Articolo[dim];
        }
        public Scontrino(Scontrino scr)
        {
            Scontr = scr.Scontr;
            ElementiOccupati = scr.ElementiOccupati;
        }

        //metodo Equals
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Scontrino))
            {
                return false;
            }
            else
            {
                Scontrino scr = (Scontrino)obj;
                return scr != null && Scontr == scr.Scontr && ElementiOccupati == scr.ElementiOccupati;
            }
        }

        //metodo ToString
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < ElementiOccupati; i++) 
            { 
                if (i == 0)
                {
                    str = str + Scontr[i];
                }
                else
                {
                    str = str + ";" + Scontr[i];
                }
            }
            return str;
        }

        //metodi
        public void Aggiunta(Articolo art)
        {
            Scontr[ElementiOccupati] = art;
            ElementiOccupati++;
        }

        public double Totale(bool c)
        {
            double tot = 0;
            for (int i = 0; i < ElementiOccupati; i++)
            {
                if (c)
                {
                    tot += Scontr[i].Sconta(true);
                }
                else
                {
                    tot += Scontr[i].Sconta(false);
                }
            }
            return tot;
        }

        public void Cancella(int cancc)
        {
            List<Articolo> arrl = Scontr.ToList();
            for (int i = 0; i < ElementiOccupati; i++)
            {
                if (arrl[i].Codice == cancc)
                {
                    arrl.RemoveAt(i);
                    arrl.Add(null);
                }
                i++;
            }
            Scontr = arrl.ToArray();
        }

    }
}
