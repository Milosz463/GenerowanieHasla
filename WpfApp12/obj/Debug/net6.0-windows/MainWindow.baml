   M S B A M L   `   `   `  ����C  ?WpfApp12, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp12WpfApp12  5   	       WpfApp12.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp12     5   	   ���#B0C4DE  � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   .+�5   
   �� $��20q�6   $��Dane pracownika��6   .��5      �� $��15q�6   .+�5      A�  A� Columns$ 2��6   .+�5      �� imie6&   �� 5      -   5         ��Name$
 imie��5      6&   �� 5      
nazwisko6&   �� 5      -   5        $ nazwisko��5      6.   �� 5      
Stanowisko6,   �� 5      -   5         ��Name$ 
stanowiska��5      .@�5      �� .��6#   	Kierownik6.   �� 5      .��6#   Starszy programista68   �� 5       .��6#   Mlodszy programista68   �� 5!      .��6#   Tester6+   5"      5#      5$      5%      �� 5'   
   $��20q�6   $��0��6   $��1��6,   $��Generowanie hasla��6<   .��5(      �� $��15q�6   .+�5)      A� .+�5*      �� Ile znakow?6-   �� 5+      -   5        $ znakii��5+      6,   5,      �� 5-      -   5         ��Name$ litery��5-      .��6+   Male i wielkie litery6B   �� 5.      -   5        $ cyfry��5.      .��6*   Cyfry61   �� 5/      -   5        $ znaki��5/      .��6*   Znaki specjalne6;   � 50      $��Center=�6   .+�51      �� -   5        
�������
�����F�.��51   ^   Generuj haslo6m   52      53      54      � 55   
   $��20q�6   $��1��6    $��2��6-   $��Center=�6A   .+�56      �� -	   5        
�������
�����F�$	��150��56   U   .��6a   	Zatwierdz6l   57      58      5:      