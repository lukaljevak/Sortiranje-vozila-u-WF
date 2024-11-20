using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortiranje_vozila
{
    public partial class Form1 : Form
    {
        private List<Vozilo> vozila = new List<Vozilo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtGodinaProizvodnje.Text, out int godina) &&
                int.TryParse(txtKilometraza.Text, out int kilometraza) &&
                godina > 0 && kilometraza >= 0)
            {
                Vozilo novoVozilo = new Vozilo
                {
                    Marka = txtMarka.Text,
                    Model = txtModel.Text,
                    GodinaProizvodnje = godina,
                    Kilometraza = kilometraza
                };
                vozila.Add(novoVozilo);
                UpdateListBox();

                txtMarka.Clear();
                txtModel.Clear();
                txtGodinaProizvodnje.Clear();
                txtKilometraza.Clear();

            }
            else
            {
                MessageBox.Show("Unesite ispravne podatke.");
            }
        }

        private void btnSortirajVozila_Click(object sender, EventArgs e)
        {
            IEnumerable<Vozilo> sortiranaVozila = null;

            switch (cmbSortiraj.SelectedItem.ToString())
            {
                case "Marka":
                    sortiranaVozila = vozila.OrderBy(v => v.Marka);
                    break;
                case "Model":
                    sortiranaVozila = vozila.OrderBy(v => v.Model);
                    break;
                case "GodinaProizvodnje":
                    sortiranaVozila = vozila.OrderBy(v => v.GodinaProizvodnje);
                    break;
                case "Kilometraza":
                    sortiranaVozila = vozila.OrderBy(v => v.Kilometraza);
                    break;
            }

            if (sortiranaVozila != null)
            {
                txtSortiranaLista.Text = string.Join(Environment.NewLine, sortiranaVozila.Select(v => $"{v.Marka} - {v.Model} - {v.GodinaProizvodnje} - {v.Kilometraza}"));
            }
        }

        private void UpdateListBox()
        {
            listBoxVozila.Items.Clear();
            foreach (var vozilo in vozila)
            {
                listBoxVozila.Items.Add($"{vozilo.Marka} - {vozilo.Model} - {vozilo.GodinaProizvodnje} - {vozilo.Kilometraza}");
            }
        }

        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            if (listBoxVozila.SelectedItem != null)
            {
                vozila.RemoveAt(listBoxVozila.SelectedIndex);
                UpdateListBox();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("vozila.txt"))
            {
                foreach (var vozilo in vozila)
                {
                    writer.WriteLine($"{vozilo.Marka},{vozilo.Model},{vozilo.GodinaProizvodnje},{vozilo.Kilometraza}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("vozila.txt"))
            {
                using (StreamReader reader = new StreamReader("vozila.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var podaci = line.Split(',');
                        vozila.Add(new Vozilo
                        {
                            Marka = podaci[0],
                            Model = podaci[1],
                            GodinaProizvodnje = int.Parse(podaci[2]),
                            Kilometraza = int.Parse(podaci[3])
                        });
                    }
                }
                UpdateListBox();
            }
        }


        public class Vozilo
        {
            public string Marka { get; set; }
            public string Model { get; set; }
            public int GodinaProizvodnje { get; set; }
            public int Kilometraza { get; set; }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}