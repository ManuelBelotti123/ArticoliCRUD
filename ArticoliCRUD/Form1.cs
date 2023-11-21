using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticoliCRUD
{
    public partial class Form1 : Form
    {
        //dichiarazione array
        Articolo[] arr = new Articolo[10000];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inviaAlim_Click(object sender, EventArgs e)
        {
            int i = 0;
            DialogResult rs = MessageBox.Show("Vuole completare l'operazione?", "Informazione", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                arr[i] = new ArticoloAlimentare(int.Parse(codiceText.Text), descrizioneText.Text, double.Parse(prezzounitText.Text), dateTimePicker1.Value);
                DialogResult r = MessageBox.Show("Possiede una carta fedeltà?", "Informazione", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    MessageBox.Show("Sconti fedeltà e ordinario applicato correttamente.", "Avviso");
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
            int i = 0;
            DialogResult rs = MessageBox.Show("Vuole completare l'operazione?", "Informazione", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                arr[i] = new ArticoloNonAlimentare(int.Parse(codiceNAlim.Text), descNAlim.Text, double.Parse(prezzounitNAlim.Text), materialeNAlim.Text, radioButton1.Checked);
                DialogResult r = MessageBox.Show("Possiede una carta fedeltà?", "Informazione", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    MessageBox.Show("Sconti fedeltà e ordinario applicato correttamente.", "Avviso");
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
            int i = 0;
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
                Item.SubItems.Add(((AlimentareFresco)arr[i]).DataScadenza.ToString());
                Item.SubItems.Add("--");
                Item.SubItems.Add("--");
                Item.SubItems.Add(((AlimentareFresco)arr[i]).NumGiorni.ToString());
                listView1.Items.Add(Item);
                i++;
            }
        }

        private void cancella_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Codice == int.Parse(cancellab.Text))
                {
                    while(arr[i + 1] == null) arr[i] = arr[i + 1];
                }
            }
        }

        //funzione visualizzazione array su listview
        public void Visualizza()
        {
            ListViewItem Item = new ListViewItem();
            int i = 0;
            while (arr[i] != null)
            {
                if (arr[i] is ArticoloAlimentare)
                {
                    Item.Text = arr[i].Codice.ToString();
                    Item.SubItems.Add(arr[i].Descrizione);
                    Item.SubItems.Add("€" + arr[i].PrezzoUnitario.ToString());
                    Item.SubItems.Add(((ArticoloAlimentare)arr[i]).DataScadenza.ToShortDateString());
                    Item.SubItems.Add("--");
                    Item.SubItems.Add("--");
                    Item.SubItems.Add("--");
                    listView1.Items.Add(Item);
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
                    listView1.Items.Add(Item);
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
                    listView1.Items.Add(Item);
                }
                i++;
            }
        }
    }
}
