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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoKaiet
{
    /// <summary>
    /// Lógica de interacción para Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        SqlConnection miConexionsql;
        public Window4()
        {
            string miConexion = ConfigurationManager.ConnectionStrings["namespace ProyectoKaiet.Settings.MultiDeportesConnectionString"].ConnectionString;
            miConexionsql = new SqlConnection(miConexion);
            MuestraArticulos();
        }

        private void MuestraArticulos()
        {
            string consulta = "SELECT * FROM empleados";
            SqlDataAdapter miAdaptadorSQL = new SqlDataAdapter(consulta, miConexionsql);
            using (miAdaptadorSQL)
            {

                DataTable articulosTabla = new DataTable();
                miAdaptadorSQL.Fill(articulosTabla);

                usurname.DisplayMemberPath = "nombreUsuario";

                pwd.DisplayMemberPath = "password";

                listaArticulos.ItemsSource = articulosTabla.DefaultView;
            }
        }
    }
    private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
