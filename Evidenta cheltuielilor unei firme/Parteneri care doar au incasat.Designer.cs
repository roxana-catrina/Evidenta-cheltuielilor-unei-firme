namespace Evidenta_cheltuielilor_unei_firme
{
    partial class Parteneri_care_doar_au_incasat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_an = new System.Windows.Forms.TextBox();
            this.button_cauta = new System.Windows.Forms.Button();
            this.button_inapoi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_an
            // 
            this.textBox_an.Location = new System.Drawing.Point(67, 70);
            this.textBox_an.Name = "textBox_an";
            this.textBox_an.Size = new System.Drawing.Size(179, 22);
            this.textBox_an.TabIndex = 0;
            // 
            // button_cauta
            // 
            this.button_cauta.Location = new System.Drawing.Point(290, 55);
            this.button_cauta.Name = "button_cauta";
            this.button_cauta.Size = new System.Drawing.Size(136, 52);
            this.button_cauta.TabIndex = 1;
            this.button_cauta.Text = "Cautare";
            this.button_cauta.UseVisualStyleBackColor = true;
            this.button_cauta.Click += new System.EventHandler(this.button_cauta_Click);
            // 
            // button_inapoi
            // 
            this.button_inapoi.Location = new System.Drawing.Point(31, 373);
            this.button_inapoi.Name = "button_inapoi";
            this.button_inapoi.Size = new System.Drawing.Size(136, 52);
            this.button_inapoi.TabIndex = 2;
            this.button_inapoi.Text = "Inapoi";
            this.button_inapoi.UseVisualStyleBackColor = true;
            this.button_inapoi.Click += new System.EventHandler(this.button_inapoi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(763, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adauga un an:";
            // 
            // Parteneri_care_doar_au_incasat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_inapoi);
            this.Controls.Add(this.button_cauta);
            this.Controls.Add(this.textBox_an);
            this.Name = "Parteneri_care_doar_au_incasat";
            this.Text = "Parteneri_care_doar_au_incasat";
            this.Load += new System.EventHandler(this.Parteneri_care_doar_au_incasat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_an;
        private System.Windows.Forms.Button button_cauta;
        private System.Windows.Forms.Button button_inapoi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}