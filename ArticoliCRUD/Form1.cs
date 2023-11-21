﻿using System;
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
                arr[i] = new ArticoloAlimentare(int.Parse(codiceText.Text), descrizioneText.Text, double.Parse(prunText.Text), dateTimePicker1.Value);
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
                listBox1.Items.Add(arr[i].ToString());
                i++;
            }
        }

        private void inviaNAlim_Click(object sender, EventArgs e)
        {
            int i = 0;
            DialogResult rs = MessageBox.Show("Vuole completare l'operazione?", "Informazione", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                arr[i] = new ArticoloNonAlimentare(int.Parse(codiceNAlim.Text), descNAlim.Text, double.Parse(prunNAlim.Text), materialeNAlim.Text, radioButton1.Checked);
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
                listBox1.Items.Add(arr[i].ToString());
                i++;
            }
        }

        private void inviaAF_Click(object sender, EventArgs e)
        {
            int i = 0;
            DialogResult rs = MessageBox.Show("Vuole completare l'operazione?", "Informazione", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                arr[i] = new AlimentareFresco(int.Parse(codiceAF.Text), descAF.Text, double.Parse(prunAF.Text), dateTimePicker2.Value, int.Parse(numgAF.Text));
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
                listBox1.Items.Add(arr[i].ToString());
                i++;
            }
        }

        private void codiceText_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
