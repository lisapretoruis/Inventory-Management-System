   M S B A M L   `   `   `  ����  InventoryManager!    InventoryManager.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Inventory Manager��5   	   $	��450��6#   $	��800��60   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5	      $
��Auto �6   .+�5   
   �� $��Inventory Manager��6   $��28(�6-   $
��Bold"�6;   $��Center=�6M   $��0,0,0,20q�6j   &   System.Windows.Controls.DataGrid  5   
   -   5        $��InventoryTable��5      $��1��6)      AutoGenerateColumns$ False��66      CanUserAddRows$ False��6R   $��	0,10,0,10q�6i      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Item Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Name+6Q     5      $ Quantity��6%   $
 Auto 6T    67   �� *
Quantity+6T     5      $ Price��6%   $
 Auto 6N    64   �� *Price+6N   5      �� 5   
   $��2��6    �� Orientation$ Vertical=�6"   $��0,10,0,0q�69   .+�5      �� -   5        $��TotalValueText��5      $��Total Value: $0.00��6.   $��16(�6H   $
��Bold"�6V   $��Right=�6h   $��0,0,0,10q�6�   �� 5      $ 
Horizontal=�6   $��Center=�62   .+�5      �� -   5        $��Add Item��5      $	��120��6,   $��5q�68   6C   �� 5      -   5        $��	Edit Item��5      $	��120��6-   $��5q�69   6D   �� 5      -   5        $��Delete Item��5      $	��120��6/   $��5q�6;   6F   �� 5       -   5        $��Save to CSV��5       $	��120��6/   $��5q�6;   6F   �� 5!      -   5        $��
Import CSV��5!      $	��120��6.   $��5q�6:   6E   5"      5#      5$      5%      