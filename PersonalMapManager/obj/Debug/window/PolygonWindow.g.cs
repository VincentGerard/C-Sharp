﻿#pragma checksum "..\..\..\window\PolygonWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C1E8D43253CC3F60AE3D0751552389741125DDB7760658634590DD98D4FF96A6"
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
    /// PolygonWindow
    /// </summary>
    public partial class PolygonWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\window\PolygonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxRemplissage;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\window\PolygonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxContour;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\window\PolygonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxOpacité;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\window\PolygonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderOpacité;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\window\PolygonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxLatitude;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\window\PolygonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxLongitude;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\window\PolygonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAjouter;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\window\PolygonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRetirer;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\window\PolygonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAnnuler;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\window\PolygonWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAppliquer;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\window\PolygonWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/PersonalMapManager;component/window/polygonwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\window\PolygonWindow.xaml"
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
            
            #line 12 "..\..\..\window\PolygonWindow.xaml"
            ((PersonalMapManager.window.PolygonWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboBoxRemplissage = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.ComboBoxContour = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.TextBoxOpacité = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.SliderOpacité = ((System.Windows.Controls.Slider)(target));
            return;
            case 6:
            this.TextBoxLatitude = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TextBoxLongitude = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ButtonAjouter = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.ButtonRetirer = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.ButtonAnnuler = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\window\PolygonWindow.xaml"
            this.ButtonAnnuler.Click += new System.Windows.RoutedEventHandler(this.ButtonAnnuler_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ButtonAppliquer = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\window\PolygonWindow.xaml"
            this.ButtonAppliquer.Click += new System.Windows.RoutedEventHandler(this.ButtonAppliquer_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ButtunOk = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\window\PolygonWindow.xaml"
            this.ButtunOk.Click += new System.Windows.RoutedEventHandler(this.ButtunOk_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

