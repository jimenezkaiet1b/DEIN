﻿using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Lógica de interacción para BuscarEmpleado.xaml
    /// </summary>
    public partial class BuscarEmpleado : Window
    {

        private GestionEmpleados gestionEmpleados;
        private Empleado empleadoSelect;

        public BuscarEmpleado()
        {
            InitializeComponent();
            gestionEmpleados = new GestionEmpleados();
        }
        private List<Empleado> BuscarEmpleados(string nombre, string apellidos)
        {
            return gestionEmpleados.BuscarPorNombreApellidos(nombre, apellidos);
        }
        private void MostrarResultados(List<Empleado> resultados)
        {
            dataGrid.ItemsSource = resultados;
        }


        private void buscar_Click(object sender, RoutedEventArgs e) {

            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            List<Empleado> resultados = BuscarEmpleados(nombre, apellidos);
            MostrarResultados(resultados);
            if (resultados.Count == 0)
            {
                MessageBox.Show("Empleado no encontrado.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void actualizar_Click(object sender, RoutedEventArgs e)
        {
            empleadoSelect = dataGrid.SelectedItem as Empleado;

            if (empleadoSelect != null)
            {
                AgregarEmpleado actualizarEmpleado = new AgregarEmpleado();
                actualizarEmpleado.empleadoActualizar = empleadoSelect;
                actualizarEmpleado.ShowDialog();
                buscar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione un registro para actualizar.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            var editedRow = e.Row.Item as Empleado;
            var columnIndex = e.Column.DisplayIndex;
            ActualizarEmpleadoEnBaseDeDatos(editedRow);
        }

        private void ActualizarEmpleadoEnBaseDeDatos(Empleado empleadoActualizado)
        {
            if (empleadoActualizado != null)
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["GestionEmpleados2023.Properties.Settings.GestionEmpleadosConnectionString"].ConnectionString))
                    {
                        string consulta = "UPDATE EMPLEADOS SET Nombre = @Nombre, Apellidos = @Apellidos, EsUsuario = @EsUsuario, Edad = @Edad WHERE Id = @Id";

                        using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                        {
                            cmd.Parameters.AddWithValue("@Nombre", empleadoActualizado.Nombre);
                            cmd.Parameters.AddWithValue("@Apellidos", empleadoActualizado.Apellidos);
                            cmd.Parameters.AddWithValue("@EsUsuario", empleadoActualizado.EsUsuario);
                            cmd.Parameters.AddWithValue("@Edad", empleadoActualizado.Edad);
                            conexion.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Empleado actualizado correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar empleado: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        public Empleado ObtenerEmpleadoSeleccionado()
        {
            return empleadoSelect;
        }
    }
}

