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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoKaiet
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UserControl MyUserControl { get; } = new UserControl();
        public MainWindow()
        {
            InitializeComponent(); 
            DataContext = this;
        }
        private void bttCrearTorneo_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            this.Close();
        }

        private void ButtonInfo_Click(object sender, RoutedEventArgs e)
        {
            Window15 window15 = new Window15();
            window15.Show();
            this.Close();

        }

        private void ButtonInscripcion_Click(object sender, RoutedEventArgs e)
        {
            Window6 window6 = new Window6();
            window6.Show();
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
                // Restaurar el color de fondo cuando el ratón sale
                button.ClearValue(Button.BackgroundProperty);
            }
        }
    }
}
