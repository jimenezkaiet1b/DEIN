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
    /// Lógica de interacción para Contacto.xaml
    /// </summary>
    public partial class Contacto : Window
    {

        public Contacto()
        {
            InitializeComponent();
            progressBar.Value = 50;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Adicional nuevaVentana = new Adicional();
            nuevaVentana.Show();
            this.Close();


        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DatosPersonales nuevaVentana = new DatosPersonales();
            DatosPersonales.paAnaidr = new ListaEmpleados();
            nuevaVentana.Show();
            this.Close();
        }

        private void Txt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (!String.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = "";
                }
            }
        }

        private void Txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    if (textBox.Name == "direccionBox")
                    {
                        textBox.Text = "Direccion";
                    }
                    else if (textBox.Name == "ciudadBox")
                    {
                        textBox.Text = "Ciudad";
                    }
                    else if (textBox.Name == "provinciaBox")
                    {
                        textBox.Text = "Provincia";
                    }
                    else if (textBox.Name == "codigopostalBox")
                    {
                        textBox.Text = "Codigo postal";
                    }
                    else if (textBox.Name == "paisBox")
                    {
                        textBox.Text = "Pais";
                    }
                }
            }
        }
    }
}
