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
        

        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void listaEmpleados_click(object sender, RoutedEventArgs e)
        {
            ListaEmpleados empleados = new ListaEmpleados();
            empleados.Show();
            this.Close();
        }

        private void AgregarEmpleado_click(object sender, RoutedEventArgs e) {
            AgregarEmpleado empleado = new AgregarEmpleado();
            empleado.Show();
            this.Close();
        }

        private void buscar_click(object sender, RoutedEventArgs e) {
            BuscarEmpleado empleado = new BuscarEmpleado();
            empleado.Show();
            this.Close();
            
        }
    }


}


