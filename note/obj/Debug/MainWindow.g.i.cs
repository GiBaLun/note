﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C208E1675CE764A835F8C6AE7896E11E6C22106A"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
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
using note;


namespace note {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox @new;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox open;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox save;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid big;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid sma;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid line;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid slide;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid bold;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Black;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse White;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox book;
        
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
            System.Uri resourceLocater = new System.Uri("/note;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.@new = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\MainWindow.xaml"
            this.@new.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.new_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.open = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\MainWindow.xaml"
            this.open.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.open_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.save = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\MainWindow.xaml"
            this.save.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.save_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.big = ((System.Windows.Controls.Grid)(target));
            
            #line 22 "..\..\MainWindow.xaml"
            this.big.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.big_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.sma = ((System.Windows.Controls.Grid)(target));
            
            #line 25 "..\..\MainWindow.xaml"
            this.sma.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.sma_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.line = ((System.Windows.Controls.Grid)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.line.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.line_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.slide = ((System.Windows.Controls.Grid)(target));
            
            #line 33 "..\..\MainWindow.xaml"
            this.slide.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.slide_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.bold = ((System.Windows.Controls.Grid)(target));
            
            #line 36 "..\..\MainWindow.xaml"
            this.bold.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.bold_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Black = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 41 "..\..\MainWindow.xaml"
            this.Black.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Black_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.White = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 42 "..\..\MainWindow.xaml"
            this.White.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.White_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.book = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
