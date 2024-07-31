using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidenta_cheltuielilor_unei_firme
{
    public partial class Raport_detaliat_toti_partenerii : Form
    {
        OracleConnection cn;
        OracleCommand cm;
        public Raport_detaliat_toti_partenerii()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Raport_detaliat_toti_partenerii_Load(object sender, EventArgs e)
        {
            try
            {
                cn = new OracleConnection("User Id=roxana;Password=student;Data Source=Roxana:1521/XE");
                cn.Open();
                string comanda = @"SELECT p.nume AS nume_partener," +
                    "\r\n t.cui," +
                    "\r\n t.data AS data_tranzactie," +
                    "\r\n t.suma_valuta AS suma_in_valuta," +
                    "\r\n t.suma_lei AS suma_in_lei," +
                    "\r\n CASE " +
                    "\r\n WHEN t.suma_lei > 0 THEN 'Intrare'" +
                    "\r\n ELSE 'Iesire'" +
                    "\r\n END AS tip" +
                    "\r\nFROM " +
                    "\r\n tranzactii t,parteneri p" +
                    "\r\nwhere" +
                    "\r\n t.cui = p.cui" +
                    "\r\nORDER BY p.nume, t.data";
                cm= new OracleCommand(comanda,cn);
                OracleDataAdapter dataAdapter = new OracleDataAdapter(cm);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Eroare la conectare sau încărcare date: " + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }
    }
}
