   M S B A M L   `   `   `  ����C  ?Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FacebookFacebook  5   	       Facebook.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Facebook     5   	     � Title$+  %Facebook - Se connecter ou s'inscrire��5   	   $	��500��67   $	��600��6D    � 
ResizeMode$ NoResize=�6P   $��14(�6f   .��5	      �  � RowDefinitions 5
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
��auto �6,   �� 5%      $��1 �6,   �� 5&      $
��auto �6,   .+�5(      �� $��0��6$   $��
0, 0, 0, 5q�61   
�������
Courriel :6c   �� 5)      -   5        	 ��Name$	 EmailTextBox��5)   /   $��1��6"     LoginTextBoxStyle#���  6E   �� 5*      $��2��6$   $��0, 10, 0, 5q�61   
�������Mot de passe :6h   G� 5+      -   5        
 G�Name$
 PasswordBox��5+   3   $��3��6&     LoginPasswordBoxStyle#���  6H   �� 5,      -   5        $��4��5,   !   $��0, 15, 0, 15q�6.     LoginButtonStyle#���  6D   .��5-      �� Se connecter66   5.      �� 5/      $��5��6$   $��0, 0, 0, 15q�61   $��Center=�6F     LoginHyperlinkStyle#���  6c   �� 50      .�6(   Mot de passe oublié ?6?   51      �� 52      $��6��6$   
�������$��1��6B   �� 53      -   5        $��7��53   !   $��0, 15, 0, 5q�6.     CreateAccountButtonStyle#���  6C   .��54      �� Créer un nouveau compte6A   55      56      57      58      59      5:      5;      