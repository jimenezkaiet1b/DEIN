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
                    BitmapImage bitmapImage = new BitmapImage(new Uri(filePath));
                    imageControl.Source = bitmapImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
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


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (nombreBox.Text == "")
            {
                MessageBox.Show("El campo Nombre no puede estar vacío", "Error");
            }
            else if (emailBox.Text == "")
            {
                MessageBox.Show("El campo E-mail no puede estar vacío", "Error");
            }
            else if (telefonoBox.Text == "")
            {
                MessageBox.Show("El campo Telefono no puede estar vacío", "Error");
            }
            else
            {
                Empleado empleado = new Empleado(nombreBox.Text, apellidosBox.Text, emailBox.Text, telefonoBox.Text);
                dataGrid.Items.Add(empleado);
            }

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow nuevaVentana = new MainWindow();
            nuevaVentana.Show();
            this.Close();
        }

    }
}



        
    

