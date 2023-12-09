﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace GestionEmpleados2023
{
    /// <summary>
    /// Lógica de interacción para ListaEmpleados.xaml
    /// </summary>
    public partial class ListaEmpleados : Window
    {
        private GestionEmpleados gestionEmp;
        
        public ListaEmpleados() 
        {
            InitializeComponent();
            gestionEmp = new GestionEmpleados();
            cargarEmpleadosEnDataGrid();
        
        }
        private void cargarEmpleadosEnDataGrid() {
            List<Empleado> empleados = gestionEmp.ObtenerEmpleados();
            dataGrid.ItemsSource = empleados;
        }




    }



}
