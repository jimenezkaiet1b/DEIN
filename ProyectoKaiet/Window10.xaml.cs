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
            ResetButtonColors();
            btnJornada.Foreground = Brushes.LightBlue;


            Window8 window8 = new Window8();
            window8.Show();
            this.Close();


        }



        private void ButtonCale_Click(object sender, RoutedEventArgs e)
        {
            ResetButtonColors();
            btnClasificacion.Foreground = Brushes.LightBlue;

            Window11 window11 = new Window11();
            window11.Show();
            this.Close();
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
