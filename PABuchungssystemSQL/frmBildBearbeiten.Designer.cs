
namespace PABuchungssystemSQL
{
    partial class frmBildBearbeiten
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
            this.picProdukt = new System.Windows.Forms.PictureBox();
            this.txtPfad = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblPfad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProdukt)).BeginInit();
            this.SuspendLayout();
            // 
            // picProdukt
            // 
            this.picProdukt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProdukt.Location = new System.Drawing.Point(225, 41);
            this.picProdukt.Name = "picProdukt";
            this.picProdukt.Size = new System.Drawing.Size(334, 313);
            this.picProdukt.TabIndex = 0;
            this.picProdukt.TabStop = false;
            // 
            // txtPfad
            // 
            this.txtPfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPfad.Location = new System.Drawing.Point(128, 552);
            this.txtPfad.Name = "txtPfad";
            this.txtPfad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPfad.Size = new System.Drawing.Size(493, 26);
            this.txtPfad.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(128, 605);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(123, 42);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblPfad
            // 
            this.lblPfad.AutoSize = true;
            this.lblPfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPfad.Location = new System.Drawing.Point(61, 558);
            this.lblPfad.Name = "lblPfad";
            this.lblPfad.Size = new System.Drawing.Size(48, 20);
            this.lblPfad.TabIndex = 5;
            this.lblPfad.Text = "Pfad:";
            // 
            // frmBildBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 732);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblPfad);
            this.Controls.Add(this.txtPfad);
            this.Controls.Add(this.picProdukt);
            this.Name = "frmBildBearbeiten";
            this.Text = "Bild bearbeiten";
            ((System.ComponentModel.ISupportInitialize)(this.picProdukt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picProdukt;
        private System.Windows.Forms.TextBox txtPfad;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblPfad;
    }
}