﻿#pragma checksum "..\..\modifierVisiteursWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2E6E3A44B39590BF9235CCD7F89882EB72A7234F48DD04AE2B557B93BDB648A4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using GsbRapports;
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


namespace GsbRapports {
    
    
    /// <summary>
    /// modifierVisiteursWindow
    /// </summary>
    public partial class modifierVisiteursWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\modifierVisiteursWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtLibVisiteurs;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\modifierVisiteursWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbVisiteur;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\modifierVisiteursWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdVisiteur;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\modifierVisiteursWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVilleVisiteur;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\modifierVisiteursWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAdresseVisiteur;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\modifierVisiteursWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCpVisiteur;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\modifierVisiteursWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnValider;
        
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
            System.Uri resourceLocater = new System.Uri("/GsbRapports;component/modifiervisiteurswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\modifierVisiteursWindow.xaml"
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
            this.txtLibVisiteurs = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.cmbVisiteur = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.txtIdVisiteur = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtVilleVisiteur = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtAdresseVisiteur = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtCpVisiteur = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnValider = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\modifierVisiteursWindow.xaml"
            this.btnValider.Click += new System.Windows.RoutedEventHandler(this.btnValider_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

