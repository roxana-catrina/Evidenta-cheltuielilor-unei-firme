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
    public partial class Curs_nou : Form
    {
        public Curs_nou()
        {
            InitializeComponent();
        }
         public string get_data
        {
            get { return dateTimePicker_data.Value.ToString(); }
        }
        public string get_valuta_curs
        {
            get { return textBox_valuta.Text; }
        }
        private void button_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_valuta.Text != null)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
