   M S B A M L   `   `   `  ����B  >HangMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:HangManHangMan  5   	   7 clr-namespace:HangMan.ViewModelsHangMan.ViewModels  5   	       HangMan.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:HangMan     5   	   /vm clr-namespace:HangMan.ViewModels     5   	   -   5          � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�5
   	    � DataContext 5      !  HangMan.ViewModels.PlayerVM  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��1.5* �6   6,   �� 5      $��4* �6   6*   �� 5      $
��1.5* �6   6,   .+�5   
   o� $	��Top=�6   $��0��6$   .@�5      m� $��_File��6   .@�5      m� -   5        $��	_New Game��5      6*   m� 5      -   5        $��
_Open Game��5      6+   m� 5      -   5        $��
_Save Game��5      6+   m� 5      -   5        $��_Statistics��5      6,   �� 5      m� 5      -   5        $��_Exit��5      6&   5      m� 5      $��
Categories��6   .@�5       m� -   5        
 � Tag$ 1��5       $��_All categories��6$   6=   m� 5!      -   5        $ 2��5!      $��_Cars��6$   63   m� 5"      -	   5        $ 3��5"      $��_Movies��6$   65   m� 5#      -
   5        $ 4��5#      $��_Rivers��6$   65   5$      m� 5%      $��_Help��6   .@�5&      m� -   5        $��_About��5&      6+   5'      5(      � 5)   
   $��1��6    � ColumnDefinitions 5*      �� 5+      $��2* �6#   60   �� 5,      $��* �6#   6/   �� 5-      $��* �6#   6/   �� 5.      $��2* �6#   60   .+�50      �� $��0��6   $
��Left=�6)    �� Orientation$ 
Horizontal=�6D   .+�51      �� ��6   �� *player.IconPath+6>   �� 52      $��Center=�69   $��30(�6T   $��SemiBold"�6b   ��6   �� *player.Name+6z   53      �� 54      $��1��6   $��Center=�6(   $��20(�6E   $��Center=�6S   $��SemiBold"�6n   $��Level:��6�   6�   �� 55      $��2��6   $��Center=�6(   $��20(�6E   $��Center=�6S   $��SemiBold"�6n   ��6�   �� *player.Level+6�   �� 56      $��3��6   $��Center=�6(   $��20(�6E   $��SemiBold"�6S   $��Center=�6i   ��6�   �� *player.Timer+6�   57      � 58   
   $��2��6    59      �� 5:      $��* �6#   6/   �� 5;      $��3* �6#   60   .+�5=      �� $��0��6   ��6&   �� *player.GarrowPath+6N   � 5>      $��1��6   .+�5?      �� -   5         ��Name$ 
keyBinding��5?      ��63   �� *	Letters+��5@      �� 5A      .R�5B      �  � Orientation$ 
Horizontal=�6(   5C      ��5E      �� 5F      .R�5G      �� $��50��6%   $��50��63   $��5q�6B   $��Center=�6M   ��6j   �� ��6~   �� 	 �� ElementName$	 
keyBinding��
 �� Path$
 DataContext.Command���6�   ��  �� RelativeSource �� *Self+5H      5J      5K      5L      � 5M   
   $��3��6    5N      �� 5O      $��* �6#   6/   �� 5P      $��3* �6#   60   .+�5R      �� $��Center=�6   $��Center=�65   $��0��6P   
���  ��$��30(�6�   ��6q   �� *player.Mistakes+6�   �� 5S      $��Center=�6   $��Center=�64   $��1��6Q   $��30(�6�   ��6a   �� *player.Letters+6�   5T      5U      5V      