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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionEmpleados2023
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection conexion;

        public MainWindow()
        {
            InitializeComponent();
            EstablecerConexio();
        }

        private void EstablecerConexio()
        {
            String CadenaConexion = ConfigurationManager.ConnectionStrings["GestionEmpleados2023.Properties.Settings.GestorEmpleadosEjerConnectionString"].ConnectionString;
            conexion = new SqlConnection(CadenaConexion);

        }

        public List<Empleado> ObtenerEmpleados()
        {

            EstablecerConexio();

            String consulta = "SELECT * FROM EMPLEAODS";
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
            }).toList();

            return listaEmpleados;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListaEmpleados empleados = new ListaEmpleados();
            empleados.Show();
            this.Close();
        }
    }

    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string EsUsuario { get; set; }
        public int Edad { get; set; }
    }
}

}
