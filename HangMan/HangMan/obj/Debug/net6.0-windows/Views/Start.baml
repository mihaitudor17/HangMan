   M S B A M L   `   `   `  ����B  >HangMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:HangManHangMan  5   	       HangMan.Start   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:HangMan     5   	   -   5          � Title$  HangMan��5   	   $	��450��6   $	��800��6&    � DataContext 5
        HangMan.UserList  5   
   6   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   �� 5      $
��Auto �6   6,    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� $��2��6   $��0��6(   $��0��65    �� TextAlignment$ Center=�6E   $��14(�6\   $
��Bold"�6j   Welcome to Hangman, have fun!6�   �� 5   
   -   5        $��listbox��5      $��0��6!   $��1��61    �� DisplayMemberPath$
 Name��6>   $��10q�6�   $��16(�6�   ��6W   �� *Users+6�   �� 5   
   $��1��6(   $��1��68   $��10q�6E   $��Center=�6Q   $��Center=�6l   ��6   �� *Icon+6�   �� 5"   
   $��2��6   $��0��6"    �� Orientation$ 
Horizontal=�62   .+�5#      �� -   5        $��16(�5#      $	��100��6#   $
��Auto��6/   $��100 10 10 10q�6=   .��6_   
Add User6j   �� 5$      -   5        $��16(�5$      $	��100��6#   $��40��6/   $��10q�6;   .��6V   Delete User6c   5%      �� 5&   
   $��2��6   $��1��6"   $ 
Horizontal=�63   .+�5'      �� -   5        $��16(�5'      $	��100��6#   $
��Auto��6/   $��100 10 10 10q�6=   .��6`   Play6f   �� 5(      -   5        $��16(�5(      $	��100��6#   $
��Auto��6/   $��10q�6=   .��6X   Cancel6a   5)      5*      5+      