﻿#pragma checksum "..\..\..\..\Pages\CreatePassword.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00EF54F8175BA05E00225DBA627D09ACA693D3BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using OlibPasswordManager.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace OlibPasswordManager.Pages {
    
    
    /// <summary>
    /// CreatePassword
    /// </summary>
    public partial class CreatePassword : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Pages\CreatePassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Pages\CreatePassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNameAccount;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Pages\CreatePassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Pages\CreatePassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPasswordCollapsed;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\CreatePassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbHide;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Pages\CreatePassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar pbHard;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Pages\CreatePassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtWebSite;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Pages\CreatePassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNote;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OlibPasswordManager;V1.0.0.90;component/pages/createpassword.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\CreatePassword.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtNameAccount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 35 "..\..\..\..\Pages\CreatePassword.xaml"
            this.txtPassword.PasswordChanged += new System.Windows.RoutedEventHandler(this.txtPassword_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtPasswordCollapsed = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\..\Pages\CreatePassword.xaml"
            this.txtPasswordCollapsed.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtPasswordCollapsed_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 38 "..\..\..\..\Pages\CreatePassword.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenPasswordGeneration);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cbHide = ((System.Windows.Controls.CheckBox)(target));
            
            #line 39 "..\..\..\..\Pages\CreatePassword.xaml"
            this.cbHide.Checked += new System.Windows.RoutedEventHandler(this.CollapsedPassword);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\..\Pages\CreatePassword.xaml"
            this.cbHide.Unchecked += new System.Windows.RoutedEventHandler(this.CollapsedPassword);
            
            #line default
            #line hidden
            return;
            case 7:
            this.pbHard = ((System.Windows.Controls.ProgressBar)(target));
            
            #line 43 "..\..\..\..\Pages\CreatePassword.xaml"
            this.pbHard.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.pbHard_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtWebSite = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtNote = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 63 "..\..\..\..\Pages\CreatePassword.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SavePasswordInList);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 64 "..\..\..\..\Pages\CreatePassword.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseCreatePassword);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

