
namespace PABuchungssystemSQL
{
    partial class frmBenutzerBearbeiten
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
            this.lblKontotyp = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.lblNachname = new System.Windows.Forms.Label();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.lblVorname = new System.Windows.Forms.Label();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPasswortW = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPasswortW = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.cmbKontotyp = new System.Windows.Forms.ComboBox();
            this.chkbPasswortEinblenden = new System.Windows.Forms.CheckBox();
            this.lblPassShow = new System.Windows.Forms.Label();
            this.lblBenutzerbearbeiten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(433, 598);
            this.btnAbbrechen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(160, 37);
            this.btnAbbrechen.TabIndex = 62;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // lblKontotyp
            // 
            this.lblKontotyp.AutoSize = true;
            this.lblKontotyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontotyp.Location = new System.Drawing.Point(130, 486);
            this.lblKontotyp.Name = "lblKontotyp";
            this.lblKontotyp.Size = new System.Drawing.Size(79, 20);
            this.lblKontotyp.TabIndex = 58;
            this.lblKontotyp.Text = "Kontotyp:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(254, 432);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(339, 26);
            this.txtEmail.TabIndex = 57;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(130, 435);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 56;
            this.lblEmail.Text = "Email:";
            // 
            // txtNachname
            // 
            this.txtNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNachname.Location = new System.Drawing.Point(254, 380);
            this.txtNachname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(339, 26);
            this.txtNachname.TabIndex = 55;
            // 
            // lblNachname
            // 
            this.lblNachname.AutoSize = true;
            this.lblNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNachname.Location = new System.Drawing.Point(130, 382);
            this.lblNachname.Name = "lblNachname";
            this.lblNachname.Size = new System.Drawing.Size(94, 20);
            this.lblNachname.TabIndex = 54;
            this.lblNachname.Text = "Nachname:";
            // 
            // txtVorname
            // 
            this.txtVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVorname.Location = new System.Drawing.Point(254, 326);
            this.txtVorname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(339, 26);
            this.txtVorname.TabIndex = 53;
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVorname.Location = new System.Drawing.Point(130, 328);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(81, 20);
            this.lblVorname.TabIndex = 52;
            this.lblVorname.Text = "Vorname:";
            // 
            // txtPasswort
            // 
            this.txtPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswort.Location = new System.Drawing.Point(254, 206);
            this.txtPasswort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(339, 26);
            this.txtPasswort.TabIndex = 51;
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswort.Location = new System.Drawing.Point(130, 210);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(84, 20);
            this.lblPasswort.TabIndex = 50;
            this.lblPasswort.Text = "Passwort:";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(254, 598);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(160, 37);
            this.btnOK.TabIndex = 49;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPasswortW
            // 
            this.txtPasswortW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswortW.Location = new System.Drawing.Point(254, 270);
            this.txtPasswortW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswortW.Name = "txtPasswortW";
            this.txtPasswortW.Size = new System.Drawing.Size(339, 26);
            this.txtPasswortW.TabIndex = 47;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(254, 153);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(339, 26);
            this.txtLogin.TabIndex = 46;
            // 
            // lblPasswortW
            // 
            this.lblPasswortW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswortW.Location = new System.Drawing.Point(130, 257);
            this.lblPasswortW.Name = "lblPasswortW";
            this.lblPasswortW.Size = new System.Drawing.Size(129, 48);
            this.lblPasswortW.TabIndex = 44;
            this.lblPasswortW.Text = "Passwort wiederholen:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(130, 157);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(55, 20);
            this.lblLogin.TabIndex = 43;
            this.lblLogin.Text = "Login:";
            // 
            // cmbKontotyp
            // 
            this.cmbKontotyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKontotyp.FormattingEnabled = true;
            this.cmbKontotyp.Location = new System.Drawing.Point(254, 482);
            this.cmbKontotyp.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKontotyp.Name = "cmbKontotyp";
            this.cmbKontotyp.Size = new System.Drawing.Size(339, 28);
            this.cmbKontotyp.TabIndex = 63;
            // 
            // chkbPasswortEinblenden
            // 
            this.chkbPasswortEinblenden.AutoSize = true;
            this.chkbPasswortEinblenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbPasswortEinblenden.Location = new System.Drawing.Point(444, 547);
            this.chkbPasswortEinblenden.Name = "chkbPasswortEinblenden";
            this.chkbPasswortEinblenden.Size = new System.Drawing.Size(18, 17);
            this.chkbPasswortEinblenden.TabIndex = 65;
            this.chkbPasswortEinblenden.UseVisualStyleBackColor = true;
            this.chkbPasswortEinblenden.CheckedChanged += new System.EventHandler(this.chkbPasswortEinblenden_CheckedChanged);
            // 
            // lblPassShow
            // 
            this.lblPassShow.AutoSize = true;
            this.lblPassShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassShow.Location = new System.Drawing.Point(250, 544);
            this.lblPassShow.Name = "lblPassShow";
            this.lblPassShow.Size = new System.Drawing.Size(169, 20);
            this.lblPassShow.TabIndex = 64;
            this.lblPassShow.Text = "Passwort einblenden:";
            // 
            // lblBenutzerbearbeiten
            // 
            this.lblBenutzerbearbeiten.BackColor = System.Drawing.Color.SteelBlue;
            this.lblBenutzerbearbeiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenutzerbearbeiten.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBenutzerbearbeiten.Location = new System.Drawing.Point(1, 19);
            this.lblBenutzerbearbeiten.Name = "lblBenutzerbearbeiten";
            this.lblBenutzerbearbeiten.Size = new System.Drawing.Size(788, 49);
            this.lblBenutzerbearbeiten.TabIndex = 66;
            this.lblBenutzerbearbeiten.Text = "Benutzer bearbeiten";
            this.lblBenutzerbearbeiten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmBenutzerBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 732);
            this.Controls.Add(this.lblBenutzerbearbeiten);
            this.Controls.Add(this.chkbPasswortEinblenden);
            this.Controls.Add(this.lblPassShow);
            this.Controls.Add(this.cmbKontotyp);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.lblKontotyp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNachname);
            this.Controls.Add(this.lblNachname);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.lblVorname);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPasswortW);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPasswortW);
            this.Controls.Add(this.lblLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBenutzerBearbeiten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestellsystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Label lblKontotyp;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.Label lblNachname;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPasswortW;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPasswortW;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ComboBox cmbKontotyp;
        private System.Windows.Forms.CheckBox chkbPasswortEinblenden;
        private System.Windows.Forms.Label lblPassShow;
        private System.Windows.Forms.Label lblBenutzerbearbeiten;
    }
}