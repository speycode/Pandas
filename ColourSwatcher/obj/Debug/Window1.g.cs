﻿#pragma checksum "..\..\Window1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4559A149255F1EFD6AF58C61DF2EB911"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ColourSwatcher;
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


namespace ColourSwatcher {
    
    
    /// <summary>
    /// ColourSlider
    /// </summary>
    public partial class ColourSlider : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sldB;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sldG;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sldR;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle result;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Finish;
        
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
            System.Uri resourceLocater = new System.Uri("/ColourSwatcher;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
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
            this.sldB = ((System.Windows.Controls.Slider)(target));
            
            #line 14 "..\..\Window1.xaml"
            this.sldB.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sldB_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sldG = ((System.Windows.Controls.Slider)(target));
            
            #line 15 "..\..\Window1.xaml"
            this.sldG.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sldG_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.sldR = ((System.Windows.Controls.Slider)(target));
            
            #line 16 "..\..\Window1.xaml"
            this.sldR.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sldR_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.result = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.Finish = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Window1.xaml"
            this.Finish.Click += new System.Windows.RoutedEventHandler(this.Finish_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
