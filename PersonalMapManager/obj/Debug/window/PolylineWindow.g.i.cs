﻿#pragma checksum "..\..\..\window\PolylineWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "43982D23C4AC6F16AFE679D9C951EBD09D71CEE7540FF8B728C70DCD80831506"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PersonalMapManager.window;
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


namespace PersonalMapManager.window {
    
    
    /// <summary>
    /// PolylineWindow
    /// </summary>
    public partial class PolylineWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\window\PolylineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxColors;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\window\PolylineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxCoordonnees;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\window\PolylineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAnnuler;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\window\PolylineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAppliquer;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\window\PolylineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtunOk;
        
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
            System.Uri resourceLocater = new System.Uri("/PersonalMapManager;component/window/polylinewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\window\PolylineWindow.xaml"
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
            this.ComboBoxColors = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.ListBoxCoordonnees = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.ButtonAnnuler = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\window\PolylineWindow.xaml"
            this.ButtonAnnuler.Click += new System.Windows.RoutedEventHandler(this.ButtonAnnuler_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonAppliquer = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\window\PolylineWindow.xaml"
            this.ButtonAppliquer.Click += new System.Windows.RoutedEventHandler(this.ButtonAppliquer_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtunOk = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\window\PolylineWindow.xaml"
            this.ButtunOk.Click += new System.Windows.RoutedEventHandler(this.ButtunOk_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

