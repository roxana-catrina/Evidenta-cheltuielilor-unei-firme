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
    public partial class Tranzactie_noua : Form
    {
        public Tranzactie_noua()
        {
            InitializeComponent();
        }
        public string get_CUI
        {
            get { return textBox_cui.Text; }
            set {  textBox_cui.Text = value;}
        }
        public string get_data
        {
            get { return dateTimePicker_data.Text; }
        }
          
        public string get_suma_valuta
        {
            get { return textBox_suma_valuta.Text; }
        }
        bool cuvantul_contine_litera(string cuvant)
        {
            foreach (char c in cuvant)
                if (char.IsLetter(c))
                    return false;
            return true;
        }
        private void Tranzactie_noua_Load(object sender, EventArgs e)
        {

        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            try {
            if (textBox_cui.Text.Trim().Length == 6 &&  cuvantul_contine_litera(textBox_suma_valuta.Text))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
                { 
                 
                    DialogResult = DialogResult.Cancel;
                }
        }    catch(Exception ex) {

                MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
