using Oracle.ManagedDataAccess.Client;
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
    public partial class Parteneri_care_doar_au_incasat : Form
    {
        public Parteneri_care_doar_au_incasat()
        {
            InitializeComponent();
        }

        private void button_inapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        OracleConnection cn;
        OracleCommand com;
        private void Parteneri_care_doar_au_incasat_Load(object sender, EventArgs e)
        {
            try
            {
                cn = new OracleConnection("User Id=roxana;Password=student;Data Source=Roxana:1521/XE");
                cn.Open();
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
        public bool VerificaAnValid(string an)
        {
            try {
                int anul = Convert.ToInt32(an);
                int anulCurent = DateTime.Now.Year;
                if (anul > 1990 && anul <= anulCurent)
                {
                    return true;
                }

                return false; }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


      
            private void button_cauta_Click(object sender, EventArgs e)
            {
                try
                {
                    if (VerificaAnValid(textBox_an.Text))
                    {
                        
                            cn.Open();

                            using (OracleCommand cmd = new OracleCommand("parteneri_doar_cu_incasari", cn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new OracleParameter("v_an", Convert.ToInt32(textBox_an.Text)));
                                OracleParameter iesire = new OracleParameter("p_iesire", OracleDbType.RefCursor);
                                iesire.Direction = ParameterDirection.Output;
                                cmd.Parameters.Add(iesire);
                                   OracleDataAdapter da = new OracleDataAdapter(cmd);
                                
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);
                                    dataGridView1.DataSource = dt;
                                
                            }
                        
                    }
                    else MessageBox.Show("Error: ANUL nu este valid!!! " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }

