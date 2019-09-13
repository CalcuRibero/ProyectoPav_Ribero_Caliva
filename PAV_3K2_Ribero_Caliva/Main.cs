using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV_3K2_Ribero_Caliva.Modulos;

namespace PAV_3K2_Ribero_Caliva
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes();
            cliente.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            var vehiculo = new Vehiculo();
            vehiculo.Show();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            var marca = new Marca();
            marca.Show();
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            var modelo = new Modelo();
            modelo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tipVeh = new TiposDeVehiculos();
            tipVeh.Show();
        }
    }
}
