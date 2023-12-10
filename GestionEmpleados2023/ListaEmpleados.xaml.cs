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
        private GestionEmpleados gestionEmp;
        
        public ListaEmpleados() 
        {
            InitializeComponent();
            gestionEmp = new GestionEmpleados();
            cargarEmpleadosEnDataGrid();
        
        }
        private void cargarEmpleadosEnDataGrid() {
            List<Empleado> empleados = gestionEmp.ObtenerEmpleados();
            dataGrid.ItemsSource = empleados;
        }


        private void borrarEmpleado(string nombre)
        {
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["GestionEmpleados2023.Properties.Settings.GestionEmpleadosConnectionString"].ConnectionString))
            {
                string consulta = "DELETE FROM EMPLEADOS WHERE nombre = @Nombre";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    try
                    {
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar empleado: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        private void eliminar_click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = dataGrid.SelectedIndex;

            if (selectedIndex >= 0)
            {
                Empleado empleadoSeleccionado = dataGrid.SelectedItem as Empleado;
                borrarEmpleado(empleadoSeleccionado.Nombre);

                cargarEmpleadosEnDataGrid();
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }



}



