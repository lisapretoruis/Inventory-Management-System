   M S B A M L   `   `   `  ����  InventoryManager$    InventoryManager.AddItemDialog   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Add/Edit Item��5   	   $	��300��6   $	��400��6,   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5	      $
��Auto �6   .+�5   
   �� $��Add/Edit Item��6   $��20(�6)   $
��Bold"�67   $��Center=�6I   $��0,0,0,10q�6f   � 5   
   $��1��6   $��	0,10,0,10q�6    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      �� $��
Item Name:��6   $��0��6*   $��0��67   $��Center=�6G   $��	0,0,10,10q�6b   �� 5      -   5        $��ItemNameInput��5      $��0��6+   $��1��68   $��0,0,0,10q�6H   �� 5       $��	Quantity:��6   $��1��6)   $��0��66   $��Center=�6F   $��	0,0,10,10q�6a   �� 5!      -   5        $��ItemQuantityInput��5!      $��1��6/   $��1��6<   $��0,0,0,10q�6L   �� 5$      $��Price:��6   $��2��6&   $��0��63   $��Center=�6C   $��	0,0,10,10q�6^   �� 5%      -   5        $��ItemPriceInput��5%      $��2��6,   $��1��69   $��0,0,0,10q�6I   5&      �� 5)   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $��0,10,0,0q�6W   .+�5*      �� -   5        $��Cancel��5*      $	��100��6&   $��5q�62   6=   �� 5+      -   5        $
��Save��5+      $	��100��6$   $��5q�60   6;   5,      5-      5.      