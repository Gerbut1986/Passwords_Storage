﻿#pragma checksum "..\..\..\Windows\Register.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0975760D542FA78AC5AD7514813326DF832581525F1564271D90EA85BE62B7E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using StorageInfoApp_Final;
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
    /// Register
    /// </summary>
    public partial class Register : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button close_btn;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fName_txt;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lName_txt;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox age_txt;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox login_txt;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pass_txt;
        
        #line default
        #line hidden
        
        
        #line 226 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phone_txt;
        
        #line default
        #line hidden
        
        
        #line 258 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email_txt;
        
        #line default
        #line hidden
        
        
        #line 290 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox role_txt;
        
        #line default
        #line hidden
        
        
        #line 322 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button reg_btn;
        
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
            System.Uri resourceLocater = new System.Uri("/StorageInfoApp_Final;component/windows/register.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\Register.xaml"
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
            
            #line 12 "..\..\..\Windows\Register.xaml"
            ((StorageInfoApp_Final.Windows.Register)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.close_btn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Windows\Register.xaml"
            this.close_btn.Click += new System.Windows.RoutedEventHandler(this.close_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.fName_txt = ((System.Windows.Controls.TextBox)(target));
            
            #line 81 "..\..\..\Windows\Register.xaml"
            this.fName_txt.GotFocus += new System.Windows.RoutedEventHandler(this.fName_txt_GotFocus);
            
            #line default
            #line hidden
            
            #line 81 "..\..\..\Windows\Register.xaml"
            this.fName_txt.LostFocus += new System.Windows.RoutedEventHandler(this.fName_txt_LostFocus);
            
            #line default
            #line hidden
            
            #line 81 "..\..\..\Windows\Register.xaml"
            this.fName_txt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.fName_txt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lName_txt = ((System.Windows.Controls.TextBox)(target));
            
            #line 113 "..\..\..\Windows\Register.xaml"
            this.lName_txt.GotFocus += new System.Windows.RoutedEventHandler(this.lName_txt_GotFocus);
            
            #line default
            #line hidden
            
            #line 113 "..\..\..\Windows\Register.xaml"
            this.lName_txt.LostFocus += new System.Windows.RoutedEventHandler(this.lName_txt_LostFocus);
            
            #line default
            #line hidden
            
            #line 113 "..\..\..\Windows\Register.xaml"
            this.lName_txt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.lName_txt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.age_txt = ((System.Windows.Controls.TextBox)(target));
            
            #line 144 "..\..\..\Windows\Register.xaml"
            this.age_txt.GotFocus += new System.Windows.RoutedEventHandler(this.age_txt_GotFocus);
            
            #line default
            #line hidden
            
            #line 144 "..\..\..\Windows\Register.xaml"
            this.age_txt.LostFocus += new System.Windows.RoutedEventHandler(this.age_txt_LostFocus);
            
            #line default
            #line hidden
            
            #line 144 "..\..\..\Windows\Register.xaml"
            this.age_txt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.age_txt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.login_txt = ((System.Windows.Controls.TextBox)(target));
            
            #line 175 "..\..\..\Windows\Register.xaml"
            this.login_txt.GotFocus += new System.Windows.RoutedEventHandler(this.login_txt_GotFocus);
            
            #line default
            #line hidden
            
            #line 175 "..\..\..\Windows\Register.xaml"
            this.login_txt.LostFocus += new System.Windows.RoutedEventHandler(this.login_txt_LostFocus);
            
            #line default
            #line hidden
            
            #line 175 "..\..\..\Windows\Register.xaml"
            this.login_txt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.login_txt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.pass_txt = ((System.Windows.Controls.TextBox)(target));
            
            #line 207 "..\..\..\Windows\Register.xaml"
            this.pass_txt.GotFocus += new System.Windows.RoutedEventHandler(this.pass_txt_GotFocus);
            
            #line default
            #line hidden
            
            #line 207 "..\..\..\Windows\Register.xaml"
            this.pass_txt.LostFocus += new System.Windows.RoutedEventHandler(this.pass_txt_LostFocus);
            
            #line default
            #line hidden
            
            #line 207 "..\..\..\Windows\Register.xaml"
            this.pass_txt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.pass_txt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.phone_txt = ((System.Windows.Controls.TextBox)(target));
            
            #line 239 "..\..\..\Windows\Register.xaml"
            this.phone_txt.GotFocus += new System.Windows.RoutedEventHandler(this.phone_txt_GotFocus);
            
            #line default
            #line hidden
            
            #line 239 "..\..\..\Windows\Register.xaml"
            this.phone_txt.LostFocus += new System.Windows.RoutedEventHandler(this.phone_txt_LostFocus);
            
            #line default
            #line hidden
            
            #line 239 "..\..\..\Windows\Register.xaml"
            this.phone_txt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.phone_txt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.email_txt = ((System.Windows.Controls.TextBox)(target));
            
            #line 271 "..\..\..\Windows\Register.xaml"
            this.email_txt.GotFocus += new System.Windows.RoutedEventHandler(this.email_txt_GotFocus);
            
            #line default
            #line hidden
            
            #line 271 "..\..\..\Windows\Register.xaml"
            this.email_txt.LostFocus += new System.Windows.RoutedEventHandler(this.email_txt_LostFocus);
            
            #line default
            #line hidden
            
            #line 271 "..\..\..\Windows\Register.xaml"
            this.email_txt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.email_txt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.role_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.reg_btn = ((System.Windows.Controls.Button)(target));
            
            #line 322 "..\..\..\Windows\Register.xaml"
            this.reg_btn.Click += new System.Windows.RoutedEventHandler(this.reg_btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

