using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_3K2_Ribero_Caliva.ABM;

namespace PAV_3K2_Ribero_Caliva
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'playaXibiXibiDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter1.Fill(this.playaXibiXibiDataSet1.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'playaXibiXibiDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.playaXibiXibiDataSet.Clientes);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var alta = new AltaCliente();
            alta.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var modif = new ModificacionCliente();
            modif.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
