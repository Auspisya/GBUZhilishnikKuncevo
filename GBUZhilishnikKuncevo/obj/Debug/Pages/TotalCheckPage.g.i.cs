﻿#pragma checksum "..\..\..\Pages\TotalCheckPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1C34D2A91390E094019DBFFD0C734C57BA199014CAC1FCCF7C36025F96F0D941"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GBUZhilishnikKuncevo.Pages;
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


namespace GBUZhilishnikKuncevo.Pages {
    
    
    /// <summary>
    /// TotalCheckPage
    /// </summary>
    public partial class TotalCheckPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Pages\TotalCheckPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbSearch;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\TotalCheckPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSearch;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\TotalCheckPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRefresh;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\TotalCheckPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddTotalCheck;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Pages\TotalCheckPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataTotalCheck;
        
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
            System.Uri resourceLocater = new System.Uri("/GBUZhilishnikKuncevo;component/pages/totalcheckpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\TotalCheckPage.xaml"
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
            this.TxbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\Pages\TotalCheckPage.xaml"
            this.TxbSearch.GotFocus += new System.Windows.RoutedEventHandler(this.TxbSearch_GotFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Pages\TotalCheckPage.xaml"
            this.BtnSearch.Click += new System.Windows.RoutedEventHandler(this.BtnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnRefresh = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Pages\TotalCheckPage.xaml"
            this.BtnRefresh.Click += new System.Windows.RoutedEventHandler(this.BtnRefresh_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnAddTotalCheck = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Pages\TotalCheckPage.xaml"
            this.BtnAddTotalCheck.Click += new System.Windows.RoutedEventHandler(this.BtnAddTotalCheck_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DataTotalCheck = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

