﻿#pragma checksum "..\..\Window10.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FA62A757ECB5F6BD9B44A9E1A692A9F5E6EEA2EE27E6AC362B6767EC863CCBF6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ProyectoKaiet;
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


namespace ProyectoKaiet {
    
    
    /// <summary>
    /// Window10
    /// </summary>
    public partial class Window10 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Window10.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView EquiposListView;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Window10.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnJornada;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Window10.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClasificacion;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Window10.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEquipos;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Window10.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCalendario;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProyectoKaiet;component/window10.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window10.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.EquiposListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.btnJornada = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\Window10.xaml"
            this.btnJornada.Click += new System.Windows.RoutedEventHandler(this.ButtonJornada_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnClasificacion = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Window10.xaml"
            this.btnClasificacion.Click += new System.Windows.RoutedEventHandler(this.ButtonClasi_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnEquipos = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.btnCalendario = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\Window10.xaml"
            this.btnCalendario.Click += new System.Windows.RoutedEventHandler(this.ButtonCale_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

