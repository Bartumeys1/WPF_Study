   M S B A M L   `   `   `  ����I  EEvent_Planning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Event_Planning.ViewEvent_Planning.View  5   	   (    "Event_Planning.View.AddPlannWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Event_Planning.View     5   	     � Title$  AddPlannWindow��5   	   $	��400��6    $	��400��6-   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $	��49* �6   �� 5      $
��102* �6   �� 5      $	��33* �6   �� 5      $
��138* �6   �� 5      $	��43* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��
Task name:��6   $��0��6%   $	��Top=�65   $��14(�6M   $��	0,8,110,0q�6[   $��29��6n   �� 5   
   -   5         ��Name$ nameTextBox��5      $	��275��6'   $��25��63   $��0��6@   $��2��6P   $
��Left=�6d   $��Center=�6�   $��85,0,0,0q�6�   �� 5   
   -   5         ��Name$ PriorityGroupBox��5      $��Priority��6.   $��
95,0,95,10q�6A   $��2��6U   $��1��6i   .��5      �� .+�5      	� -   5        $	��Low��5       d� 	IsChecked$
 TrueY�6,   $��3q�6=   6H   	� 5      -   5        $��3q�5      .��6G   Medium6O   	� 5      -   5        $��3q�5      .��6G   Hight6N   5      5       �� 5"   
   $��Dedline time:��6   $��2��6(   $��Center=�66   $��14(�6Q   $��0,0,86,0q�6_   $��28��6q   (  "System.Windows.Controls.DatePicker  5#   
   -   5          Name$ dedlineTimepicker��5#      $	��150��60   $��25��6<   $
��Left=�6H   $��Center=�6c   $��2��6~   $��	109,0,0,0q�6�   $��2��6�   �� 5%   
   -   5        $ InformationGroupBox��5%      $��Additional Information��61   $��2��6Q   $��3��6e   $��0,0,0,3q�6r   .��5&      �� -   5        $ informationTextBox��5&       �� TextWrapping$ NoWrap=�62   5'      �� 5)   
   -	   5         ��Name$ addBtn��5)      $	��Add��6!   $��0��6O   $��4��6_   $��	15,2,15,0q�6l   �� 5*   
   -
   5        $ 	canselBtn��5*      $��Cansel��6$   $��1��6M   $��4��6]   $��	15,2,15,0q�6j   5-      5.      