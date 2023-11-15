﻿using System;
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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ConexionBBDD_de_Kaiet
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection miConexionsql;
        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.NorthwindConnectionString"].ConnectionString;
            miConexionsql = new SqlConnection(miConexion);
            MuestraArticulos();





        }
        private void MuestraArticulos() {
            string consulta = "SELECT * FROM CLIENTES";
            SqlDataAdapter miAdaptadorSQL = new SqlDataAdapter(consulta, miConexionsql);
            using (miAdaptadorSQL);

            DataTable articulosTabla = new DataTable();
            miAdaptadorSQL.Fill(articulosTabla);

            listaArticulos.DisplayMemberPath = "Id";

            listaArticulos.DisplayMemberPath = "nombre";

            listaArticulos.ItemsSource = articulosTabla.DefaultView;
        }
        

    }
}
