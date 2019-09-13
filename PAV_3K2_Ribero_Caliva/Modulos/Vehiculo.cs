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

namespace PAV_3K2_Ribero_Caliva.Modulos
{
    public partial class Vehiculo : Form
    {
        public Vehiculo()
        {
            InitializeComponent();
        }

        private void Vehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'playaXibiXibiDataSet.Vehiculos' Puede moverla o quitarla según sea necesario.
            this.vehiculosTableAdapter.Fill(this.playaXibiXibiDataSet.Vehiculos);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var alta = new AltaVehiculos();
            alta.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var modif = new ModificacionVehiculo();
            modif.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
