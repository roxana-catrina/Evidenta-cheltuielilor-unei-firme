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
    public partial class Parteneri : Form
    {
        public Parteneri()
        {
            InitializeComponent();
        }
        OracleConnection cn;
        OracleCommand com;
        private void Parteneri_Load(object sender, EventArgs e)
        {
            try { 
            cn = new OracleConnection("User Id=roxana;Password=student;Data Source=Roxana:1521/XE");
            cn.Open();
            com = cn.CreateCommand();
            com.CommandText = "SELECT * FROM parteneri";
            OracleDataReader reader = com.ExecuteReader();
            DataTable dt=new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
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

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void button_tranzactii_Click(object sender, EventArgs e)
        {
          
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow rand_selectat = dataGridView1.SelectedRows[0];
                if (rand_selectat.Cells["CUI"] != null)
                {
                    string cui = rand_selectat.Cells["CUI"].Value.ToString();
                    Tranzactii f= new Tranzactii();
                    f.get_cui = cui;
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Coloana 'CUI' nu există în rândul selectat.");
                }
            }
            else
            {
                MessageBox.Show("Nu există rânduri selectate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
          private void Citire_date_rulaj(OracleConnection con,string get_cui)
        {
            OracleCommand cmd = new OracleCommand("rulaj_partener", con);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter parametru_iesire = new OracleParameter("return_value", OracleDbType.Decimal);
            parametru_iesire.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(parametru_iesire);
            OracleParameter parametru_intrare = new OracleParameter("v_cui", OracleDbType.Char);
            parametru_intrare.Value = get_cui;
            cmd.Parameters.Add(parametru_intrare);

            try
            {
             
                cmd.ExecuteNonQuery();
                decimal result = ((OracleDecimal)cmd.Parameters["return_value"].Value).Value;
                MessageBox.Show("Rulaj: " + result.ToString()+" lei (Suma dintre iesiri si intrari, luate fara semn)", "Rezultatul Funcției", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void citire_date_raport(OracleConnection con)
        {
            
                OracleCommand cmdEnable = new OracleCommand("BEGIN DBMS_OUTPUT.ENABLE(NULL); END;", con);
                cmdEnable.ExecuteNonQuery();
                OracleCommand cmd = new OracleCommand("BEGIN DBMS_OUTPUT.GET_LINES(:comentariu, :valori); END;", con);
                cmd.CommandType = CommandType.Text;
                OracleParameter isire = new OracleParameter("comentariu", OracleDbType.Varchar2)
                {
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    Size = 5,
                    ArrayBindSize = new int[5],
                    Direction = ParameterDirection.Output
                };
                for (int i = 0; i < 5; i++)
                {
                isire.ArrayBindSize[i] = 100;
                }

                OracleParameter valori_calculate = new OracleParameter("valori", OracleDbType.Int32)
                {
                    Direction = ParameterDirection.InputOutput,
                    Value = 5
                };

                cmd.Parameters.Add(isire);
                cmd.Parameters.Add(valori_calculate);
                cmd.ExecuteNonQuery();
            List<string> detalii = new List<string>();
                OracleString[] lines = (OracleString[])cmd.Parameters["comentariu"].Value;
                foreach (var line in lines)
                {
                    if (line != null && !line.IsNull)
                    {
                        detalii.Add(line.ToString());
                         detalii.Add(" ");
                    }
                }
            
            MessageBox.Show(string.Join(Environment.NewLine, detalii), "Detalii Raport", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void button_raport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    cn.Open();
                    DataGridViewRow rand_selectat = dataGridView1.SelectedRows[0];
                    string cui = rand_selectat.Cells["CUI"].Value.ToString();

                    OracleCommand cmd = new OracleCommand("raport_partener_cui", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new OracleParameter("v_cui", cui));
                    cmd.ExecuteNonQuery();
                    citire_date_raport(cn);
                }
                else
                {
                    MessageBox.Show("Nu există rânduri selectate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void button_rulaj_Click(object sender, EventArgs e)
        {
            try { 
            if(dataGridView1.Rows.Count > 0) {
                cn.Open();
                DataGridViewRow rand_selectat = dataGridView1.SelectedRows[0];
                string cui = rand_selectat.Cells["CUI"].Value.ToString();
                com.ExecuteNonQuery();
                Citire_date_rulaj(cn,cui);

        }}
            catch (Exception ex)
            {
                MessageBox.Show("Nu există rânduri selectate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(cn.State==ConnectionState.Open)
                    cn.Close();
            }
        
        }

        private void button_ordine_alfabetica_Click(object sender, EventArgs e)
        {
            try { 
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
             DataView dataView = dataTable.DefaultView;
            dataView.Sort = "Nume ASC";
            dataGridView1.DataSource = dataView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_raport_detaliat_toti_partenerii_Click(object sender, EventArgs e)
        {
            Raport_detaliat_toti_partenerii f = new Raport_detaliat_toti_partenerii();
            f.ShowDialog();
        }

        private void Inapoi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button_parteneri_care_doar_au_incasat_an_Click(object sender, EventArgs e)
        {
            Parteneri_care_doar_au_incasat f= new Parteneri_care_doar_au_incasat();
            f.ShowDialog();
        }
    }
}
