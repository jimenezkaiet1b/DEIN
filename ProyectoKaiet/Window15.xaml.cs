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
    /// Lógica de interacción para Window15.xaml
    /// </summary>
    public partial class Window15 : Window
    {
        public Window15()
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

        private void Txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    if (textBox.Name == "txtEmail")
                    {
                        textBox.Text = "Email";
                    }
                    else if (textBox.Name == "txtTelefono")
                    {
                        textBox.Text = "Telefono";
                    }
                    else if (textBox.Name == "txtTitulo")
                    {
                        textBox.Text = "Titulo";
                    }
                    else if (textBox.Name == "txtAsunto")
                    {
                        textBox.Text = "Asunto";
                    }
                    
                }
            }
        }


        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("El campo Email no puede estar vacío", "Error");
            }
            else if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El campo Telefono no puede estar vacío", "Error");
            }
            else
            {
                Usuario usuario = new Usuario(txtEmail.Text, txtTelefono.Text, txtTitulo.Text, txtAsunto.Text);
                dataGrid.Items.Add(usuario);
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow nuevaVentana = new MainWindow();
            nuevaVentana.Show();
            this.Close();
        }

    }
}
