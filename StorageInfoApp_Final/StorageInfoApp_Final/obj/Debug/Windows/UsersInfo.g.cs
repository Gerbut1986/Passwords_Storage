﻿#pragma checksum "..\..\..\Windows\UsersInfo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0368F4B011696E120B23E439A0010A62F39E332D3C09B9516F482118D5425DFE"
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
    /// UsersInfo
    /// </summary>
    public partial class UsersInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\Windows\UsersInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal StorageInfoApp_Final.Windows.UsersInfo loaded;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Windows\UsersInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button close_btn;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Windows\UsersInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _1st_txt;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Windows\UsersInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button edit_btn;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Windows\UsersInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button del_btn;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Windows\UsersInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox list;
        
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
            System.Uri resourceLocater = new System.Uri("/StorageInfoApp_Final;component/windows/usersinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\UsersInfo.xaml"
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
            this.loaded = ((StorageInfoApp_Final.Windows.UsersInfo)(target));
            
            #line 8 "..\..\..\Windows\UsersInfo.xaml"
            this.loaded.Loaded += new System.Windows.RoutedEventHandler(this.loaded_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\Windows\UsersInfo.xaml"
            this.loaded.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.loaded_MouseDown);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\Windows\UsersInfo.xaml"
            this.loaded.MouseMove += new System.Windows.Input.MouseEventHandler(this.loaded_MouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.close_btn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Windows\UsersInfo.xaml"
            this.close_btn.Click += new System.Windows.RoutedEventHandler(this.close_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this._1st_txt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.edit_btn = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\Windows\UsersInfo.xaml"
            this.edit_btn.Click += new System.Windows.RoutedEventHandler(this.edit_btn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.del_btn = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\Windows\UsersInfo.xaml"
            this.del_btn.Click += new System.Windows.RoutedEventHandler(this.del_btn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.list = ((System.Windows.Controls.ListBox)(target));
            
            #line 96 "..\..\..\Windows\UsersInfo.xaml"
            this.list.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.list_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 96 "..\..\..\Windows\UsersInfo.xaml"
            this.list.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.list_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

