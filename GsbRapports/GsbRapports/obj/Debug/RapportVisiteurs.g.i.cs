<<<<<<< HEAD
﻿#pragma checksum "..\..\RapportVisiteurs.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A5F0506E66C1C0418592D49DD434B7F12124853319D6C4D74209E966B8AC4812"
=======
﻿#pragma checksum "..\..\RapportVisiteurs.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7B598BFFB59D02832521075FEDCD3E4CB0D470AFE990075FBAD0D242FB416890"
>>>>>>> 3a48d5944e1ddc1d00f873dd6957c7ba19a61def
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
    /// RapportVisiteurs
    /// </summary>
    public partial class RapportVisiteurs : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
<<<<<<< HEAD
        #line 10 "..\..\RapportVisiteurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox lstDateUn;
=======
        #line 11 "..\..\RapportVisiteurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbVisiteurs;
>>>>>>> 3a48d5944e1ddc1d00f873dd6957c7ba19a61def
        
        #line default
        #line hidden
        
        
<<<<<<< HEAD
        #line 11 "..\..\RapportVisiteurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox lstDateDeux;
=======
        #line 12 "..\..\RapportVisiteurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpDate1;
>>>>>>> 3a48d5944e1ddc1d00f873dd6957c7ba19a61def
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\RapportVisiteurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
<<<<<<< HEAD
        internal System.Windows.Controls.DataGrid dtGrid;
=======
        internal System.Windows.Controls.DatePicker dtpDate2;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\RapportVisiteurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button valider;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\RapportVisiteurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtGridRapports;
>>>>>>> 3a48d5944e1ddc1d00f873dd6957c7ba19a61def
        
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
            System.Uri resourceLocater = new System.Uri("/GsbRapports;component/rapportvisiteurs.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RapportVisiteurs.xaml"
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
<<<<<<< HEAD
            this.lstDateUn = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.lstDateDeux = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.dtGrid = ((System.Windows.Controls.DataGrid)(target));
=======
            this.cmbVisiteurs = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.dtpDate1 = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.dtpDate2 = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.valider = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\RapportVisiteurs.xaml"
            this.valider.Click += new System.Windows.RoutedEventHandler(this.valider_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dtGridRapports = ((System.Windows.Controls.DataGrid)(target));
>>>>>>> 3a48d5944e1ddc1d00f873dd6957c7ba19a61def
            return;
            }
            this._contentLoaded = true;
        }
    }
}

