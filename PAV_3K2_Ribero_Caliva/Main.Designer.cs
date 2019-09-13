namespace PAV_3K2_Ribero_Caliva
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnClient = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnModelos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClient.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClient.Location = new System.Drawing.Point(51, 35);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(326, 42);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Clientes";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVehiculos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnVehiculos.Location = new System.Drawing.Point(54, 111);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(326, 42);
            this.btnVehiculos.TabIndex = 1;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.UseVisualStyleBackColor = false;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMarcas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMarcas.Location = new System.Drawing.Point(51, 182);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(326, 42);
            this.btnMarcas.TabIndex = 2;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnModelos
            // 
            this.btnModelos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModelos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnModelos.Location = new System.Drawing.Point(51, 258);
            this.btnModelos.Name = "btnModelos";
            this.btnModelos.Size = new System.Drawing.Size(326, 42);
            this.btnModelos.TabIndex = 3;
            this.btnModelos.Text = "Modelos";
            this.btnModelos.UseVisualStyleBackColor = false;
            this.btnModelos.Click += new System.EventHandler(this.btnModelos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(51, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tipos de vehiculos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModelos);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.btnVehiculos);
            this.Controls.Add(this.btnClient);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnModelos;
        private System.Windows.Forms.Button button1;
    }
}