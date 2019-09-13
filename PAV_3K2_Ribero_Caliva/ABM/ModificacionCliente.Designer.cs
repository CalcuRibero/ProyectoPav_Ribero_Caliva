namespace PAV_3K2_Ribero_Caliva.ABM
{
    partial class ModificacionCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificacionCliente));
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTipoDoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTipoDoc.Location = new System.Drawing.Point(4, 80);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(211, 24);
            this.lblTipoDoc.TabIndex = 27;
            this.lblTipoDoc.Text = "Tipo de documentacion";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPatente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPatente.Location = new System.Drawing.Point(4, 213);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(212, 24);
            this.lblPatente.TabIndex = 26;
            this.lblPatente.Text = "Numero de documento ";
            // 
            // cmbModelo
            // 
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(4, 107);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(392, 21);
            this.cmbModelo.TabIndex = 25;
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPatente.Location = new System.Drawing.Point(4, 240);
            this.txtPatente.MaxLength = 7;
            this.txtPatente.Multiline = true;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(392, 32);
            this.txtPatente.TabIndex = 24;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOK.Location = new System.Drawing.Point(220, 369);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 30);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(326, 369);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 30);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // ModificacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnVolver);
            this.Name = "ModificacionCliente";
            this.Text = "ModificacionCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnVolver;
    }
}