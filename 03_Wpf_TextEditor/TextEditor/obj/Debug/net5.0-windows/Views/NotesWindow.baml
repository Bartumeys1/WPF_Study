   M S B A M L   `   `   `  ����E  ATextEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TextEditor.ViewsTextEditor.Views  5   	   "    TextEditor.Views.NotesWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TextEditor.Views     5   	     � Title$  NotesWindow��5   	   $	��559��6   $	��800��6*   .��5	      � .+�5
   
   �� -   5         ��Name$ 	txtEditor��5
      $��10,25,10,34q�6%    �� TextWrapping$
 Wrap=�6:    �� AcceptsReturn$
 True��6N   $
��Auto=�6c   6�   o� 5   
   $��24��6   $	��Top=�6   $��12(�63   $��10 0 0 0q�6A   .@�5      m� $
��File��6   $��3q�6%   $��Center=�60   .@�6T   .@�5                m� -   5        $��	Creat new��5      $��2q�6K   m� 5      -   5        $��Save as��5      $��2q�6G   m� 5      -   5        $
��Open��5      $��2q�6D   �� 5      m� 5      -   5        $
��Exit��5      $��2q�6D   5      5      �� 5   
   $��Bottom=�6   $��1q�6/   .@�5      �� -   5         ��Name$ cursorPositionInfoLabel��5      $��245:12��65   $��Center=�6F   �� 5      -   5        $ FilePathInfoLable��5      $��File path: ��60   $��Center=�6F   5      5      5      