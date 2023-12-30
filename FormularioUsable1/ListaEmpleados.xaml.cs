using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace FormularioUsable1
{
    /// <summary>
    /// Lógica de interacción para ListaEmpleados.xaml
    /// </summary>
    public partial class ListaEmpleados : Window
    {
        public ListaEmpleados()
        {
            InitializeComponent();

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DatosPersonales nuevaVentana = new DatosPersonales();
            nuevaVentana.Show();
            this.Close();

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();
        }
    }
}
