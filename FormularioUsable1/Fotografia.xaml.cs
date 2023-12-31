using Microsoft.Win32;
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
    /// Lógica de interacción para Fotografia.xaml
    /// </summary>
    public partial class Fotografia : Window
    {

        private ListaEmpleados ListaEmpleados = DatosPersonales.paAnaidr;
        public Fotografia()
        {
            InitializeComponent();
            progressBar.Value = 100;


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //////////////////////////////////////////////////
            
            ListaEmpleados.Show();
            this.Close();


        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Adicional nuevaVentana = new Adicional();
            nuevaVentana.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == true)
            {

                string filePath = openFileDialog.FileName;
                try
                {
                    BitmapImage bitmapImage = new BitmapImage(new Uri(filePath));
                    imageControl.Source = bitmapImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }
    }
}
