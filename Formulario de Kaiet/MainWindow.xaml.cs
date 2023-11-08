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
using Microsoft.Win32;
using System.Windows;

namespace Formulario_de_Kaiet
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Empleado> empleados = new List<Empleado>();
        public MainWindow()
        {
            InitializeComponent();
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
                    // Crear un objeto BitmapImage para mostrar la imagen.
                    BitmapImage bitmapImage = new BitmapImage(new Uri(filePath));

                    // Asignar la imagen al control Image en tu interfaz de usuario.
                    imageControl.Source = bitmapImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
               
                if (textBox == nombreTextBox)
                {
                    nombreErrorTextBlock.Text = "El campo Nombre es obligatorio.";
                }
                else if (textBox == emailTextBox)
                {
                    emailErrorTextBlock.Text = "El campo E-mail es obligatorio.";
                }
                else if (textBox == telefonoTextBox)
                {
                    telefonoErrorTextBlock.Text = "El campo Teléfono es obligatorio.";
                }
            }

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text) || string.IsNullOrWhiteSpace(emailTextBox.Text) || string.IsNullOrWhiteSpace(telefonoTextBox.Text))
            {
                MessageBox.Show("Por favor complete los campos obligatorios.", "Error de validación", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else {
                Empleado nuevoEmpleado = new Empleado {
                    nombre = nombreTextBox.Text,
                    email = emailTextBox.Text,
                    telefono = telefonoTextBox.Text
                };

                empleados.Add(nuevoEmpleado);

                nombreTextBox.Text = string.Empty;
                emailTextBox.Text = string.Empty;
                telefonoTextBox.Text = string.Empty;
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
