using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace cc
{
    /// <summary>
    /// Lógica de interacción para AgregarEmpleado.xaml
    /// </summary>
    public partial class AgregarEmpleado : Window
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void AgregarEmpleado_Click(object sender, RoutedEventArgs e) {
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            bool esUsuario = chkEsUsuario.IsChecked ?? false;
            int edad;

            if (int.TryParse(txtEdad.Text, out edad))
            {
                AgregarEmpleadoString(nombre, apellidos, esUsuario, edad);
                Close();

            }
            else {
                MessageBox.Show("Por favor, ingerse una edad valida.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AgregarEmpleadoString(string nombe, string apellidos, bool esUsuario, int edad) {
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["AgregarEmpleadoString.Properties.Settings.GestorEmpleadosEjerConnectionString"].ConnectionString)) {

                string consulta = "INSERT INTO EMPLEADOS (Nombre, Apellidos, EsUsuario, Edad) VALUES (@nombre, @apellidos, @Apellidos, @EsUsuario, @Edad)";

                using (SqlCommand cnd = new SqlCommand(consulta,conexion) ) {
                    cnd.Parameters.AddWithValue("@Nombre", nombe);
                
                
                }
            
            
            }
        
            
        }
    }
    
}
