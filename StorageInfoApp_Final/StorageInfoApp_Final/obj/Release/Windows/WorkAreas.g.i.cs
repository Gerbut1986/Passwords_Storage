﻿#pragma checksum "..\..\..\Windows\WorkAreas.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CA83B961E23FD09B530417B95EA63D1DB3683AD597B22D328C0FA0791A21F114"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using StorageInfoApp_Final.Windows;
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


namespace StorageInfoApp_Final.Windows {
    
    
    /// <summary>
    /// WorkAreas
    /// </summary>
    public partial class WorkAreas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        /// <summary>
        /// lbox Name Field
        /// </summary>
        
        #line 39 "..\..\..\Windows\WorkAreas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.ListBox lbox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Windows\WorkAreas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_btn;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Windows\WorkAreas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button edit_btn;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Windows\WorkAreas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete_btn;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Windows\WorkAreas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button users_btn;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Windows\WorkAreas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label welcome_lbl;
        
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
            System.Uri resourceLocater = new System.Uri("/StorageInfoApp_Final;component/windows/workareas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\WorkAreas.xaml"
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
            
            #line 8 "..\..\..\Windows\WorkAreas.xaml"
            ((StorageInfoApp_Final.Windows.WorkAreas)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\Windows\WorkAreas.xaml"
            ((StorageInfoApp_Final.Windows.WorkAreas)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Window_MouseMove);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\Windows\WorkAreas.xaml"
            ((StorageInfoApp_Final.Windows.WorkAreas)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.add_btn = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Windows\WorkAreas.xaml"
            this.add_btn.Click += new System.Windows.RoutedEventHandler(this.add_btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.edit_btn = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Windows\WorkAreas.xaml"
            this.edit_btn.Click += new System.Windows.RoutedEventHandler(this.edit_btn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.delete_btn = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\Windows\WorkAreas.xaml"
            this.delete_btn.Click += new System.Windows.RoutedEventHandler(this.delete_btn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.users_btn = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\Windows\WorkAreas.xaml"
            this.users_btn.Click += new System.Windows.RoutedEventHandler(this.users_btn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.welcome_lbl = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

