using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidenta_cheltuielilor_unei_firme
{
    public partial class Partener_nou : Form
    {
       
        public Partener_nou()
        {
            InitializeComponent();
        }

       

        public string getNume
        {
            get { return textBox_nume.Text; }
           set {  textBox_nume.Text = value;}

        }
       public string getCui
        {
            get { return textBox_cui.Text;}
            set {  textBox_cui.Text = value;}
        }
        public string getAdresa
        {
            get {  return textBox_adresa.Text;}
            set { textBox_adresa .Text = value;}

        }
        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (textBox_cui.Text.Length == 6)
            {
           
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Atentie la dimensiunea CUI-ului. Trebuie sa fie 6. ", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel; 
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
