   M S B A M L   `   `   `  ����F  BClassWork02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ClassWork02ClassWork02  5   	   !    ClassWork02.CreateNewWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ClassWork02     5   	     � Title$  CreateNewWindow��5   	   $	��200��6!   $	��300��6.   .��5	      � $��2,2,2,10q�6    � ColumnDefinitions 5   
   �� 5      $
��.25* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��2q�6   $��Name :��6   $��Center=�5      $��Center=�5      $��13(�5      $
��Bold"�5      �� 5   
   $��2q�6   $��Email :��6   $��Center=�5       $��Center=�5!      $��13(�5"      $
��Bold"�5#      $��1��5$      �� 5&   
   $��2q�6   $��Phone :��6   $��Center=�5'      $��Center=�5(      $��13(�5)      $
��Bold"�5*      $��2��5+      �� 5.   
   -   5         ��Name$ nameTextBox��5/      $��2,5,7,5q�5.      $��1��50      �� 52   
   -   5        $ emailTextBox��53      $��2,5,7,5q�52      $��1��54      $��1��55      �� 57   
   -   5        $ phoneTextBox��58      $��2,5,7,5q�57      $��2��59      $��1��5:      �� 5=   
   -   5         ��Name$ saveBtn��5>      $
��Save��5=      $��2��5@      $��3��5A      $��	80 5 80 5q�5B      $��15(�5C      5F      5G      