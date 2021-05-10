using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace csvTransformer
{
    public partial class UnosPodataka : Form
    {
        List<Učenik> listaUčenika = new List<Učenik>();

        String putanja = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "csvTransformerPodaci");

        

        public UnosPodataka()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            if( !Directory.Exists(putanja))
            {
                Directory.CreateDirectory(putanja);
            }
            StreamWriter sw = new StreamWriter(putanja + "/podaci.csv");
            

            foreach(Učenik uc in listaUčenika)
            {
                sw.Write(uc.Ispis());
            }
            sw.Close();
            
            Form1 frmPocetna = new Form1();
            frmPocetna.Show();
            this.Hide();
        }

        private void btnUnos1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBxMail.Text.Contains('@'))
                {
                    Učenik objUcenik = new Učenik(txtBxIme.Text, txtBxPrez.Text, txtBxMail.Text, cmBxRaz.Text);

                    listaUčenika.Add(objUcenik);

                    txtBxIme.Clear();
                    txtBxPrez.Clear();
                    txtBxMail.Clear();
                    MessageBox.Show("Podaci su uneseni.", "Unos OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Podaci su uneseni.", "Unos OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message, "Greška");
            }
        }
    }
}
