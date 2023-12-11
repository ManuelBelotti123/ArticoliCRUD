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
        Scontrino scr;
        public Form1()
        {
            InitializeComponent();
            scr = new Scontrino(10000);
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
                scr.Aggiunta(new ArticoloAlimentare(int.Parse(codiceText.Text), descrizioneText.Text, double.Parse(prezzounitText.Text), dateTimePicker1.Value));
                ListViewItem Item = new ListViewItem();
                Item.Text = scr.Scontr[scr.ElementiOccupati - 1].Codice.ToString();
                Item.SubItems.Add(scr.Scontr[scr.ElementiOccupati - 1].Descrizione);
                Item.SubItems.Add("€" + scr.Scontr[scr.ElementiOccupati - 1].PrezzoUnitario.ToString());
                Item.SubItems.Add(((ArticoloAlimentare)scr.Scontr[scr.ElementiOccupati - 1]).DataScadenza.ToShortDateString());
                Item.SubItems.Add("--");
                Item.SubItems.Add("--");
                Item.SubItems.Add("--");
                listView1.Items.Add(Item);
            }
        }

        private void inviaNAlim_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Vuole completare l'operazione?", "Informazione", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                scr.Aggiunta(new ArticoloNonAlimentare(int.Parse(codiceNAlim.Text), descNAlim.Text, double.Parse(prezzounitNAlim.Text), materialeNAlim.Text, radioButton1.Checked));
                ListViewItem Item = new ListViewItem();
                Item.Text = scr.Scontr[scr.ElementiOccupati - 1].Codice.ToString();
                Item.SubItems.Add(scr.Scontr[scr.ElementiOccupati - 1].Descrizione);
                Item.SubItems.Add("€" + scr.Scontr[scr.ElementiOccupati - 1].PrezzoUnitario.ToString());
                Item.SubItems.Add("--");
                Item.SubItems.Add(((ArticoloNonAlimentare)scr.Scontr[scr.ElementiOccupati - 1]).Materiale.ToString());
                Item.SubItems.Add(((ArticoloNonAlimentare)scr.Scontr[scr.ElementiOccupati - 1]).Riciclable.ToString());
                Item.SubItems.Add("--");
                listView1.Items.Add(Item);
            }
        }

        private void inviaAF_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Vuole completare l'operazione?", "Informazione", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                scr.Aggiunta(new AlimentareFresco(int.Parse(codiceAF.Text), descAF.Text, double.Parse(prezzounitAF.Text), dateTimePicker2.Value.Date, int.Parse(numgAF.Text)));
                ListViewItem Item = new ListViewItem();
                Item.Text = scr.Scontr[scr.ElementiOccupati - 1].Codice.ToString();
                Item.SubItems.Add(scr.Scontr[scr.ElementiOccupati - 1].Descrizione);
                Item.SubItems.Add("€" + scr.Scontr[scr.ElementiOccupati - 1].PrezzoUnitario.ToString());
                Item.SubItems.Add(((AlimentareFresco)scr.Scontr[scr.ElementiOccupati - 1]).DataScadenza.ToShortDateString());
                Item.SubItems.Add("--");
                Item.SubItems.Add("--");
                Item.SubItems.Add(((AlimentareFresco)scr.Scontr[scr.ElementiOccupati - 1]).NumGiorni.ToString());
                listView1.Items.Add(Item);
            }
        }

        private void cancella_Click(object sender, EventArgs e)
        {
            scr.Cancella(int.Parse(cancellab.Text));
            Visualizza();
        }

        private void modifica_Click(object sender, EventArgs e)
        {
            scr.Modifica(int.Parse(colonnab.Text), int.Parse(damodb.Text), modb.Text);
            Visualizza();
        }

        //funzione visualizzazione array su listview
        public void Visualizza()
        {
            listView1.Items.Clear();
            for (int i = 0; i < scr.ElementiOccupati; i++)
            {
                ListViewItem Item = new ListViewItem();
                if (scr.Scontr[i] is ArticoloAlimentare)
                {
                    Item.Text = scr.Scontr[i].Codice.ToString();
                    Item.SubItems.Add(scr.Scontr[i].Descrizione);
                    Item.SubItems.Add("€" + scr.Scontr[i].PrezzoUnitario.ToString());
                    Item.SubItems.Add(((ArticoloAlimentare)scr.Scontr[i]).DataScadenza.ToShortDateString());
                    Item.SubItems.Add("--");
                    Item.SubItems.Add("--");
                    Item.SubItems.Add("--");
                    //listView1.Items.Add(Item);
                }
                else if (scr.Scontr[i] is ArticoloNonAlimentare)
                {
                    Item.Text = scr.Scontr[i].Codice.ToString();
                    Item.SubItems.Add(scr.Scontr[i].Descrizione);
                    Item.SubItems.Add("€" + scr.Scontr[i].PrezzoUnitario.ToString());
                    Item.SubItems.Add("--");
                    Item.SubItems.Add(((ArticoloNonAlimentare)scr.Scontr[i]).Materiale.ToString());
                    Item.SubItems.Add(((ArticoloNonAlimentare)scr.Scontr[i]).Riciclable.ToString());
                    Item.SubItems.Add("--");
                    //listView1.Items.Add(Item);
                }
                else if (scr.Scontr[i] is AlimentareFresco)
                {
                    Item.Text = scr.Scontr[i].Codice.ToString();
                    Item.SubItems.Add(scr.Scontr[i].Descrizione);
                    Item.SubItems.Add("€" + scr.Scontr[i].PrezzoUnitario.ToString());
                    Item.SubItems.Add(((AlimentareFresco)scr.Scontr[i]).DataScadenza.ToString());
                    Item.SubItems.Add("--");
                    Item.SubItems.Add("--");
                    Item.SubItems.Add(((AlimentareFresco)scr.Scontr[i]).NumGiorni.ToString());
                    //listView1.Items.Add(Item);
                }
                listView1.Items.Add(Item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scr.CaricaFile();
            Visualizza();
            MessageBox.Show("File caricato correttamente.", "Avviso");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Vuole sovrascrivere (si) o aggiungere dei record (no) al file di salvataggio?", "Avviso", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                scr.ScaricaFile(true);
                MessageBox.Show("File sovrascritto correttamente.", "Avviso");
            }
            else if (r == DialogResult.No)
            {
                scr.ScaricaFile(false);
                MessageBox.Show("Record salvati correttamente.", "Avviso");
            }
        }

        private void ordina_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Ordine crescente (si) o decrescente (no)?", "Avviso", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                scr.Ordina(false);
            }
            else
            {
                scr.Ordina(true);
            }
            Visualizza();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            double tot = 0;
            DialogResult rs = MessageBox.Show("Possiede la carta fedeltà?", "Domanda", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                scr.Ordina(true);
            }
            else
            {
                scr.Ordina(false);
            }
            MessageBox.Show("L'importo totale è " + tot, "Risultato", MessageBoxButtons.OK);
        }
    }
}
