   M S B A M L   `   `   `  ����L  HStorage_Admin_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Storage_Admin_AppStorage_Admin_App  5   	   #    Storage_Admin_App.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -localclr-namespace:Storage_Admin_App   5   	   -   5          � Title$  LoginWindow��5	   	   $	��450��6   $	��380��6*    � AllowsTransparency . 
������  � WindowStartupLocation$ CenterScreen=�5
   <    � WindowStyle$
 None=�6a   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ._�5      �� -   5         ��Name$ 	close_btn��5      $��X��6,   $��346,4,4,418q�68   6M   ��5      �� 5      .��5      �  � Color$ #7be9f6��6'    � Offset$	 0.0Q�67   � 5      $ #f083da��6'   $ 1Q�67   5      5      �� 5      $��Center=�6   .+�5      �� $��icon-login.jpg��6   $��80��61   �� 5      $��Authorization��6   $��Light"�5       $��Palatino Linotype)�5!      $��22(�5"      
���#�k�$��Center=�5$      5%      �� 5(      $��1��6   .+�5*      �� 	 �� Orientation$	 
Horizontal=�6   .+�5+      �� -   5        
 ��Name$
 	login_txt��5+      $��Times New Roman)�5,      $��Light"�5-      $��	Username:��5.      $��20(�5/      $��Center=�50      
�������
������ $��0q�53      $	��235��54      $
��Left=�55       J� Opacity$	 0.5Q�56      $��25��57      $��63,0,0,0q�58      6'   .  (MahApps.Metro.IconPacks.PackIconMaterial  5;         Kind$ Account=�5<      $��Center=�5=      $��Center=�5>      
�������5?      5@      �� 5B      $	��250��5C      $��2��5D      
�������$	 0.5Q�5F      �� 5J      $	 
Horizontal=�6   $��0,20,0,0q�66   .+�5K      G� -   5         G�Name$ 
passwd_txt��5K   "   $��Times New Roman)�5L      $��Light"�5M       G� Password$ 	Password:��5N      $��20(�5O      $��Center=�5P      
�������
������ $��0q�5S      $	��235��5T      $
��Left=�5U      $	 0.5Q�5V      $��25��5W      $��63,0,0,0q�5X      5Y        5[      $ FormTextboxPassword=�5\      $��Center=�5]      $��Center=�5^      
�������5_      5`      �� 5b      $	��250��5c      $��2��5d      
�������$	 0.5Q�5f      �� 5j      $��Right=�6   $��0,10,64,-20q�69   .+�5k      �� -   5         ��Name$ remeber_check��5k      $��Remember me?��66   ��6M   Z� 5l      �� 5o      $	 
Horizontal=�6   $��0, 50, 0, 0q�66   .+�5p      �� -   5        $ log_btn��5p      $	��100��6.   $��40��6:   $��Sign In��6F   $��80, 0, 20, 0q�6X   6n   �� 5q      -   5        $ reg_btn��5q      $	��100��6.   $��40��6:   $��Sign Up��6F   6X   5r      5t      5u      5v      5w      