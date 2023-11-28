using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticoliCRUD
{
    public partial class Form1 : Form
    {
        //dichiarazione array
        Articolo[] arr;
        int i;
        public Form1()
        {
            InitializeComponent();
            arr = new Articolo[10000];
            i = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inviaAlim_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Vuole completare l'operazione?", "Informazione", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                arr[i] = new ArticoloAlimentare(int.Parse(codiceText.Text), descrizioneText.Text, double.Parse(prezzounitText.Text), dateTimePicker1.Value);
                DialogResult r = MessageBox.Show("Possiede una carta fedeltà?", "Informazione", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    if (dateTimePicker1.Value.Year == DateTime.Today.Year)
                    {
                        MessageBox.Show("Sconti fedeltà e ordinario applicati correttamente.", "Avviso");
                    }
                    else
                    {
                        MessageBox.Show("Sconto fedeltà applicato correttamente.", "Avviso");
                    }
                    arr[i].PrezzoUnitario = arr[i].Sconta(true);
                }
                else
                {
                    if (dateTimePicker1.Value.Year == DateTime.Today.Year)
                    {
                        MessageBox.Show("Sconto aggiuntivo ordinario applicato correttamente.", "Avviso");
                    }
                    else
                    {
                        MessageBox.Show("Nessuno sconto applicato.", "Avviso");
                    }
                    arr[i].PrezzoUnitario = arr[i].Sconta(false);
                }
                ListViewItem Item = new ListViewItem();
                Item.Text = arr[i].Codice.ToString();
                Item.SubItems.Add(arr[i].Descrizione);
                Item.SubItems.Add("€" + arr[i].PrezzoUnitario.ToString());
                Item.SubItems.Add(((ArticoloAlimentare)arr[i]).DataScadenza.ToShortDateString());
                Item.SubItems.Add("--");
                Item.SubItems.Add("--");
                Item.SubItems.Add("--");
                listView1.Items.Add(Item);
                i++;
            }
        }

        private void inviaNAlim_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Vuole completare l'operazione?", "Informazione", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                arr[i] = new ArticoloNonAlimentare(int.Parse(codiceNAlim.Text), descNAlim.Text, double.Parse(prezzounitNAlim.Text), materialeNAlim.Text, radioButton1.Checked);
                DialogResult r = MessageBox.Show("Possiede una carta fedeltà?", "Informazione", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    if (radioButton1.Checked)
                    {
                        MessageBox.Show("Sconti fedeltà e ordinario applicati correttamente.", "Avviso");
                    }
                    else
                    {
                        MessageBox.Show("Sconto fedeltà applicato correttamente.", "Avviso");
                    }
                    arr[i].PrezzoUnitario = arr[i].Sconta(true);
                }
                else
                {
                    if (radioButton1.Checked)
                    {
                        MessageBox.Show("Sconto aggiuntivo ordinario applicato correttamente.", "Avviso");
                    }
                    else
                    {
                        MessageBox.Show("Nessuno sconto applicato.", "Avviso");
                    }
                    arr[i].PrezzoUnitario = arr[i].Sconta(false);
                }
                ListViewItem Item = new ListViewItem();
                Item.Text = arr[i].Codice.ToString();
                Item.SubItems.Add(arr[i].Descrizione);
                Item.SubItems.Add("€" + arr[i].PrezzoUnitario.ToString());
                Item.SubItems.Add("--");
                Item.SubItems.Add(((ArticoloNonAlimentare)arr[i]).Materiale.ToString());
                Item.SubItems.Add(((ArticoloNonAlimentare)arr[i]).Riciclable.ToString());
                Item.SubItems.Add("--");
                listView1.Items.Add(Item);
                i++;
            }
        }

        private void inviaAF_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Vuole completare l'operazione?", "Informazione", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                arr[i] = new AlimentareFresco(int.Parse(codiceAF.Text), descAF.Text, double.Parse(prezzounitAF.Text), dateTimePicker2.Value.Date, int.Parse(numgAF.Text));
                DialogResult r = MessageBox.Show("Possiede una carta fedeltà?", "Informazione", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    MessageBox.Show("Sconti fedeltà e ordinario applicato correttamente.", "Avviso");
                    arr[i].PrezzoUnitario = arr[i].Sconta(true);
                }
                else
                {
                    MessageBox.Show("Sconto aggiuntivo ordinario applicato correttamente.", "Avviso");
                    arr[i].PrezzoUnitario = arr[i].Sconta(false);
                }
                ListViewItem Item = new ListViewItem();
                Item.Text = arr[i].Codice.ToString();
                Item.SubItems.Add(arr[i].Descrizione);
                Item.SubItems.Add("€" + arr[i].PrezzoUnitario.ToString());
                Item.SubItems.Add(((AlimentareFresco)arr[i]).DataScadenza.ToShortDateString());
                Item.SubItems.Add("--");
                Item.SubItems.Add("--");
                Item.SubItems.Add(((AlimentareFresco)arr[i]).NumGiorni.ToString());
                listView1.Items.Add(Item);
                i++;
            }
        }

        private void cancella_Click(object sender, EventArgs e)
        {
            int j = 0;
            List<Articolo> arrl = arr.ToList();
            while (arrl[j] != null)
            {
                if (arrl[j].Codice == int.Parse(cancellab.Text))
                {
                    arrl.RemoveAt(j);
                    arrl.Add(null);
                }
                j++;
            }
            arr = arrl.ToArray();
            Visualizza();
        }

        private void modifica_Click(object sender, EventArgs e)
        {
            int j = 0;
            List<Articolo> arrl = arr.ToList();
            while (arrl[j] != null)
            {
                if (arrl[j].Codice == int.Parse(colonnab.Text))
                {
                    switch (int.Parse(damodb.Text))
                    {
                        case 1:
                            arrl[j].Codice = int.Parse(modb.Text);
                            Visualizza();
                            break;
                        case 2:
                            arrl[j].Descrizione = modb.Text;
                            Visualizza();
                            break;
                        case 3:
                            arrl[j].PrezzoUnitario = double.Parse(modb.Text);
                            Visualizza();
                            break;
                        case 4:
                            if (arrl[j] is ArticoloAlimentare)
                            {
                                ((ArticoloAlimentare)arrl[j]).DataScadenza = DateTime.Parse(modb.Text);
                                Visualizza();
                            }
                            else if (arrl[j] is AlimentareFresco)
                            {
                                ((AlimentareFresco)arrl[j]).DataScadenza = DateTime.Parse(modb.Text);
                                Visualizza();
                            }
                            else
                            {
                                MessageBox.Show("Operazione impossibile per il tipo di prodotto scelto.", "Attenzione");
                            }
                            break;
                        case 5:
                            if (arrl[j] is ArticoloNonAlimentare)
                            {
                                ((ArticoloNonAlimentare)arrl[j]).Materiale = modb.Text;
                                Visualizza();
                            }
                            else
                            {
                                MessageBox.Show("Operazione impossibile per il tipo di prodotto scelto.", "Attenzione");
                            }
                            break;
                        case 6:
                            if (arrl[j] is ArticoloNonAlimentare)
                            {
                                ((ArticoloNonAlimentare)arrl[j]).Riciclable = bool.Parse(modb.Text);
                                Visualizza();
                            }
                            else
                            {
                                MessageBox.Show("Operazione impossibile per il tipo di prodotto scelto.", "Attenzione"); Visualizza();
                            }
                            break;
                        case 7:
                            if (arrl[j] is AlimentareFresco)
                            {
                                ((AlimentareFresco)arrl[j]).NumGiorni = int.Parse(modb.Text);
                                Visualizza();
                            }
                            else
                            {
                                MessageBox.Show("Operazione impossibile per il tipo di prodotto scelto.", "Attenzione");
                            }
                            break;
                    }
                }
                j++;
            }
            arr = arrl.ToArray();
        }

        //funzione visualizzazione array su listview
        public void Visualizza()
        {
            listView1.Items.Clear();
            int i = 0;
            while (arr[i] != null)
            {
                ListViewItem Item = new ListViewItem();
                if (arr[i] is ArticoloAlimentare)
                {
                    Item.Text = arr[i].Codice.ToString();
                    Item.SubItems.Add(arr[i].Descrizione);
                    Item.SubItems.Add("€" + arr[i].PrezzoUnitario.ToString());
                    Item.SubItems.Add(((ArticoloAlimentare)arr[i]).DataScadenza.ToShortDateString());
                    Item.SubItems.Add("--");
                    Item.SubItems.Add("--");
                    Item.SubItems.Add("--");
                    //listView1.Items.Add(Item);
                }
                else if (arr[i] is ArticoloNonAlimentare)
                {
                    Item.Text = arr[i].Codice.ToString();
                    Item.SubItems.Add(arr[i].Descrizione);
                    Item.SubItems.Add("€" + arr[i].PrezzoUnitario.ToString());
                    Item.SubItems.Add("--");
                    Item.SubItems.Add(((ArticoloNonAlimentare)arr[i]).Materiale.ToString());
                    Item.SubItems.Add(((ArticoloNonAlimentare)arr[i]).Riciclable.ToString());
                    Item.SubItems.Add("--");
                    //listView1.Items.Add(Item);
                }
                else if (arr[i] is AlimentareFresco)
                {
                    Item.Text = arr[i].Codice.ToString();
                    Item.SubItems.Add(arr[i].Descrizione);
                    Item.SubItems.Add("€" + arr[i].PrezzoUnitario.ToString());
                    Item.SubItems.Add(((AlimentareFresco)arr[i]).DataScadenza.ToString());
                    Item.SubItems.Add("--");
                    Item.SubItems.Add("--");
                    Item.SubItems.Add(((AlimentareFresco)arr[i]).NumGiorni.ToString());
                    //listView1.Items.Add(Item);
                }
                listView1.Items.Add(Item);
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                        arr[j] = new ArticoloAlimentare(int.Parse(div[0]), div[1], double.Parse(div[2]), DateTime.Parse(div[3]));
                    }
                    else if (div.Length == 5)
                    {
                        if (div[4] == "True" || div[4] == "False")
                        {
                            arr[j] = new ArticoloNonAlimentare(int.Parse(div[0]), div[1], double.Parse(div[2]), div[3], bool.Parse(div[4]));
                        }
                        else
                        {
                            arr[j] = new AlimentareFresco(int.Parse(div[0]), div[1], double.Parse(div[2]), DateTime.Parse(div[3]), int.Parse(div[4]));
                        }
                    }
                    j++;
                }
                sr.Close();
            }
            Visualizza();
            MessageBox.Show("File caricato correttamente.", "Avviso");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Vuole sovrascrivere (si) o aggiungere dei record (no) al file di salvataggio?", "Avviso", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                StreamWriter sw = File.CreateText("file.csv");
                int i = 0;
                while (arr[i] != null)
                {
                    sw.WriteLine(arr[i].ToString());
                    i++;
                }
                sw.Close();
                MessageBox.Show("File sovrascritto correttamente.", "Avviso");
            }
            else if (r == DialogResult.No)
            {
                StreamWriter sw = File.AppendText("file.csv");
                int i = 0;
                while (arr[i] != null)
                {
                    sw.WriteLine(arr[i].ToString());
                    i++;
                }
                sw.Close();
                MessageBox.Show("Record salvati correttamente.", "Avviso");
            }
        }

        private void ordina_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            Articolo temp = null;
            while (arr[i] != null)
            {
                while (arr[j + 1] != null)
                {
                    if (arr[j + 1].Compare(arr[j]) == 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp; 
                    }
                    j++;
                }
                j = 0;
                i++;
            }
            Visualizza();
        }
    }
}
