   M S B A M L   `   `   `  ����B  >Almacen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Almacen.ViewAlmacen.View  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	        Almacen.View.CategoriaView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Almacen.View     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  CategoriaView��5	   	   $	��450��6   $	��800��6,   .��5
      �  J� RenderTransformOrigin$ 0.364,0.508&�6   $��0,0,0,3q�6/   $	��416��6@   $��Bottom=�6M    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��Description��6   $��1��6(   $��0��65   $��Arial)�6E   $��52,33,70,23q�6X   $ 0.474,-0.259&�6m   �� 5   
   $��1��6   $��1��6   $��30,33,66,23q�6y    �� 
IsReadOnly 6/   �� *IsReadOnlyDescripcion+��6\   �� *Descripcion+6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	CATEGORIA��5      $��2��5      $��Arial)�5         AutoGenerateColumns .  $��10,28,17,175q�5"   )   $��2��6?   $��0��6P   $��1��6`    �� SelectedItem 5      ��  �� Path$ SelectCategoria���5      �� $ 
Categorias�   Columns 5$      4  .System.Windows.Controls.DataGridCheckBoxColumn  5%         MetroDataGridCheckBox1  +System.Windows.Controls.DataGridBoundColumn	   ElementStyle#	 �   5&      
   EditingElementStyle#
 �   5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Seleccionar��5(         Binding 5)      ��  �� RelativeSource ��  �� AncestorType$ DataGridRowL�$ 
IsSelected� �� Mode$ OneWay=�0  *System.Windows.Controls.DataGridTextColumn  5*      $ Codigo��6%      
IsReadOnly .  65   �� *CodigoCategoria+6m     5+      $ Descripcion��6%    .  6:   �� *Descripcion+6n   5-      �� 5/   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��153,156,20,90q�6;   $��1��6R   .+�50      �� $	��Add��69   $	��Add��6e   $��38��6|   $��0,0,0,14q�6�   {�6   �� *IsEnabledAdd+��6G   �� *	Instancia+6�   �� 51      $��Delete��6<   $��Delete��6k   $��0,0,0,14q�6�   {�6   �� *IsEnabledDelete+��6M   �� *	Instancia+6�   �� 52      $��Update��6;   $��Update��6j   $��0,0,0,14q�6�   {�6   �� *IsEnableUpdate+��6L   �� *	Instancia+6�   �� 53      $
��Save��69   $
��Save��6f   $��0,0,0,14q�6~   {�6   �� *IsEnableSave+��6H   �� *	Instancia+6�   �� 54      $��Cancel��6;   $��Cancel��6j   $��0,0,0,14q�6�   {�6   �� *IsEnableCancel+��6L   �� *	Instancia+6�   55      56      57      