﻿#pragma checksum "..\..\..\Forms\CurrencyConverter.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0A713EE1E251D8AD590D28ADEC99C1FF2A61F1BF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ExchangeRates.Forms;
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


namespace ExchangeRates.Forms {
    
    
    /// <summary>
    /// CurrencyConverter
    /// </summary>
    public partial class CurrencyConverter : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\Forms\CurrencyConverter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox amountTextbox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Forms\CurrencyConverter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fromCombobox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Forms\CurrencyConverter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox toCombobox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Forms\CurrencyConverter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowButton;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Forms\CurrencyConverter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label resultLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/ExchangeRates;component/forms/currencyconverter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Forms\CurrencyConverter.xaml"
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
            this.amountTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\Forms\CurrencyConverter.xaml"
            this.amountTextbox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.AmountTextbox_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\Forms\CurrencyConverter.xaml"
            this.amountTextbox.AddHandler(System.Windows.DataObject.PastingEvent, new System.Windows.DataObjectPastingEventHandler(this.TextBoxPasting));
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\Forms\CurrencyConverter.xaml"
            this.amountTextbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.AmountTextbox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.fromCombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\..\Forms\CurrencyConverter.xaml"
            this.fromCombobox.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.FromCombobox_GotMouseCapture);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\Forms\CurrencyConverter.xaml"
            this.fromCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FromCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.toCombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\..\Forms\CurrencyConverter.xaml"
            this.toCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ToCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ShowButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Forms\CurrencyConverter.xaml"
            this.ShowButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.resultLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

