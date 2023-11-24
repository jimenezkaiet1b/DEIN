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
    /// Lógica de interacción para Window12.xaml
    /// </summary>
    public partial class Window12 : Window
    {
        public Window12()
        {
            InitializeComponent();
        }

        private void ButtonAtras_Click(object sender, RoutedEventArgs e)
        {
            Window13 window13 = new Window13();
            window13.Show();
            this.Close();
        }
        private void ButtonSiguiente_Click(object sender, RoutedEventArgs e) {
            Window14 window14 = new Window14();
            window14.Show();
            this.Close();
        
        }
        private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (sender is Button button)
            {
                // Cambiar el color de fondo cuando el ratón entra
                button.Background = Brushes.Blue;
            }
        }

        private void Button_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (sender is Button button)
            {
                button.Background = Brushes.LightBlue;
            }
        }
    }
}
