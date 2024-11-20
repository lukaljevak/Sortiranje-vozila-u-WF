
namespace Sortiranje_vozila
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.txtKilometraza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.listBoxVozila = new System.Windows.Forms.ListBox();
            this.cmbSortiraj = new System.Windows.Forms.ComboBox();
            this.btnSortirajVozila = new System.Windows.Forms.Button();
            this.txtSortiranaLista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(117, 38);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(117, 76);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 1;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(117, 115);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(100, 20);
            this.txtGodinaProizvodnje.TabIndex = 2;
            this.txtGodinaProizvodnje.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.Location = new System.Drawing.Point(117, 150);
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.Size = new System.Drawing.Size(100, 20);
            this.txtKilometraza.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Godina proizvodnje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kilometraza";
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(90, 209);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(95, 23);
            this.btnDodajVozilo.TabIndex = 8;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            // 
            // listBoxVozila
            // 
            this.listBoxVozila.FormattingEnabled = true;
            this.listBoxVozila.Location = new System.Drawing.Point(317, 33);
            this.listBoxVozila.Name = "listBoxVozila";
            this.listBoxVozila.Size = new System.Drawing.Size(257, 199);
            this.listBoxVozila.TabIndex = 9;
            // 
            // cmbSortiraj
            // 
            this.cmbSortiraj.FormattingEnabled = true;
            this.cmbSortiraj.Items.AddRange(new object[] {
            "Marka",
            "Model",
            "Godina proizvodnje",
            "Kilometraza"});
            this.cmbSortiraj.Location = new System.Drawing.Point(316, 247);
            this.cmbSortiraj.Name = "cmbSortiraj";
            this.cmbSortiraj.Size = new System.Drawing.Size(121, 21);
            this.cmbSortiraj.TabIndex = 10;
            // 
            // btnSortirajVozila
            // 
            this.btnSortirajVozila.Location = new System.Drawing.Point(90, 258);
            this.btnSortirajVozila.Name = "btnSortirajVozila";
            this.btnSortirajVozila.Size = new System.Drawing.Size(95, 23);
            this.btnSortirajVozila.TabIndex = 11;
            this.btnSortirajVozila.Text = "Sortiraj vozila";
            this.btnSortirajVozila.UseVisualStyleBackColor = true;
            // 
            // txtSortiranaLista
            // 
            this.txtSortiranaLista.Location = new System.Drawing.Point(317, 295);
            this.txtSortiranaLista.Multiline = true;
            this.txtSortiranaLista.Name = "txtSortiranaLista";
            this.txtSortiranaLista.Size = new System.Drawing.Size(166, 54);
            this.txtSortiranaLista.TabIndex = 12;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(690, 431);
            this.Controls.Add(this.txtSortiranaLista);
            this.Controls.Add(this.btnSortirajVozila);
            this.Controls.Add(this.cmbSortiraj);
            this.Controls.Add(this.listBoxVozila);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKilometraza);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtKilometraza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.ListBox listBoxVozila;
        private System.Windows.Forms.ComboBox cmbSortiraj;
        private System.Windows.Forms.Button btnSortirajVozila;
        private System.Windows.Forms.TextBox txtSortiranaLista;
    }
}

