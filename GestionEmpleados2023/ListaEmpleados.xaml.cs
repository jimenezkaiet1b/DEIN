using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GestionEmpleados2023
{
    /// <summary>
    /// Lógica de interacción para ListaEmpleados.xaml
    /// </summary>
    public partial class ListaEmpleados : Window
    {
        private SqlConnection conexion;

        public ListaEmpleados()
        {
            InitializeComponent();
            EstablecerConexio();
        }

        private void EstablecerConexio() {
            String CadenaConexion = ConfigurationManager.ConnectionStrings["GestionEmpleados2023.Properties.Settings.GestorEmpleadosEjerConnectionString"].ConnectionString;
            conexion = new SqlConnection(CadenaConexion);
        
        }

        public List<Empleado> ObtenerEmpleados(){

            EstablecerConexio();

            String consulta = "SELECT * FROM EMPLEAODS";
            DataTable Empleados = new DataTable();

            List<Empleado> listaEmpleados = new List<Empleado>();

            SqlDataAdapter adaptador

        }
























    }

    public class Empleado { 
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string EsUsuario { get; set; }
        public int Edad { get; set; }
    }

}
