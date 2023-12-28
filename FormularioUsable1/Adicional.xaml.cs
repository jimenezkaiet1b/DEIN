using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para Adicional.xaml
    /// </summary>
    public partial class Adicional : Window
    {
        public Adicional()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Fotografia nuevaVentana = new Fotografia();
            nuevaVentana.Show();
            this.Close();


        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Adicional nuevaVentana = new Adicional();
            nuevaVentana.Show();
            this.Close();
        }
    }
}
