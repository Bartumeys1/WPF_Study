   M S B A M L   `   `   `  ����E  ATextEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TextEditor.ViewsTextEditor.Views  5   	   "    TextEditor.Views.LoginWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TextEditor.Views     5   	     � Title$  LoginWindow��5   	   $	��350��6   $	��550��6*   .��5	      � $��	2,30,2,55q�6    � ColumnDefinitions 5   
   �� 5      $	��.4* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��1.3* �6   .+�5   
   �� $��2q�6   $��Login :��6   $��Center=�5      $��Center=�5      $��24(�5      $
��Bold"�5      �� 5   
   $��2q�6   $��
Password :��6   $��Center=�5       $��Center=�5!      $��24(�5"      $
��Bold"�5#      $��1��5$      �� 5(   
   -   5         ��Name$ loginNameTextBox��5)      $��	3,15,29,0q�5(      $��5q�5*      $��45��5+      $��1��5,      $��20(�5-      $	��Top=�5.      �� 50   
   -   5        $ passwordTextBox��51      $��3,0,29,0q�50      $��5q�52      $��45��53      $��1��54      $��1��55      $��20(�56      $��Center=�57      �� 5;   
   -   5         ��Name$ loginBtn��5<      $��Login��5;      $��2��5>      $��2��5?      $��Center=�5@      $��15(�5A      $	��175��5B      $��
0 20 200 0q�5C      �� 5F   
   -   5        $ registrateBtn��5G      $��Registration��5F      $��2��5I      $��2��5J      $��Center=�5K      $��15(�5L      $	��175��5M      $��
200 20 0 0q�5N      5Q      5R      