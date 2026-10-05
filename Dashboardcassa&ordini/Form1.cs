using System.Windows.Forms;

namespace Dashboardcassa_ordini
{
    public partial class Form1 : Form
    {
        List<string> origineD = new List<string>();
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
            int k = 0;
            string elemento = txtArt.Text;
            elemento = elemento.Trim();
            elemento = elemento.ToLower();
            for (int i = 0; i < lista.Items.Count; i++)
            {
                if (lista.Items[i].ToString() == elemento)
                {
                    MessageBox.Show("Elemento già presente");
                    return;
                }
            }
            string p = Convert.ToString(txtPrezzo.Text);
            lista.Items.Add(elemento);
            lista.Items.Add(p);
            origineD.Add(elemento);
            aggiorna();
        }

        private void txtPrezzo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
