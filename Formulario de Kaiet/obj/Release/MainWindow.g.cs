// Updated by XamlIntelliSenseFileGenerator 08/11/2023 19:54:30
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "51D4EFF1B8B6533A5762CE4F196025934E9938CB3282251C54A1836B7C73EAC0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Formulario_de_Kaiet;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Formulario_de_Kaiet
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nombreErrorTextBlock;

#line default
#line hidden


#line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock emailErrorTextBlock;

#line default
#line hidden


#line 56 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock telefonoErrorTextBlock;

#line default
#line hidden


#line 69 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageControl;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Formulario de Kaiet;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.nombreTextBox = ((System.Windows.Controls.TextBox)(target));

#line 38 "..\..\MainWindow.xaml"
                    this.nombreTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.Txt_GotFocus);

#line default
#line hidden

#line 38 "..\..\MainWindow.xaml"
                    this.nombreTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.LostFocus);

#line default
#line hidden
                    return;
                case 2:
                    this.nombreErrorTextBlock = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 3:
                    this.apellidosTextBox = ((System.Windows.Controls.TextBox)(target));

#line 43 "..\..\MainWindow.xaml"
                    this.apellidosTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.Txt_GotFocus);

#line default
#line hidden

#line 43 "..\..\MainWindow.xaml"
                    this.apellidosTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.LostFocus);

#line default
#line hidden
                    return;
                case 4:
                    this.emailTextBox = ((System.Windows.Controls.TextBox)(target));

#line 48 "..\..\MainWindow.xaml"
                    this.emailTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.Txt_GotFocus);

#line default
#line hidden

#line 48 "..\..\MainWindow.xaml"
                    this.emailTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.LostFocus);

#line default
#line hidden
                    return;
                case 5:
                    this.emailErrorTextBlock = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 6:
                    this.telefonoTextBox = ((System.Windows.Controls.TextBox)(target));

#line 54 "..\..\MainWindow.xaml"
                    this.telefonoTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.Txt_GotFocus);

#line default
#line hidden

#line 54 "..\..\MainWindow.xaml"
                    this.telefonoTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.LostFocus);

#line default
#line hidden
                    return;
                case 7:
                    this.telefonoErrorTextBlock = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 8:

#line 64 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);

#line default
#line hidden
                    return;
                case 9:

#line 68 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);

#line default
#line hidden
                    return;
                case 10:
                    this.imageControl = ((System.Windows.Controls.Image)(target));
                    return;
                case 11:

#line 74 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);

#line default
#line hidden
                    return;
                case 12:

#line 98 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);

#line default
#line hidden
                    return;
                case 13:

#line 99 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);

#line default
#line hidden
                    return;
                case 14:

#line 102 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.DataGrid)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

