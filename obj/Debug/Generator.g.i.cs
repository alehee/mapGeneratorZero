﻿#pragma checksum "..\..\Generator.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "50532E885EA33FEBF70A74586959331C18B7DEF108BD86C58E405C04CCE221A6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

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
using mapGeneratorZero;


namespace mapGeneratorZero {
    
    
    /// <summary>
    /// Generator
    /// </summary>
    public partial class Generator : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Generator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_SettingsGEN;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Generator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B_ChangeSettings;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Generator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label L_ChangeSettingsIndicator;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Generator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B_Generate;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Generator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B_ExportPNG;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Generator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_SettingsSET;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Generator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B_LoadSettings;
        
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
            System.Uri resourceLocater = new System.Uri("/mapGeneratorZero;component/generator.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Generator.xaml"
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
            this.TB_SettingsGEN = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.B_ChangeSettings = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.L_ChangeSettingsIndicator = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.B_Generate = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.B_ExportPNG = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.TB_SettingsSET = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.B_LoadSettings = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\Generator.xaml"
            this.B_LoadSettings.Click += new System.Windows.RoutedEventHandler(this.B_LoadSettings_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

