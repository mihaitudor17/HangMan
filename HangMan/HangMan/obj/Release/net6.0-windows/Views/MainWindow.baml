   M S B A M L   `   `   `  ���� B  >HangMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:HangManHangMan  7 clr-namespace:HangMan.ViewModelsHangMan.ViewModels      HangMan.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:HangMan     /vm clr-namespace:HangMan.ViewModels     -     � Title$  
MainWindow��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � DataContext !  HangMan.ViewModels.PlayerVM  .���  � RowDefinitions �� $
��Auto ��� $
��1.5* ��� $��4* ��� $
��1.5* �.+�o� $	��Top=�$��0��.@�m� $��_File��.@�m� -   $��	_New Game��m� -   $��
_Open Game��m� -   $��
_Save Game��m� -   $��_Statistics���� m� -   $��_Exit��m� $��
Categories��.@�m� -   
 � Tag$ 1��$��_All categories��m� -   $ 2��$��_Cars��m� -	   $ 3��$��_Movies��m� -
   $ 4��$��_Rivers��m� $��_Help��.@�m� -   $��_About��� $��1�� � ColumnDefinitions �� $��3* ��� $��* �.+��� $��0��$
��Left=� �� Orientation$ 
Horizontal=�.+��� ���� *player.IconPath+�� $��Center=�$��30(�$��SemiBold"����� *player.Name+�� $��1��$��Center=�$��20(�$��SemiBold"�$��Center=����� *player.Timer+� $��2�� �� $��* ��� $��3* �.+��� $��0������ *player.GarrowPath+� $��1��.+��� -    ��Name$ 
keyBinding������ *	Letters+���� .R��  � Orientation$ 
Horizontal=����� .R��� $��50��$��50��$��5q�$��Center=����� ���� 	 �� ElementName$	 
keyBinding��
 �� Path$
 DataContext.Command�����  �� RelativeSource �� *Self+� $��3�� �� $��* ��� $��3* �.+��� $��Center=�$��Center=�$��0��
���  ��$��30(����� *player.Mistakes+�� $��Center=�$��Center=�$��1��$��30(����� *player.Letters+