﻿#pragma checksum "..\..\..\Windows\Register.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0F0D6943214386DE086C35123A0445B6CFCF87F3BAA5A7CE42F4A61A3A1345DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Storage_Admin_App.Windows;
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


namespace Storage_Admin_App.Windows {
    
    
    /// <summary>
    /// Register
    /// </summary>
    public partial class Register : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name_txt;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fname_txt;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox age_txt;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox login_txt;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox paswd_txt;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phone_txt;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email_txt;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button text_btn;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox role_txt;
        
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
            System.Uri resourceLocater = new System.Uri("/Storage_Admin_App;component/windows/register.xaml", System.UriKind.Relative);
            
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
            this.name_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.fname_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.age_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.login_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.paswd_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.phone_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.email_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.text_btn = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Windows\Register.xaml"
            this.text_btn.Click += new System.Windows.RoutedEventHandler(this.text_btn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.role_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

