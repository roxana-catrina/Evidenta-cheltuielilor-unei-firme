namespace Evidenta_cheltuielilor_unei_firme
{
    partial class Tranzactii
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_inapoi = new System.Windows.Forms.Button();
            this.adauga_tranzactie = new System.Windows.Forms.Button();
            this.button_ordonare_data = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_inapoi
            // 
            this.button_inapoi.Location = new System.Drawing.Point(42, 368);
            this.button_inapoi.Name = "button_inapoi";
            this.button_inapoi.Size = new System.Drawing.Size(148, 58);
            this.button_inapoi.TabIndex = 1;
            this.button_inapoi.Text = "Inapoi";
            this.button_inapoi.UseVisualStyleBackColor = true;
            this.button_inapoi.Click += new System.EventHandler(this.button_inapoi_Click);
            // 
            // adauga_tranzactie
            // 
            this.adauga_tranzactie.Location = new System.Drawing.Point(550, 226);
            this.adauga_tranzactie.Name = "adauga_tranzactie";
            this.adauga_tranzactie.Size = new System.Drawing.Size(175, 65);
            this.adauga_tranzactie.TabIndex = 3;
            this.adauga_tranzactie.Text = "Adauga tranzactie nou";
            this.adauga_tranzactie.UseVisualStyleBackColor = true;
            this.adauga_tranzactie.Click += new System.EventHandler(this.adauga_tranzactie_Click);
            // 
            // button_ordonare_data
            // 
            this.button_ordonare_data.Location = new System.Drawing.Point(15, 226);
            this.button_ordonare_data.Name = "button_ordonare_data";
            this.button_ordonare_data.Size = new System.Drawing.Size(175, 65);
            this.button_ordonare_data.TabIndex = 4;
            this.button_ordonare_data.Text = "Ordonare dupa data";
            this.button_ordonare_data.UseVisualStyleBackColor = true;
            this.button_ordonare_data.Click += new System.EventHandler(this.button_ordonare_data_Click);
            // 
            // Tranzactii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ordonare_data);
            this.Controls.Add(this.adauga_tranzactie);
            this.Controls.Add(this.button_inapoi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Tranzactii";
            this.Text = "Tranzactii";
            this.Load += new System.EventHandler(this.Tranzactii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_inapoi;
        private System.Windows.Forms.Button adauga_tranzactie;
        private System.Windows.Forms.Button button_ordonare_data;
    }
}