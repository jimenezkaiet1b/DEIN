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
    /// Lógica de interacción para GestionEmpleados.xaml
    /// </summary>
    /// 
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public bool EsUsuario { get; set; }
        public int Edad { get; set; }
    }

    public partial class GestionEmpleados : Window
    {
        private SqlConnection conexion;
        public GestionEmpleados()
        {
            InitializeComponent();
            EstablecerConexio();
           
        }

        private void EstablecerConexio()
        {
            string CadenaConexion = ConfigurationManager.ConnectionStrings["GestionEmpleados2023.Properties.Settings.GestionEmpleadosConnectionString"].ConnectionString;
            conexion = new SqlConnection(CadenaConexion);

        }

        public List<Empleado> ObtenerEmpleados()
        {
            EstablecerConexio();
            string consulta = "SELECT * FROM EMPLEADOS";
            DataTable Empleados = new DataTable();

            List<Empleado> listaEmpleados = new List<Empleado>();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

            using (adaptador)
            {
                adaptador.Fill(Empleados);
            }

            listaEmpleados = Empleados.AsEnumerable().Select(row => new Empleado
            {
                Nombre = row.Field<string>("Nombre"),
                Apellidos = row.Field<string>("Apellidos"),
                EsUsuario = (row["EsUsuario"] != DBNull.Value) ? row.Field<bool>("EsUsuario") : false,
                Edad = row.Field<int>("Edad")

            }).ToList();

            return listaEmpleados;

        }

        public List<Empleado> BuscarPorNombreApellidos(string nombre, string apellidos)
        {
            EstablecerConexio();

            string consulta = "SELECT * FROM EMPLEADOS WHERE Nombre LIKE @Nombre AND Apellidos LIKE @Apellidos";
            DataTable Empleados = new DataTable();

            List<Empleado> listaEmpleados = new List<Empleado>();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

            using (adaptador)
            {
                adaptador.SelectCommand.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");
                adaptador.SelectCommand.Parameters.AddWithValue("@Apellidos", "%" + apellidos + "%");

                adaptador.Fill(Empleados);
            }

            listaEmpleados = Empleados.AsEnumerable().Select(row => new Empleado
            {
                Nombre = row.Field<string>("Nombre"),
                Apellidos = row.Field<string>("Apellidos"),
                EsUsuario = (row["EsUsuario"] != DBNull.Value) ? row.Field<bool>("EsUsuario") : false,
                Edad = row.Field<int>("Edad")

            }).ToList();

            return listaEmpleados;
        }
    }
}
