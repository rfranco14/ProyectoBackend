   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   B >Almacen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Almacen.ViewAlmacen.View 5   	      Almacen.View.ProductoView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   ,localclr-namespace:Almacen.View     5   	     � Title$  ProductoView��5	   	   $	��550��6   $
��1406��6+   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��232* �6   6.   �� 5      $
��249* �6   6.   �� 5      $
��906* �6   6.   �� 5      $	��11* �6   .+�5   
   �� $��Codigo Categoria��6   $��1��6+   $��0��68   $��Arial)�6H   $��
52,26,0,23q�6\    J� RenderTransformOrigin$ 0.474,-0.259&�6p   $
��Left=�6�   $	��274��6�   $��2��6�   �� 5   
   $��1��6   $��1��6   $��66,26,21,21q�6�    �� 
IsReadOnly 6/   �� *IsReadOnlyCodigoCategoria+��6`   �� *CodigoCategoria+6�   �� 5   
   $��Codigo Empaque��6   $��2��6)   $��0��66   $��Arial)�6F   $��
52,26,0,23q�6Z   $ 0.474,-0.259&�6n   $
��Left=�6�   $	��274��6�   $��2��6�   �� 5    
   $��2��6   $��1��6   $��66,26,21,21q�6}    6/   �� *IsReadOnlyCodigoEmpaque+��6^   �� *CodigoEmpaque+6�   �� 5"   
   $��Descripcion��6   $��3��6&   $��0��63   $��Arial)�6C   $��
52,26,0,23q�6W   $ 0.474,-0.259&�6k   $
��Left=�6�   $	��274��6�   $��2��6�   �� 5#   
   $��3��6   $��1��6   $��66,26,21,21q�6y    6/   �� *IsReadOnlyDescripcion+��6\   �� *Descripcion+6�   �� 5%   
   $��Imagen��6   $��4��6!   $��0��6.   $��Arial)�6>   $��
52,26,0,23q�6R   $ 0.474,-0.259&�6f   $
��Left=�6�   $	��274��6�   $��2��6�   �� 5&   
   $��4��6   $��1��6   $��66,26,21,21q�6o    6/   �� *IsReadOnlyImagen+��6W   �� *Imagen+6�   &   System.Windows.Controls.DataGrid  5(   
   -   5        $��PRODUCTO��5(      $��5��5,      $��Arial)�5.         AutoGenerateColumns .  $��
10,28,0,61q�50   /   $��0��6C   $��3��6S    �� SelectedItem 5)      ��  �� Path$ SelectProducto���5*      �� $ Producto�   Columns 51      4  .System.Windows.Controls.DataGridCheckBoxColumn  52         MetroDataGridCheckBox1  +System.Windows.Controls.DataGridBoundColumn	   ElementStyle#	 �   53      
   EditingElementStyle#
 �   54      ,  &System.Windows.Controls.DataGridColumn   Header$ Seleccionar��55         Binding 56      ��  �� RelativeSource ��  �� AncestorType$ DataGridRowL�$ 
IsSelected� �� Mode$ OneWay=�0  *System.Windows.Controls.DataGridTextColumn  57      $ Codigo��6%      
IsReadOnly .  65   �� *CodigoProducto+6l     58      $ Codigo Categoria��6%    .  6?   �� *CodigoCategoria+6w     59      $ Codigo Empaque��6%    .  6=   �� *CodigoEmpaque+6s     5:      $ Descripcion��6%    .  6:   �� *Descripcion+6n     5;      $ Precio Unitario��6%    .  6>   �� *PrecioUnitario+6u     5<      $ Precio Por Docena��6%    .  6@   �� *PrecioPorDocena+6x     5=      $ Precio Por Mayor��6%    .  6?   �� *PrecioPorMayor+6v     5>      $ 
Existencia��6%    .  69   �� *
Existencia+6l     5?      $ Imagen��6%    .  65   �� *Imagen+6d   5A      �� 5B   
   $��5��6    �� Orientation$ 
Horizontal=�6"   $��525,101,122,10q�6;   $��2��6S   .+�5C      �� $	��Add��68   $	��Add��6d   $��38��6{   $��0,0,0,14q�6�   {�6   �� *IsEnabledAdd+��6F   �� *	Instancia+6�   �� 5D      $��Delete��6;   $��Delete��6j   $��0,0,0,14q�6�   {�6   �� *IsEnabledDelete+��6L   �� *	Instancia+6�   �� 5E      $��Update��6:   $��Update��6i   $��0,0,0,14q�6�   {�6   �� *IsEnableUpdate+��6K   �� *	Instancia+6�   �� 5F      $
��Save��68   $
��Save��6e   $��0,0,0,14q�6}   {�6   �� *IsEnableSave+��6G   �� *	Instancia+6}   �� 5G      $��Cancel��6:   $��Cancel��6i   $��0,0,0,14q�6�   {�6   �� *IsEnableCancel+��6K   �� *	Instancia+6�   5H      5L      5M      