   M S B A M L   `   `   `  ����E  APraktika_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Praktika_1
Praktika_1  5          Praktika_1.FirstPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Praktika_1     5        N� Title$  	FirstPage��5	      .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ NAME_COFFEEDataGrid��5         AutoGenerateColumns .  $��0,111,10,210q�6L      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID_NAME_COFFEE_HOUSE+  5      $ Название��6%    67   �� *TITLE+  5      $ 
Адрес��6%    64   �� *ADDRESS_COFFEE_HOUSE+5      �� 5   
   -   5         ��Name$ insert��5      $#��Добавить данные��6"   $��
0,430,10,0q�6<   6Q   �� 5   
   -   5        $ delete��5      $#��Удаление данных��6"   $��0,405,10,20q�6<   6Q   �� 5   
   -   5        $ update��5      $'��!Обновление данных��6"   $��0,385,10,45q�6>   6S   �� 5   
   -   5        $ 	poick_dan��5      $��Поиск данных��6&   $��0,366,10,65q�6=   6R   �� 5   
   -   5        $ filter_dani��5      $��Очистить��6(   $��0,347,10,84q�6;   6P   �� 5   
   -   5         ��Name$ 
filter_dan��5      $��0,324,10,107q�6(   6>   �� 5   
   -   5         ��Name$
 text��5      $��0,304,10,124q�6    ��66   �� *SelectedItem.TITLE+	 �� ElementName$	 NAME_COFFEEDataGrid��.��6{   
 � 	Resources
 5       �� 
TargetType �� Property �� Value �� 
TargetType ��Name ��Name J� IsHitTestVisible ��Name �� Triggers P� Property P� Value �� 
TargetName��%5  '��       �� 5      " ��6   .�5      ��  � �� 5      �� 5      " ��6.   .R�5    "   � .+�5!   &   �� $ border��6-   #��z��5"   %   #��z��5#   %   #��z��5$   %   �� 5%   &   $ 	watermark��60   $8��2Введите название кофейни ...��5&   (   $��2q�5'   (   
�������$y�	Collapsed=�5)   (    .  5*   (   �� 5+   &   $ PART_ContentHost��63   5,   #    5-   "   P� 5.   &    � ��$  ��6>   . �5/   *   �� $ 	watermark��61    � y�$ Visible=�6^   50   '   52      54      55      56      .��6!   57      �� 59   
   -	   5        $ poick��59      $��0,262,10,166q�6!   ��67   �� *SelectedItem.TITLE+$	 NAME_COFFEEDataGrid��.��6|   
 5:      ��%I  '��       �� 5;      " ��6   .�5<      ��  � �� 5=      �� 5>      " ��6.   .R�5?   "   � .+�5@   &   �� $ border��6-   #��z��5A      #��z��5B      #��z��5C      �� 5D   &   $ 	watermark��60   $L��FВведите название кофейни для поиска ...��5E       $��2q�5F       
�������$y�	Collapsed=�5H        .  5I       �� 5J   &   $ PART_ContentHost��63   5K   #    5L   "   P� 5M   &    � ��$  ��6>   . �5N   *   �� $ 	watermark��61    � y�$ Visible=�6^   5O   '   5Q      5S      5T      5U      .��6!   5V      �� 5Y   
   -
   5        $ addressTextBox��5Y      $��0,284,10,146q�6*   ��6@   �� *#!SelectedItem.ADDRESS_COFFEE_HOUSE+$	 NAME_COFFEEDataGrid��.��6�   
 5Z      ��%  '��       �� 5[      " ��6   .�5\      ��  � �� 5]      �� 5^      " ��6.   .R�5_   "   � .+�5`   &   �� $ border��6-   #��z��5a   %   #��z��5b   %   #��z��5c   %   �� 5d   &   $ 	watermark��60   $"��Введите адрес...��5e   (   $��2q�5f   (   
�������$y�	Collapsed=�5h   (    .  5i   (   �� 5j   &   $ PART_ContentHost��63   5k   #    5l   "   P� 5m   &    � ��$  ��6>   . �5n   *   �� $ 	watermark��61    � y�$ Visible=�6^   5o   '   5q      5s      5t      5u      .��6!   5v      5w      5x      