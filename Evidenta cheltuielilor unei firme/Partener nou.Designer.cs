namespace Evidenta_cheltuielilor_unei_firme
{
    partial class Partener_nou
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
            this.textBox_nume = new System.Windows.Forms.TextBox();
            this.textBox_cui = new System.Windows.Forms.TextBox();
            this.textBox_adresa = new System.Windows.Forms.TextBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.Nume = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_nume
            // 
            this.textBox_nume.Location = new System.Drawing.Point(294, 95);
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(319, 22);
            this.textBox_nume.TabIndex = 0;
            // 
            // textBox_cui
            // 
            this.textBox_cui.Location = new System.Drawing.Point(294, 161);
            this.textBox_cui.Name = "textBox_cui";
            this.textBox_cui.Size = new System.Drawing.Size(319, 22);
            this.textBox_cui.TabIndex = 1;
            // 
            // textBox_adresa
            // 
            this.textBox_adresa.Location = new System.Drawing.Point(294, 209);
            this.textBox_adresa.Name = "textBox_adresa";
            this.textBox_adresa.Size = new System.Drawing.Size(319, 22);
            this.textBox_adresa.TabIndex = 2;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(612, 380);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(132, 44);
            this.button_Ok.TabIndex = 3;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(36, 380);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(132, 44);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Location = new System.Drawing.Point(171, 95);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(43, 16);
            this.Nume.TabIndex = 5;
            this.Nume.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cui";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adresa";
            // 
            // Partener_nou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.textBox_adresa);
            this.Controls.Add(this.textBox_cui);
            this.Controls.Add(this.textBox_nume);
            this.Name = "Partener_nou";
            this.Text = "Partener_nou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nume;
        private System.Windows.Forms.TextBox textBox_cui;
        private System.Windows.Forms.TextBox textBox_adresa;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}