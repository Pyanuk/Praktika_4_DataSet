   M S B A M L   `   `   `  ����E  APraktika_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Praktika_1
Praktika_1  5          Praktika_1.Three   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Praktika_1     5        N� Title$  Three��5	      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ ORDER_COFFEEDataGrid��5         AutoGenerateColumns .  $��0,170,0,151q�6M      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID_ORDER_COFFEE+  5      $! Название коффе��6%    6=   �� *COFFEE_NAME+  5      $ Цена коффе��6%    69   �� *COFFEE_PRICE+5      �� 5   
   -   5         ��Name$ price��5      $��0,361,10,67q�6!   ��66   �� *SelectedItem.COFFEE_PRICE+ �� ElementName$ ORDER_COFFEEDataGrid��.��6�    � 	Resources 5      	 �� 
TargetType
 �� Property �� Value �� 
TargetType ��Name ��Name J� IsHitTestVisible ��Name �� Triggers P� Property P� Value �� 
TargetName��%  '��       �� 5      "	 ��6   .�5      �� 
 � �� 5      �� 5      " ��6.   .R�5   "   � .+�5   &   �� $ border��6-   #��z��5      #��z��5      #��z��5      �� 5   &   $ 	watermark��60   $!��Введите цену ...��5       $��2q�5!      
�������$y�	Collapsed=�5#       .  5$      �� 5%   &   $ PART_ContentHost��63   5&   #    5'   "   P� 5(   &    � ��$  ��6>   . �5)   *   �� $ 	watermark��61   
 � y�$ Visible=�6^   5*   '   5,      5.      5/      50      .��6!   51      �� 53   
   -   5         ��Name$ insert��53      $#��Добавить данные��6"   $��
0,430,10,0q�6<   6Q   �� 54   
   -   5        $ delete��54      $#��Удаление данных��6"   $��0,405,10,20q�6<   6Q   �� 55   
   -   5        $ update��55      $'��!Обновление данных��6"   $��0,380,10,45q�6>   6S   �� 57   
   -   5        $ cofee��57      $��0,339,10,89q�6!   ��66   �� *SelectedItem.COFFEE_NAME+$ ORDER_COFFEEDataGrid��.��6�    58      ��%   '��       �� 59      "	 ��6   .�5:      �� 
 � �� 5;      �� 5<      " ��6.   .R�5=   "   � .+�5>   &   �� $ border��6-   #��z��5?      #��z��5@      #��z��5A      �� 5B   &   $ 	watermark��60   $#��Введите коффе ...��5C      $��2q�5D      
�������$y�	Collapsed=�5F       .  5G      �� 5H   &   $ PART_ContentHost��63   5I   #    5J   "   P� 5K   &    � ��$  ��6>   . �5L   *   �� $ 	watermark��61   
 � y�$ Visible=�6^   5M   '   5O      5Q      5R      5S      .��6!   5T      5V      5W      