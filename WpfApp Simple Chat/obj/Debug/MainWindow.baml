   M S B A M L   `   `   `  ����M  IWpfApp Simple Chat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfApp_Simple_ChatWpfApp_Simple_Chat  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 68   #    WpfApp_Simple_Chat.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WpfApp_Simple_Chat     5   	   6sys&clr-namespace:System;assembly=mscorlib     68   -   5          � Title$  Telegram��5   	   $	��500��6   $	��500��6'    � WindowStartupLocation$ CenterScreen=�63   $	��500��6X   $	��500��6h   .��5
      � ���#166fe5 � RowDefinitions 5   
   �� 5      $	��85* �6   �� 5      $	��15* �6   .+�5   
   � $��0��6   $��15q�6   .+�5      �� -   5        $��ScrlVwrFirst��5      $
��Auto=�6/   $��Disabled=�6R   .��5      � ��6   ��  �� ElementName$ ScrlVwrFirst�� �� Path$ ActualWidth�.+�5      �� -   5        $��LstBxMessages��5      $��0q�63   $��20(�6G   ���#f0f2f5
���   �5      5      5      5!      � 5$   
   $��1��6   $��15q�6    � ColumnDefinitions 5&      �� 5'      $	��80* �6#   �� 5(      $	��10* �6#   �� 5)      $	��10* �6#   .+�5,      �� $��0��6   $
��Auto=�6+   .��5.      �� -   5        $��TxtBxMessage��5.      
�������
���   �$��25(�6U   $��Microsoft Sans-serif)�6c    �� TextWrapping$
 Wrap=�5/      $��
5, 5, 0, 0q�6*    �� AcceptsReturn .  �� 	IsEnabled . 	 � Language$	 en-US�50      .��6C   52      54      �� 57      -   5        $��BtnSendImage��57      $��1��6)   $��
5, 0, 0, 0q�69   
 � Cursor$

 Hand��6M   .��59      �� $��/img/folder.png��6   63   5;      �� 5=      -   5        $��BtnSendText��5=      $��2��6(   $��
5, 0, 0, 0q�68   $

 Hand��6L   .��5?      �� $��/img/send message.png��6   69   5A      5D      5F      5G      