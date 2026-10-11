using System.Windows.Forms;

namespace Dashboardcassa_ordini
{
    public partial class Form1 : Form
    {
        List<string> origineD = new List<string>();
        double prezzoTotale = 0;
        string file = "Spesa.txt";
        public Form1()
        {
            InitializeComponent();
        }
        private bool controlloStringa(string x)
        {
            if (string.IsNullOrEmpty(x))
            {
                return false;
            }

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != ' ')
                {
                    return true;
                }
            }
            return false;
        }
        private void aggiorna()
        {
            lista.Items.Clear();
            foreach (string s in origineD)
            {
                lista.Items.Add(s);
            }
        }

        private void Agg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArt.Text) || string.IsNullOrWhiteSpace(txtPrezzo.Text) || string.IsNullOrWhiteSpace(txtQ.Text))
            {
                MessageBox.Show("Inserisci un nome e un prezzo validi.");
            }
            else
            {
                int quantita = Convert.ToInt32(txtQ.Text);
                double prezzo = Convert.ToDouble(txtPrezzo.Text);
                if (txtPrezzo.Text.Contains('.'))
                {
                    MessageBox.Show("Errore, cambiare il punto con una virgola");
                    return;
                }
                string nome = txtArt.Text;

                prezzo = prezzo * quantita;
                prezzoTotale = prezzoTotale + prezzo;
                // sistemare problema con virgola e punto
                origineD.Add("x" + quantita + " " + nome + " - " + prezzo + "€");

                txtQ.Clear();
                txtPrezzo.Clear();
                txtArt.Clear();

                Tot.Text = prezzoTotale + "€";
                aggiorna();
            }
        }

        private void txtPrezzo_TextChanged(object sender, EventArgs e)
        {

        }

        private void rem_Click_1(object sender, EventArgs e)
        {
            int indice = lista.SelectedIndex;

            if (indice != -1)
            {
                origineD.RemoveAt(indice);
                int quantita = Convert.ToInt32(txtQ.Text);
                double prezzo = Convert.ToDouble(txtPrezzo.Text);

                prezzo = prezzo * quantita;
                prezzoTotale = prezzoTotale - prezzo;

                Tot.Text = prezzoTotale + "€";
            }
            else
            {
                MessageBox.Show("errore");
            }

            aggiorna();
        }

        private void caricaDati(string fileName)
        {
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Il file non esiste");
            }
            else
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string riga = sr.ReadLine();
                        if (controlloStringa(riga) == true)
                        {
                            riga = riga.Trim();
                            riga = riga.ToLower();
                            origineD.Add(riga);
                        }
                    }
                }
            }

        }
        private void salvaF_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(lista.Text);
                sw.WriteLine("Il totale della spesa è: " + Tot.Text);
            }
        }

         
    }
    

}
