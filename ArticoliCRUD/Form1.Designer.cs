namespace ArticoliCRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabAlim = new System.Windows.Forms.TabPage();
            this.prezzounitText = new System.Windows.Forms.MaskedTextBox();
            this.codiceText = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.inviaAlim = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.descrizioneText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabNAlim = new System.Windows.Forms.TabPage();
            this.prezzounitNAlim = new System.Windows.Forms.MaskedTextBox();
            this.codiceNAlim = new System.Windows.Forms.MaskedTextBox();
            this.inviaNAlim = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.materialeNAlim = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.descNAlim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabAlimF = new System.Windows.Forms.TabPage();
            this.numgAF = new System.Windows.Forms.MaskedTextBox();
            this.codiceAF = new System.Windows.Forms.MaskedTextBox();
            this.prezzounitAF = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.inviaAF = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.descAF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.opzioni = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.ordina = new System.Windows.Forms.Button();
            this.damodb = new System.Windows.Forms.MaskedTextBox();
            this.colonnab = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cancellab = new System.Windows.Forms.TextBox();
            this.modb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cancella = new System.Windows.Forms.Button();
            this.modifica = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.codice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descrizione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezzounit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datascadenza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materiale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.riciclabile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ricerca = new System.Windows.Forms.Button();
            this.ricercatxt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tabs.SuspendLayout();
            this.tabAlim.SuspendLayout();
            this.tabNAlim.SuspendLayout();
            this.tabAlimF.SuspendLayout();
            this.opzioni.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabAlim);
            this.tabs.Controls.Add(this.tabNAlim);
            this.tabs.Controls.Add(this.tabAlimF);
            this.tabs.Controls.Add(this.opzioni);
            this.tabs.Location = new System.Drawing.Point(2, 53);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(436, 394);
            this.tabs.TabIndex = 0;
            // 
            // tabAlim
            // 
            this.tabAlim.Controls.Add(this.prezzounitText);
            this.tabAlim.Controls.Add(this.codiceText);
            this.tabAlim.Controls.Add(this.dateTimePicker1);
            this.tabAlim.Controls.Add(this.inviaAlim);
            this.tabAlim.Controls.Add(this.label8);
            this.tabAlim.Controls.Add(this.label7);
            this.tabAlim.Controls.Add(this.label6);
            this.tabAlim.Controls.Add(this.label5);
            this.tabAlim.Controls.Add(this.descrizioneText);
            this.tabAlim.Controls.Add(this.label2);
            this.tabAlim.Location = new System.Drawing.Point(4, 22);
            this.tabAlim.Name = "tabAlim";
            this.tabAlim.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlim.Size = new System.Drawing.Size(428, 368);
            this.tabAlim.TabIndex = 0;
            this.tabAlim.Text = "Alimentari";
            this.tabAlim.UseVisualStyleBackColor = true;
            // 
            // prezzounitText
            // 
            this.prezzounitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezzounitText.Location = new System.Drawing.Point(36, 213);
            this.prezzounitText.Name = "prezzounitText";
            this.prezzounitText.Size = new System.Drawing.Size(204, 31);
            this.prezzounitText.TabIndex = 13;
            // 
            // codiceText
            // 
            this.codiceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codiceText.Location = new System.Drawing.Point(36, 90);
            this.codiceText.Mask = "0000000000000000";
            this.codiceText.Name = "codiceText";
            this.codiceText.Size = new System.Drawing.Size(204, 31);
            this.codiceText.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 287);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // inviaAlim
            // 
            this.inviaAlim.Location = new System.Drawing.Point(255, 90);
            this.inviaAlim.Name = "inviaAlim";
            this.inviaAlim.Size = new System.Drawing.Size(84, 217);
            this.inviaAlim.TabIndex = 10;
            this.inviaAlim.Text = "Invia";
            this.inviaAlim.UseVisualStyleBackColor = true;
            this.inviaAlim.Click += new System.EventHandler(this.inviaAlim_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Data di Scadenza";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Prezzo Unitario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descrizione";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Codice Articolo";
            // 
            // descrizioneText
            // 
            this.descrizioneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrizioneText.Location = new System.Drawing.Point(36, 149);
            this.descrizioneText.Name = "descrizioneText";
            this.descrizioneText.Size = new System.Drawing.Size(204, 29);
            this.descrizioneText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Articolo Alimentare";
            // 
            // tabNAlim
            // 
            this.tabNAlim.Controls.Add(this.prezzounitNAlim);
            this.tabNAlim.Controls.Add(this.codiceNAlim);
            this.tabNAlim.Controls.Add(this.inviaNAlim);
            this.tabNAlim.Controls.Add(this.radioButton2);
            this.tabNAlim.Controls.Add(this.radioButton1);
            this.tabNAlim.Controls.Add(this.label18);
            this.tabNAlim.Controls.Add(this.materialeNAlim);
            this.tabNAlim.Controls.Add(this.label14);
            this.tabNAlim.Controls.Add(this.label15);
            this.tabNAlim.Controls.Add(this.label16);
            this.tabNAlim.Controls.Add(this.label17);
            this.tabNAlim.Controls.Add(this.descNAlim);
            this.tabNAlim.Controls.Add(this.label3);
            this.tabNAlim.Location = new System.Drawing.Point(4, 22);
            this.tabNAlim.Name = "tabNAlim";
            this.tabNAlim.Padding = new System.Windows.Forms.Padding(3);
            this.tabNAlim.Size = new System.Drawing.Size(428, 368);
            this.tabNAlim.TabIndex = 1;
            this.tabNAlim.Text = "Non Alimentari";
            this.tabNAlim.UseVisualStyleBackColor = true;
            // 
            // prezzounitNAlim
            // 
            this.prezzounitNAlim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezzounitNAlim.Location = new System.Drawing.Point(39, 192);
            this.prezzounitNAlim.Name = "prezzounitNAlim";
            this.prezzounitNAlim.Size = new System.Drawing.Size(204, 31);
            this.prezzounitNAlim.TabIndex = 25;
            // 
            // codiceNAlim
            // 
            this.codiceNAlim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codiceNAlim.Location = new System.Drawing.Point(39, 91);
            this.codiceNAlim.Mask = "0000000000000000";
            this.codiceNAlim.Name = "codiceNAlim";
            this.codiceNAlim.Size = new System.Drawing.Size(204, 31);
            this.codiceNAlim.TabIndex = 24;
            // 
            // inviaNAlim
            // 
            this.inviaNAlim.Location = new System.Drawing.Point(259, 90);
            this.inviaNAlim.Name = "inviaNAlim";
            this.inviaNAlim.Size = new System.Drawing.Size(84, 217);
            this.inviaNAlim.TabIndex = 11;
            this.inviaNAlim.Text = "Invia";
            this.inviaNAlim.UseVisualStyleBackColor = true;
            this.inviaNAlim.Click += new System.EventHandler(this.inviaNAlim_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(79, 306);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(39, 306);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(34, 17);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Si";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(36, 290);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Riciclabile";
            // 
            // materialeNAlim
            // 
            this.materialeNAlim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialeNAlim.Location = new System.Drawing.Point(39, 246);
            this.materialeNAlim.Name = "materialeNAlim";
            this.materialeNAlim.Size = new System.Drawing.Size(204, 29);
            this.materialeNAlim.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Materiale";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Prezzo Unitario";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Descrizione";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Codice Articolo";
            // 
            // descNAlim
            // 
            this.descNAlim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descNAlim.Location = new System.Drawing.Point(39, 141);
            this.descNAlim.Name = "descNAlim";
            this.descNAlim.Size = new System.Drawing.Size(204, 29);
            this.descNAlim.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "Articolo non Alimentare";
            // 
            // tabAlimF
            // 
            this.tabAlimF.Controls.Add(this.numgAF);
            this.tabAlimF.Controls.Add(this.codiceAF);
            this.tabAlimF.Controls.Add(this.prezzounitAF);
            this.tabAlimF.Controls.Add(this.label19);
            this.tabAlimF.Controls.Add(this.dateTimePicker2);
            this.tabAlimF.Controls.Add(this.inviaAF);
            this.tabAlimF.Controls.Add(this.label9);
            this.tabAlimF.Controls.Add(this.label10);
            this.tabAlimF.Controls.Add(this.label11);
            this.tabAlimF.Controls.Add(this.label12);
            this.tabAlimF.Controls.Add(this.descAF);
            this.tabAlimF.Controls.Add(this.label4);
            this.tabAlimF.Location = new System.Drawing.Point(4, 22);
            this.tabAlimF.Name = "tabAlimF";
            this.tabAlimF.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlimF.Size = new System.Drawing.Size(428, 368);
            this.tabAlimF.TabIndex = 2;
            this.tabAlimF.Text = "Alimentari Freschi";
            this.tabAlimF.UseVisualStyleBackColor = true;
            // 
            // numgAF
            // 
            this.numgAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numgAF.Location = new System.Drawing.Point(36, 301);
            this.numgAF.Mask = "0";
            this.numgAF.Name = "numgAF";
            this.numgAF.Size = new System.Drawing.Size(204, 31);
            this.numgAF.TabIndex = 26;
            // 
            // codiceAF
            // 
            this.codiceAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codiceAF.Location = new System.Drawing.Point(36, 90);
            this.codiceAF.Mask = "0000000000000000";
            this.codiceAF.Name = "codiceAF";
            this.codiceAF.Size = new System.Drawing.Size(204, 31);
            this.codiceAF.TabIndex = 25;
            // 
            // prezzounitAF
            // 
            this.prezzounitAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezzounitAF.Location = new System.Drawing.Point(36, 195);
            this.prezzounitAF.Name = "prezzounitAF";
            this.prezzounitAF.Size = new System.Drawing.Size(204, 31);
            this.prezzounitAF.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(33, 285);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Giorni Apertura";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(36, 251);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // inviaAF
            // 
            this.inviaAF.Location = new System.Drawing.Point(255, 90);
            this.inviaAF.Name = "inviaAF";
            this.inviaAF.Size = new System.Drawing.Size(84, 240);
            this.inviaAF.TabIndex = 19;
            this.inviaAF.Text = "Invia";
            this.inviaAF.UseVisualStyleBackColor = true;
            this.inviaAF.Click += new System.EventHandler(this.inviaAF_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Data di Scadenza";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Prezzo Unitario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Descrizione";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Codice Articolo";
            // 
            // descAF
            // 
            this.descAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descAF.Location = new System.Drawing.Point(36, 142);
            this.descAF.Name = "descAF";
            this.descAF.Size = new System.Drawing.Size(204, 29);
            this.descAF.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 48);
            this.label4.TabIndex = 1;
            this.label4.Text = "Alimentare Fresco";
            // 
            // opzioni
            // 
            this.opzioni.Controls.Add(this.label21);
            this.opzioni.Controls.Add(this.ricercatxt);
            this.opzioni.Controls.Add(this.ricerca);
            this.opzioni.Controls.Add(this.button3);
            this.opzioni.Controls.Add(this.ordina);
            this.opzioni.Controls.Add(this.damodb);
            this.opzioni.Controls.Add(this.colonnab);
            this.opzioni.Controls.Add(this.label25);
            this.opzioni.Controls.Add(this.label24);
            this.opzioni.Controls.Add(this.label23);
            this.opzioni.Controls.Add(this.label22);
            this.opzioni.Controls.Add(this.cancellab);
            this.opzioni.Controls.Add(this.modb);
            this.opzioni.Controls.Add(this.button2);
            this.opzioni.Controls.Add(this.button1);
            this.opzioni.Controls.Add(this.cancella);
            this.opzioni.Controls.Add(this.modifica);
            this.opzioni.Controls.Add(this.label20);
            this.opzioni.Location = new System.Drawing.Point(4, 22);
            this.opzioni.Name = "opzioni";
            this.opzioni.Padding = new System.Windows.Forms.Padding(3);
            this.opzioni.Size = new System.Drawing.Size(428, 368);
            this.opzioni.TabIndex = 3;
            this.opzioni.Text = "Opzioni Aggiuntive";
            this.opzioni.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 33);
            this.button3.TabIndex = 23;
            this.button3.Text = "Importo Totale";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ordina
            // 
            this.ordina.Location = new System.Drawing.Point(200, 240);
            this.ordina.Name = "ordina";
            this.ordina.Size = new System.Drawing.Size(151, 33);
            this.ordina.TabIndex = 22;
            this.ordina.Text = "Ordina (Prezzo)";
            this.ordina.UseVisualStyleBackColor = true;
            this.ordina.Click += new System.EventHandler(this.ordina_Click);
            // 
            // damodb
            // 
            this.damodb.Location = new System.Drawing.Point(200, 108);
            this.damodb.Mask = "0";
            this.damodb.Name = "damodb";
            this.damodb.Size = new System.Drawing.Size(114, 20);
            this.damodb.TabIndex = 20;
            // 
            // colonnab
            // 
            this.colonnab.Location = new System.Drawing.Point(200, 69);
            this.colonnab.Mask = "0";
            this.colonnab.Name = "colonnab";
            this.colonnab.Size = new System.Drawing.Size(114, 20);
            this.colonnab.TabIndex = 19;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(197, 66);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 13);
            this.label25.TabIndex = 18;
            this.label25.Text = "Codice";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(197, 187);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(107, 13);
            this.label24.TabIndex = 14;
            this.label24.Text = "Codice da cancellare";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(197, 131);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 13);
            this.label23.TabIndex = 13;
            this.label23.Text = "Modifica";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(197, 92);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(106, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "Campo da modificare";
            // 
            // cancellab
            // 
            this.cancellab.Location = new System.Drawing.Point(200, 203);
            this.cancellab.Name = "cancellab";
            this.cancellab.Size = new System.Drawing.Size(114, 20);
            this.cancellab.TabIndex = 10;
            // 
            // modb
            // 
            this.modb.Location = new System.Drawing.Point(200, 147);
            this.modb.Name = "modb";
            this.modb.Size = new System.Drawing.Size(114, 20);
            this.modb.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Scarica File Scontrino";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Carica File Scontrino";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancella
            // 
            this.cancella.Location = new System.Drawing.Point(27, 190);
            this.cancella.Name = "cancella";
            this.cancella.Size = new System.Drawing.Size(151, 33);
            this.cancella.TabIndex = 4;
            this.cancella.Text = "Cancella";
            this.cancella.UseVisualStyleBackColor = true;
            this.cancella.Click += new System.EventHandler(this.cancella_Click);
            // 
            // modifica
            // 
            this.modifica.Location = new System.Drawing.Point(27, 56);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(151, 33);
            this.modifica.TabIndex = 3;
            this.modifica.Text = "Modifica";
            this.modifica.UseVisualStyleBackColor = true;
            this.modifica.Click += new System.EventHandler(this.modifica_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 48);
            this.label20.TabIndex = 1;
            this.label20.Text = "Opzioni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Articles Store 2023 Max Pro";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(439, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 28);
            this.label13.TabIndex = 3;
            this.label13.Text = "Cassa";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codice,
            this.descrizione,
            this.prezzounit,
            this.datascadenza,
            this.materiale,
            this.riciclabile,
            this.numg});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(444, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(344, 368);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // codice
            // 
            this.codice.Text = "Codice";
            // 
            // descrizione
            // 
            this.descrizione.Text = "Descrizione";
            // 
            // prezzounit
            // 
            this.prezzounit.Text = "Prezzo Unitario";
            // 
            // datascadenza
            // 
            this.datascadenza.Text = "Scadenza";
            // 
            // materiale
            // 
            this.materiale.Text = "Materiale";
            // 
            // riciclabile
            // 
            this.riciclabile.Text = "Riciclabile";
            // 
            // numg
            // 
            this.numg.Text = "Giorni Apertura";
            // 
            // ricerca
            // 
            this.ricerca.Location = new System.Drawing.Point(27, 318);
            this.ricerca.Name = "ricerca";
            this.ricerca.Size = new System.Drawing.Size(151, 33);
            this.ricerca.TabIndex = 24;
            this.ricerca.Text = "Ricerca";
            this.ricerca.UseVisualStyleBackColor = true;
            this.ricerca.Click += new System.EventHandler(this.button4_Click);
            // 
            // ricercatxt
            // 
            this.ricercatxt.Location = new System.Drawing.Point(200, 331);
            this.ricercatxt.Name = "ricercatxt";
            this.ricercatxt.Size = new System.Drawing.Size(114, 20);
            this.ricercatxt.TabIndex = 25;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(197, 316);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "Da ricercare";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.tabAlim.ResumeLayout(false);
            this.tabAlim.PerformLayout();
            this.tabNAlim.ResumeLayout(false);
            this.tabNAlim.PerformLayout();
            this.tabAlimF.ResumeLayout(false);
            this.tabAlimF.PerformLayout();
            this.opzioni.ResumeLayout(false);
            this.opzioni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabAlim;
        private System.Windows.Forms.TabPage tabNAlim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabAlimF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descrizioneText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button inviaAlim;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button inviaAF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox descAF;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox materialeNAlim;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox descNAlim;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button inviaNAlim;
        private System.Windows.Forms.MaskedTextBox codiceText;
        private System.Windows.Forms.MaskedTextBox prezzounitText;
        private System.Windows.Forms.MaskedTextBox prezzounitNAlim;
        private System.Windows.Forms.MaskedTextBox codiceNAlim;
        private System.Windows.Forms.MaskedTextBox codiceAF;
        private System.Windows.Forms.MaskedTextBox prezzounitAF;
        private System.Windows.Forms.MaskedTextBox numgAF;
        private System.Windows.Forms.TabPage opzioni;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox cancellab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancella;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.MaskedTextBox colonnab;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox modb;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader codice;
        private System.Windows.Forms.ColumnHeader descrizione;
        private System.Windows.Forms.ColumnHeader prezzounit;
        private System.Windows.Forms.ColumnHeader datascadenza;
        private System.Windows.Forms.ColumnHeader materiale;
        private System.Windows.Forms.ColumnHeader riciclabile;
        private System.Windows.Forms.ColumnHeader numg;
        private System.Windows.Forms.MaskedTextBox damodb;
        private System.Windows.Forms.Button ordina;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox ricercatxt;
        private System.Windows.Forms.Button ricerca;
    }
}

