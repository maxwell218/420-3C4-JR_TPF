   M S B A M L   `   `   `  ����C  ?Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FacebookFacebook  5   	       Facebook.CreateUserWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Facebook     5   	     � Title$  Facebook - Inscription��5   	   $	��500��6(   $	��600��65    � 
ResizeMode$ NoResize=�6A   $��14(�6W   .��5	      �  � RowDefinitions 5
   
   �� 5      $��65 �6   �� 5      $��3 �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��Center=�6!   $��Center=�6<   .+�5      ��    LoginTextBlockLogoStyle#���   6   
facebook6T   5      �� 5   
   $��1��6    J� Opacity$	 0.5Q�6   ��5      �� 5       �� EndPoint$ 	0.504,1.5&�6&    �� 
StartPoint$ 
0.504,0.03&�6;   .��5      �  � Color$ #646464��6#    � Offset$ 0Q�63   � 5      $ #E4EBEC��6#   $ 0.567Q�63   5      5      � 5   
   $��2��6   ���#E4EBEC.+�5      �� $��Center=�6   $��75, 0q�64   .+�5      �� 
�������$��1q�61    �� CornerRadius$ 10��6E   
�������._�5      � $��15, 15q�6    5      �� 5      $
��auto �6,   �� 5       $
��auto �6,   �� 5!      $
��auto �6,   �� 5"      $
��auto �6,   �� 5#      $
��auto �6,   �� 5$      $
��auto �6,   .+�5&      � $��0��6   	 � ColumnDefinitions	 5'      �� 5(   "   $��* �63   �� 5)   "   $��* �63   .+�5+      �� $��0��6)   $��
0, 0, 5, 0q�69   .+�5,   "   �� $��
0, 0, 0, 5q�6,   
�������	Prénom :6\   �� 5-   "   -   5        
 ��Name$
 FirstNameTextBox��5-   *     LoginTextBoxStyle#���  6D   5.      �� 5/      $��1��6)   $��
5, 0, 0, 0q�69   .+�50   "   �� $��
0, 0, 0, 5q�6,   
�������Nom :6Y   �� 51   "   -   5        $
 LastNameTextBox��51   *   #���  6C   52      53      �� 54      $��1��6$   $��0, 10, 0, 5q�61   
�������
Courriel :6d   �� 55      -   5        $
 EmailTextBox��55   "   $��2��68   #���  6E   �� 56      $��3��6$   $��0, 10, 0, 5q�61   
�������Mot de passe :6h   G� 57      -   5         G�Name$ PasswordBox��57   &   $��4��6;     LoginPasswordBoxStyle#���  6H   �� 58      -   5        $��5��58   !   $��0, 15, 0, 5q�6.     CreateAccountButtonStyle#���  6C   .��59      �� 
S'inscrire64   5:      5;      5<      5=      5>      5?      5@      