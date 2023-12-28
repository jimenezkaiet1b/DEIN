using Formulario_de_Kaiet;
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
    /// Lógica de interacción para DatosPersonales.xaml
    /// </summary>
    public partial class DatosPersonales : Window
    {
        private List<Empleado> empleados = new List<Empleado>();
        private ListaEmpleados paAnaidr = new ListaEmpleados();

        public DatosPersonales()
        {
            InitializeComponent();
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
                paAnaidr.dataGrid.Items.Add(empleado);

                Contacto nuevaVentana = new Contacto();
                nuevaVentana.Show();
                this.Close();
            }

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DatosPersonales nuevaVentana = new DatosPersonales();
            nuevaVentana.Show();
            this.Close();
        }
    }
}
