#pragma checksum "..\..\..\..\Views\AddBookingWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47231611D934EB289FB8167AB7C50189F66F6A6F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Restik.Views;
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


namespace Restik.Views {
    
    
    /// <summary>
    /// AddBookingWindow
    /// </summary>
    public partial class AddBookingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\Views\AddBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox HallsComboBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Views\AddBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TablesComboBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\AddBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel PlacesWrapPanel;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\AddBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PlacesLabel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\AddBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DateStartTextBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\AddBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LongTextBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\AddBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EventsComboBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Views\AddBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CuisinesComboBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Views\AddBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DishesComboBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Views\AddBookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DishesLabel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Restik;component/views/addbookingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AddBookingWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.HallsComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\..\..\Views\AddBookingWindow.xaml"
            this.HallsComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.HallsComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TablesComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\..\..\Views\AddBookingWindow.xaml"
            this.TablesComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TablesComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PlacesWrapPanel = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 4:
            this.PlacesLabel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DateStartTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.LongTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.EventsComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.CuisinesComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 55 "..\..\..\..\Views\AddBookingWindow.xaml"
            this.CuisinesComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CuisinesComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DishesComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 58 "..\..\..\..\Views\AddBookingWindow.xaml"
            this.DishesComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DishesComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DishesLabel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 62 "..\..\..\..\Views\AddBookingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 63 "..\..\..\..\Views\AddBookingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 64 "..\..\..\..\Views\AddBookingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 65 "..\..\..\..\Views\AddBookingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

