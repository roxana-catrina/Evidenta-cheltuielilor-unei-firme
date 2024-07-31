using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
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
    public partial class Tranzactii : Form
    {
        OracleConnection cn;
        OracleCommand com;
        public Tranzactii()
        {
            InitializeComponent();
        }
        public string get_cui { get; set; }


        private void Tranzactii_Load(object sender, EventArgs e)
        {

            cn = new OracleConnection("User Id=roxana;Password=student;Data Source=Roxana:1521/XE");

            try
            {
               
                cn.Open();
                com = cn.CreateCommand();
                com.CommandText = "SELECT * FROM tranzactii WHERE cui=:get_cui";
                com.Parameters.Add(new OracleParameter("get_cui", get_cui));
                OracleDataReader reader = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }

        }

        private void button_inapoi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Refresh_DataGridView(string cui)
        {
          
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            string comanda = "SELECT * FROM tranzactii WHERE cui = :cui";
             OracleDataAdapter adapter = new OracleDataAdapter(comanda, cn);
                adapter.SelectCommand.Parameters.Add(new OracleParameter("cui", cui));
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            
        }


        private void adauga_tranzactie_Click(object sender, EventArgs e)
        {
            Tranzactie_noua f = new Tranzactie_noua();
            if (dataGridView1.Rows.Count > 0)
            {
                DataGridViewRow firstRow = dataGridView1.Rows[0];
                string cui = firstRow.Cells["CUI"].Value.ToString();
                f.get_CUI = cui;
                f.ShowDialog();
                if (f.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        cn.Open();
                        string linie_tabela = "INSERT INTO tranzactii (cui,data,suma_valuta) VALUES (:cui,:data,:suma_valuta)";
                        com = new OracleCommand(linie_tabela, cn);
                        com.Parameters.Add(new OracleParameter("cui", f.get_CUI));
                        com.Parameters.Add(new OracleParameter("data", Convert.ToDateTime(f.get_data)));
                        com.Parameters.Add(new OracleParameter("suma_valuta", Convert.ToDouble(f.get_suma_valuta)));
                        com.ExecuteNonQuery();
                        Refresh_DataGridView(cui);
                        MessageBox.Show("Linia a fost adaugata cu succes");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (cn.State == ConnectionState.Open)
                            cn.Close();
                    }
                }
            }
        }

        private void button_ordonare_data_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                DataView dataView = dataTable.DefaultView;
                dataView.Sort = "Data DESC";
                dataGridView1.DataSource = dataView;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


