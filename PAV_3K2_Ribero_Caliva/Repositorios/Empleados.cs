using PAV_3K2_Ribero_Caliva.Modulos;
using PAV_3K2_Ribero_Caliva.Helper;
using System.Data;

namespace PAV_3K2_Ribero_Caliva.Repositorio
{
    public class RepositorioEmpleados
    {
        private PlayaBD _BD;

        public RepositorioEmpleados()
        {
            _BD = new PlayaBD();
        }
        public DataTable obtenerEmpleados()
        {
            string sqlText = "SELECT * FROM  Empleados";
            return _BD.consulta(sqlText);
        }
        public bool guardar()
        {
            string sqlText = $"INSERT [dbo].[Empleados]([numero de documento] [tipo de documentacion] [nombre] [apellido])"+
                $"VALUE ('{Empleado.[numero de documento].ToString()}', '{Empleado.[tipo de documentacion]}','{Empleado.nombre}', {Empleado.})";
        }
    }
}