﻿#pragma checksum "..\..\..\Registration.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6237EC0030A8C6F6B47F4E7D32DC1A4D50A157DF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using АвторизацияПрактикаКозулин;


namespace АвторизацияПрактикаКозулин {
    
    
    /// <summary>
    /// Registration
    /// </summary>
    public partial class Registration : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginTextBox;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailTextBox;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image EyeIcon;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox ConfirmPasswordBox;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ConfirmPasswordTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/АвторизацияПрактикаКозулин;component/registration.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Registration.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Registration.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LoginTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\..\Registration.xaml"
            this.LoginTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 61 "..\..\..\Registration.xaml"
            this.LoginTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EmailTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 73 "..\..\..\Registration.xaml"
            this.EmailTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 73 "..\..\..\Registration.xaml"
            this.EmailTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 85 "..\..\..\Registration.xaml"
            this.PasswordBox.GotFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 85 "..\..\..\Registration.xaml"
            this.PasswordBox.LostFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PasswordTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 88 "..\..\..\Registration.xaml"
            this.PasswordTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 88 "..\..\..\Registration.xaml"
            this.PasswordTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EyeIcon = ((System.Windows.Controls.Image)(target));
            
            #line 90 "..\..\..\Registration.xaml"
            this.EyeIcon.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.EyeIcon_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ConfirmPasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 101 "..\..\..\Registration.xaml"
            this.ConfirmPasswordBox.GotFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 101 "..\..\..\Registration.xaml"
            this.ConfirmPasswordBox.LostFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ConfirmPasswordTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 104 "..\..\..\Registration.xaml"
            this.ConfirmPasswordTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 104 "..\..\..\Registration.xaml"
            this.ConfirmPasswordTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 106 "..\..\..\Registration.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.EyeIcon_MouseLeftButtonUp2);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 110 "..\..\..\Registration.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RegBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

