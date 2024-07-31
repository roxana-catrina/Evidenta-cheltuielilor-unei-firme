namespace Evidenta_cheltuielilor_unei_firme
{
    partial class Form1
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
            this.adauga_curs = new System.Windows.Forms.Button();
            this.adauga_partener = new System.Windows.Forms.Button();
            this.adauga_tranzactie = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_toti_partenerii = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adauga_curs
            // 
            this.adauga_curs.Location = new System.Drawing.Point(12, 28);
            this.adauga_curs.Name = "adauga_curs";
            this.adauga_curs.Size = new System.Drawing.Size(175, 65);
            this.adauga_curs.TabIndex = 0;
            this.adauga_curs.Text = "Adauga curs nou";
            this.adauga_curs.UseVisualStyleBackColor = true;
            this.adauga_curs.Click += new System.EventHandler(this.adauga_curs_Click);
            // 
            // adauga_partener
            // 
            this.adauga_partener.Location = new System.Drawing.Point(204, 28);
            this.adauga_partener.Name = "adauga_partener";
            this.adauga_partener.Size = new System.Drawing.Size(175, 65);
            this.adauga_partener.TabIndex = 1;
            this.adauga_partener.Text = "Adauga partener nou";
            this.adauga_partener.UseVisualStyleBackColor = true;
            this.adauga_partener.Click += new System.EventHandler(this.adauga_partener_Click);
            // 
            // adauga_tranzactie
            // 
            this.adauga_tranzactie.Location = new System.Drawing.Point(407, 28);
            this.adauga_tranzactie.Name = "adauga_tranzactie";
            this.adauga_tranzactie.Size = new System.Drawing.Size(175, 65);
            this.adauga_tranzactie.TabIndex = 2;
            this.adauga_tranzactie.Text = "Adauga tranzactie nou";
            this.adauga_tranzactie.UseVisualStyleBackColor = true;
            this.adauga_tranzactie.Click += new System.EventHandler(this.adauga_tranzactie_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(25, 381);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(166, 47);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_toti_partenerii
            // 
            this.button_toti_partenerii.Location = new System.Drawing.Point(603, 28);
            this.button_toti_partenerii.Name = "button_toti_partenerii";
            this.button_toti_partenerii.Size = new System.Drawing.Size(175, 65);
            this.button_toti_partenerii.TabIndex = 7;
            this.button_toti_partenerii.Text = "Toti partenerii";
            this.button_toti_partenerii.UseVisualStyleBackColor = true;
            this.button_toti_partenerii.Click += new System.EventHandler(this.button_toti_partenerii_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_toti_partenerii);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.adauga_tranzactie);
            this.Controls.Add(this.adauga_partener);
            this.Controls.Add(this.adauga_curs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adauga_curs;
        private System.Windows.Forms.Button adauga_partener;
        private System.Windows.Forms.Button adauga_tranzactie;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_toti_partenerii;
    }
}

