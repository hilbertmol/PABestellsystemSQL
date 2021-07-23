
namespace PABuchungssystemSQL
{
    partial class frmBestellungBearbeiten
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
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.txtKundennr = new System.Windows.Forms.TextBox();
            this.lblKundennr = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtProduktnr = new System.Windows.Forms.TextBox();
            this.txtBestellungsnr = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblProduktnr = new System.Windows.Forms.Label();
            this.lblBestellungsnr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(442, 426);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(160, 37);
            this.btnAbbrechen.TabIndex = 62;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // txtKundennr
            // 
            this.txtKundennr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKundennr.Location = new System.Drawing.Point(263, 265);
            this.txtKundennr.Name = "txtKundennr";
            this.txtKundennr.Size = new System.Drawing.Size(339, 26);
            this.txtKundennr.TabIndex = 51;
            // 
            // lblKundennr
            // 
            this.lblKundennr.AutoSize = true;
            this.lblKundennr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKundennr.Location = new System.Drawing.Point(139, 268);
            this.lblKundennr.Name = "lblKundennr";
            this.lblKundennr.Size = new System.Drawing.Size(88, 20);
            this.lblKundennr.TabIndex = 50;
            this.lblKundennr.Text = "KundenNr:";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(263, 426);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(160, 37);
            this.btnOK.TabIndex = 49;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtDatum
            // 
            this.txtDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatum.Location = new System.Drawing.Point(263, 362);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(339, 26);
            this.txtDatum.TabIndex = 48;
            // 
            // txtProduktnr
            // 
            this.txtProduktnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduktnr.Location = new System.Drawing.Point(263, 315);
            this.txtProduktnr.Name = "txtProduktnr";
            this.txtProduktnr.Size = new System.Drawing.Size(339, 26);
            this.txtProduktnr.TabIndex = 47;
            // 
            // txtBestellungsnr
            // 
            this.txtBestellungsnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBestellungsnr.Location = new System.Drawing.Point(263, 212);
            this.txtBestellungsnr.Name = "txtBestellungsnr";
            this.txtBestellungsnr.Size = new System.Drawing.Size(339, 26);
            this.txtBestellungsnr.TabIndex = 46;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(139, 365);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(64, 20);
            this.lblDatum.TabIndex = 45;
            this.lblDatum.Text = "Datum:";
            // 
            // lblProduktnr
            // 
            this.lblProduktnr.AutoSize = true;
            this.lblProduktnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduktnr.Location = new System.Drawing.Point(139, 318);
            this.lblProduktnr.Name = "lblProduktnr";
            this.lblProduktnr.Size = new System.Drawing.Size(89, 20);
            this.lblProduktnr.TabIndex = 44;
            this.lblProduktnr.Text = "ProduktNr:";
            // 
            // lblBestellungsnr
            // 
            this.lblBestellungsnr.AutoSize = true;
            this.lblBestellungsnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestellungsnr.Location = new System.Drawing.Point(139, 215);
            this.lblBestellungsnr.Name = "lblBestellungsnr";
            this.lblBestellungsnr.Size = new System.Drawing.Size(120, 20);
            this.lblBestellungsnr.TabIndex = 43;
            this.lblBestellungsnr.Text = "BestellungsNr:";
            // 
            // frmBestellungBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 732);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.txtKundennr);
            this.Controls.Add(this.lblKundennr);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtProduktnr);
            this.Controls.Add(this.txtBestellungsnr);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblProduktnr);
            this.Controls.Add(this.lblBestellungsnr);
            this.Name = "frmBestellungBearbeiten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestellung Bearbeiten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.TextBox txtKundennr;
        private System.Windows.Forms.Label lblKundennr;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtProduktnr;
        private System.Windows.Forms.TextBox txtBestellungsnr;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblProduktnr;
        private System.Windows.Forms.Label lblBestellungsnr;
    }
}