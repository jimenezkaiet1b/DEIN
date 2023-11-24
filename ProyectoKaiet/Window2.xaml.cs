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
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void ButtonCalen_Click(object sender, RoutedEventArgs e)
        {
            Window11 window11 = new Window11();
            window11.Show();
            this.Close();
        }
        private void ButtonJornada_Click(object sender, RoutedEventArgs e)
        {
            Window8 window8 = new Window8();
            window8.Show();
            this.Close();
        }
        private void ButtonClasi_Click(object sender, RoutedEventArgs e)
        {
            Window10 window10 = new Window10();
            window10.Show();
            this.Close();
        }

        private void ButtonLocaJornada_Click(object sender, RoutedEventArgs e)
        {
            Window8 window8 = new Window8();
            window8.Show();
            this.Close();

        }

        private void ButtonLoca_Click(object sender, RoutedEventArgs e)
        {
            Window13 window13 = new Window13();
            window13.Show();
            this.Close();

        }
    }
}
