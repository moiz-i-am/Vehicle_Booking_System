﻿#pragma checksum "..\..\..\UI\ManagerDashboard.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9C3D2B2CDC491C23A638E14704AE472BE4F5EAB2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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


namespace Vehicles_Reservation_System.UI {
    
    
    /// <summary>
    /// ManagerDashboard
    /// </summary>
    public partial class ManagerDashboard : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\UI\ManagerDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Vehicles_Reservation_System.UI.ManagerDashboard ManagerDashboard_Window;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\UI\ManagerDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLoggedIn;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\UI\ManagerDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\UI\ManagerDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewAdmins;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\UI\ManagerDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewEntryOps;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\UI\ManagerDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGenerateReport;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\UI\ManagerDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewCars;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\UI\ManagerDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewBookings;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\UI\ManagerDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAdminMessage;
        
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
            System.Uri resourceLocater = new System.Uri("/Vehicles Reservation System;component/ui/managerdashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\ManagerDashboard.xaml"
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
            this.ManagerDashboard_Window = ((Vehicles_Reservation_System.UI.ManagerDashboard)(target));
            
            #line 7 "..\..\..\UI\ManagerDashboard.xaml"
            this.ManagerDashboard_Window.Loaded += new System.Windows.RoutedEventHandler(this.ManagerDashboard_Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblLoggedIn = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\UI\ManagerDashboard.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnViewAdmins = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\UI\ManagerDashboard.xaml"
            this.btnViewAdmins.Click += new System.Windows.RoutedEventHandler(this.btnViewAdmins_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnViewEntryOps = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\UI\ManagerDashboard.xaml"
            this.btnViewEntryOps.Click += new System.Windows.RoutedEventHandler(this.btnViewEntryOps_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnGenerateReport = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\UI\ManagerDashboard.xaml"
            this.btnGenerateReport.Click += new System.Windows.RoutedEventHandler(this.btnGenerateReport_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnViewCars = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\UI\ManagerDashboard.xaml"
            this.btnViewCars.Click += new System.Windows.RoutedEventHandler(this.btnViewCars_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnViewBookings = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\UI\ManagerDashboard.xaml"
            this.btnViewBookings.Click += new System.Windows.RoutedEventHandler(this.btnViewBookings_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lblAdminMessage = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
