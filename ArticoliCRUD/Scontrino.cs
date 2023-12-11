using System;
using System.Collections.Generic;
using System.IO;
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
            ElementiOccupati = 0;
        }
        public Scontrino(int dim)
        {
            Scontr = new Articolo[dim];
            ElementiOccupati = 0;
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
        public void Aggiunta(ArticoloAlimentare art)
        {
            Scontr[ElementiOccupati] = new ArticoloAlimentare(art);
            ElementiOccupati++;
        }
        public void Aggiunta(ArticoloNonAlimentare art)
        {
            Scontr[ElementiOccupati] = new ArticoloNonAlimentare(art);
            ElementiOccupati++;
        }
        public void Aggiunta(AlimentareFresco art)
        {
            Scontr[ElementiOccupati] = new AlimentareFresco(art);
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
            }
            Scontr = arrl.ToArray();
        }

        public int Modifica(int cd, int cdamod, string mod)
        {
            List<Articolo> arrl = Scontr.ToList();
            for (int j = 0; j < ElementiOccupati; j++)
            {
                if (arrl[j].Codice == cd)
                {
                    switch (cdamod)
                    {
                        case 1:
                            arrl[j].Codice = int.Parse(mod);
                            break;
                        case 2:
                            arrl[j].Descrizione = mod;
                            break;
                        case 3:
                            arrl[j].PrezzoUnitario = double.Parse(mod);
                            break;
                        case 4:
                            if (arrl[j] is ArticoloAlimentare)
                            {
                                ((ArticoloAlimentare)arrl[j]).DataScadenza = DateTime.Parse(mod);
                            }
                            else if (arrl[j] is AlimentareFresco)
                            {
                                ((AlimentareFresco)arrl[j]).DataScadenza = DateTime.Parse(mod);
                            }
                            else
                            {
                                return -1;
                            }
                            break;
                        case 5:
                            if (arrl[j] is ArticoloNonAlimentare)
                            {
                                ((ArticoloNonAlimentare)arrl[j]).Materiale = mod;
                            }
                            else
                            {
                                return -1;
                            }
                            break;
                        case 6:
                            if (arrl[j] is ArticoloNonAlimentare)
                            {
                                ((ArticoloNonAlimentare)arrl[j]).Riciclable = bool.Parse(mod);
                            }
                            else
                            {
                                return -1;
                            }
                            break;
                        case 7:
                            if (arrl[j] is AlimentareFresco)
                            {
                                ((AlimentareFresco)arrl[j]).NumGiorni = int.Parse(mod);
                            }
                            else
                            {
                                return -1;
                            }
                            break;
                    }
                }
            }
            Scontr = arrl.ToArray();
            return 0;
        }

        public void Ordina(bool c)
        {
            Articolo temp = null;
            for (int i = 0; i < ElementiOccupati; i++)
            {
                for (int j = 0; j < ElementiOccupati; j++)
                {
                    if (c)
                    {
                        if (Scontr[j + 1].Compare(Scontr[j]) == 0)
                        {
                            temp = Scontr[j];
                            Scontr[j] = Scontr[j + 1];
                            Scontr[j + 1] = temp;
                        }
                    }
                    else
                    {
                        if (Scontr[j + 1].Compare(Scontr[j]) == 1)
                        {
                            temp = Scontr[j];
                            Scontr[j] = Scontr[j + 1];
                            Scontr[j + 1] = temp;
                        }
                    }
                }
            }
        }

        public void CaricaFile()
        {
            if (!File.Exists("file.csv"))
            {
                File.Create("file.csv");
            }
            using (StreamReader sr = File.OpenText("file.csv"))
            {
                string line;
                int j = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] div = line.Split(';');
                    if (div.Length == 4)
                    {
                        Scontr[j] = new ArticoloAlimentare(int.Parse(div[0]), div[1], double.Parse(div[2]), DateTime.Parse(div[3]));
                    }
                    else if (div.Length == 5)
                    {
                        if (div[4] == "True" || div[4] == "False")
                        {
                            Scontr[j] = new ArticoloNonAlimentare(int.Parse(div[0]), div[1], double.Parse(div[2]), div[3], bool.Parse(div[4]));
                        }
                        else
                        {
                            Scontr[j] = new AlimentareFresco(int.Parse(div[0]), div[1], double.Parse(div[2]), DateTime.Parse(div[3]), int.Parse(div[4]));
                        }
                    }
                    j++;
                }
                sr.Close();
            }
        }

        public void ScaricaFile(bool c)
        {
            if (c)
            {
                StreamWriter sw = File.CreateText("file.csv");
                int i = 0;
                while (Scontr[i] != null)
                {
                    sw.WriteLine(Scontr[i].ToString());
                    i++;
                }
                sw.Close();
            }
            else
            {
                StreamWriter sw = File.AppendText("file.csv");
                int i = 0;
                while (Scontr[i] != null)
                {
                    sw.WriteLine(Scontr[i].ToString());
                    i++;
                }
                sw.Close();
            }
        }

    }
}
