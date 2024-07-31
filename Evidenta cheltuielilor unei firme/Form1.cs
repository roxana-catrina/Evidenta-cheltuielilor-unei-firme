using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Evidenta_cheltuielilor_unei_firme
{
    public partial class Form1 : Form
    {
        OracleConnection cn;
        OracleCommand cmd;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
            cn = new OracleConnection("User Id=roxana;Password=student;Data Source=Roxana:1521/XE"); }
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

        private void adauga_partener_Click(object sender, EventArgs e)
        {
            Partener_nou f=new Partener_nou();
            f.ShowDialog();

            try
            {
                if (f.DialogResult == DialogResult.OK)
                {
                    cn.Open();
                    string linie_tabela = "INSERT INTO parteneri (nume, cui, adresa) VALUES (:nume, :cui, :adresa)";
                    cmd = new OracleCommand(linie_tabela, cn);
                    cmd.Parameters.Add(new OracleParameter("nume", f.getNume));
                    cmd.Parameters.Add(new OracleParameter("cui", f.getCui));
                    cmd.Parameters.Add(new OracleParameter("adresa", f.getAdresa));
                    cmd.ExecuteNonQuery();

                   
                    linie_tabela = "INSERT INTO tranzactii (cui,data,suma_valuta) VALUES (:cui,:data,:suma_valuta)";
                    cmd = new OracleCommand(linie_tabela, cn);
                    cmd.Parameters.Add(new OracleParameter("cui", f.getCui));
                    cmd.Parameters.Add(new OracleParameter("data", Convert.ToDateTime(DateTime.Now)));
                    cmd.Parameters.Add(new OracleParameter("suma_valuta", Convert.ToDouble(0)));
                    cmd.ExecuteNonQuery();
                      
                   
                    MessageBox.Show("Linia a fost adaugata cu succes");
                }

               
            }
            catch (Exception ex)
            { MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
           

        }

        private void adauga_curs_Click(object sender, EventArgs e)
        {
            Curs_nou f=new Curs_nou();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                try
                {
                    cn.Open();
                    string linie_tabela = "INSERT  INTO curs (data,rata) VALUES (:data,:rata)";
                    cmd = new OracleCommand(linie_tabela, cn);
                    cmd.Parameters.Add(new OracleParameter("data", Convert.ToDateTime(f.get_data)));
                    cmd.Parameters.Add(new OracleParameter("rata", Convert.ToDouble(f.get_valuta_curs)));
                    cmd.ExecuteNonQuery();
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

        private void adauga_tranzactie_Click(object sender, EventArgs e)
        {
            Tranzactie_noua f = new Tranzactie_noua();
            f.ShowDialog();
            if(f.DialogResult == DialogResult.OK)
            {
                try
                {
                    cn.Open();
                    string linie_tabela = "INSERT INTO tranzactii (cui,data,suma_valuta) VALUES (:cui,:data,:suma_valuta)";
                    cmd = new OracleCommand(linie_tabela, cn);
                    cmd.Parameters.Add(new OracleParameter("cui", f.get_CUI));
                    cmd.Parameters.Add(new OracleParameter("data", Convert.ToDateTime(f.get_data)));
                    cmd.Parameters.Add(new OracleParameter("suma_valuta", Convert.ToDouble(f.get_suma_valuta)));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Linia a fost adaugata cu succes");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if(cn.State==ConnectionState.Open)
                        cn.Close();
                }
            }
        }

        private void button_toti_partenerii_Click(object sender, EventArgs e)
        {
            Parteneri f = new Parteneri();
            f.ShowDialog();
        }

       
    }
}
