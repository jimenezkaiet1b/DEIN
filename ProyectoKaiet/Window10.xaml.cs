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
    /// Lógica de interacción para Window10.xaml
    /// </summary>
    public partial class Window10 : Window
    {
        public Window10()
        {
            InitializeComponent();

            List<Equipo> equipos = new List<Equipo>
            {
                new Equipo { Nombre = "Equipo 1", PuntosJugados = 5075, PuntosGanados = 5075, Goles = "12:2" },
                new Equipo { Nombre = "Equipo 2", PuntosJugados = 5075, PuntosGanados = 5075, Goles = "12:2" },
               
            };

            EquiposListView.ItemsSource = equipos;
        }

        private void ButtonJornada_Click(object sender, RoutedEventArgs e)
        {
            ResetButtonColors(); // Restaurar colores de todos los botones
            btnJornada.Foreground = Brushes.LightBlue; // Cambiar color del texto al hacer clic
        }

        private void ButtonClasi_Click(object sender, RoutedEventArgs e)
        {
            ResetButtonColors(); // Restaurar colores de todos los botones
            btnClasificacion.Foreground = Brushes.LightBlue; // Cambiar color del texto al hacer clic
        }

        // Otros métodos de manejo de clics para los demás botones

        private void ResetButtonColors()
        {
            // Restaurar colores de todos los botones a negro
            btnJornada.Foreground = Brushes.Black;
            btnClasificacion.Foreground = Brushes.Black;
            btnEquipos.Foreground = Brushes.Black;
            btnCalendario.Foreground = Brushes.Black;
        }
    }

    public class Equipo
    {
        public string Nombre { get; set; }
        public int PuntosJugados { get; set; }
        public int PuntosGanados { get; set; }
        public string Goles { get; set; }
    }
}
