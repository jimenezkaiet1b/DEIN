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

namespace ProyectoKaiet
{
    /// <summary>
    /// Lógica de interacción para Window13.xaml
    /// </summary>
    public partial class Window13 : Window
    {
        public Window13()
        {
            InitializeComponent();
        }

        public void ButtonAtras_Click(object sender, RoutedEventArgs e) {
            Window14 window14 = new Window14();
            window14.Show();
            this.Close();
        
        }
        public void ButtonSiguiente_Click(object sender, RoutedEventArgs e)
        {
            Window12 window12 = new Window12();
            window12.Show();
            this.Close();

        }
    }
}
