   M S B A M L   `   `   `  ����F  BGsbRapports, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:GsbRapportsGsbRapports  5   	   "    GsbRapports.RapportVisiteurs   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:GsbRapports     5   	     � Title$  RapportVisiteurs��5   	   $	��450��6"   $	��800��6/   .��5	      � .+�5   
   �� -   5         ��Name$ cmbVisiteurs��5      $
��Left=�6)   $��	40,82,0,0q�6D   $	��Top=�6W   $	��170��6o   $��31��6{   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dtpDate1��5      $
��Left=�6'   $��
40,150,0,0q�6B   $	��Top=�6V   $	��170��6n   $��31��6z     5   
   -   5        $ dtpDate2��5      $
��Left=�6'   $��
40,214,0,0q�6B   $	��Top=�6V   $	��170��6n   $��31��6z   �� 5   
   -   5         ��Name$ valider��5      $��Valider��6#   $
��Left=�65   $��
40,278,0,0q�6P   $	��Top=�6d   $	��170��6|   $��31��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtGridRapports��5         AutoGenerateColumns .  $��273,74,76,82q�6G      AlternatingRowBackground
 ��ح�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Medecin��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 205 67   
   
Foreground

 �   �1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      �� *concatNomPrenomMedecin+6@     5      $
 Date��6%   $		 205 64   

 �   � 5      �� *date+6.     5      $ motif��6%   $		 205 65   

 �   � 5      �� *motif+6/     5      $ Bilan��6%   $		 205 65   

 �   � 5      �� *bilan+6/   5      5      5      