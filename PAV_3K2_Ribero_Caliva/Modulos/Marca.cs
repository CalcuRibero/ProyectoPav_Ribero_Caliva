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
    public partial class Marca : Form
    {
        public Marca()
        {
            InitializeComponent();
        }

        private void Marca_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'playaXibiXibiDataSet1.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter1.Fill(this.playaXibiXibiDataSet1.Marcas);
            // TODO: esta línea de código carga datos en la tabla 'playaXibiXibiDataSet.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.playaXibiXibiDataSet.Marcas);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var alta = new AltaCliente();
            alta.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var modif = new ModificacionMarca();
            modif.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
