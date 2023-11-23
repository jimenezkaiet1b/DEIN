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
    /// Lógica de interacción para Window11.xaml
    /// </summary>
    public partial class Window11 : Window
    {
        public Window11()
        {
            InitializeComponent();
            SetTitle();
            CalendarControl.DisplayDateChanged += CalendarControl_DisplayDateChanged;
        }
        private void SetTitle()
        {
            DateTime date = DateTime.Today;
            TitleTextBlock.Text = date.ToString("MMMM yyyy");
        }

        private void CalendarControl_DisplayDateChanged(object sender, CalendarDateChangedEventArgs e)
        {
            SetTitle();
        }
    }
}
