   M S B A M L   `   `   `  ����O  KStorageInfoApp_Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:StorageInfoApp_Final.WindowsStorageInfoApp_Final.Windows  5   	   /    )StorageInfoApp_Final.Windows.EditUser_Wnd   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:StorageInfoApp_Final.Windows     5   	   e aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a^	 ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af
 bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks     	 
                 6B   -   5        $��633.333��5   	   $	��380��6     � AllowsTransparency  . 
������  � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $	��200 �6    �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   $��0,0,1,0q�68   ._�5      �� -   5         ��Name$ 	close_btn��5      $��X��6,   $��344,4,3,599q�68   6M   ��5      �� 5      .��5      �  � Color$ Green��6'    � Offset$	 0.0Q�65   � 5      $ 	Gainsboro��6'   $ 1Q�69   5      5      �� 5      $	��top=�6   $��Center=�61   $	��119��6N    �� Orientation$ 
Horizontal=�6[   $��0,8,0,0q�6t   .+�5       �� $��
1, 1, 1, 1q�6   $��reg2.png��6,   $	��115��6>   �� 5!      $��	users.png��6   $	��115��6+   5"      �� 5%      $��Bottom=�6   $��80��64   $��0,0,0,2q�6@   .+�5&      �� $
��Edit��6   $��Light"�5'      $��Palatino Linotype)�5(      $��29(�5)      $��Center=�5*      ��5+      �� 5,      	 �� EndPoint$	 0.5,1&�6.   
 �� 
StartPoint$
 0.5,0&�6?   .��5-      � $ Black��6+   $ 0Q�69   � 5.      $ 	#FF801F61��6+   $
 0.55Q�6=   5/      51      �� 52      -   5         ��Name$ username_lbl��52      $��Name of a User��53      $��Heavy"�54      $��Palatino Linotype)�55      $��33(�56      $��Center=�57      ��58      �� 59      $	 0.5,1&�6.   $
 0.5,0&�6?   .��5:      � $ Black��6+   $ 0Q�69   � 5;      $ 	#FFC77171��6+   $ 1Q�6=   5<      5>      5?      �� 5B      $��1��6   .+�5D      �� $ 
Horizontal=�6   $��0, 30, 0, 0q�66   .+�5E      �� -   5         ��Name$ 	fName_txt��5E      $��Times New Roman)�5F      $��Light"�5G      $��20(�5H      $��Center=�5I      
�������
������ $��0q�5L      $	��235��5M      $
��Left=�5N       J� Opacity$	 0.5Q�5O      $��25��5P      $��63,0,0,0q�5Q      6'   .  (MahApps.Metro.IconPacks.PackIconMaterial  5T         Kind$ Account=�5U      $��Center=�5V      $��Center=�5W      
�������5X      5Y      �� 5[      $	��250��5\      $��2��5]      
�������$	 0.5Q�5_      �� 5c      $ 
Horizontal=�6   $��0,20,0,0q�66   .+�5d      �� -   5        $ 	lName_txt��5d      $��Times New Roman)�5e      $��Light"�5f      $��20(�5g      $��Center=�5h      
�������
������ $��0q�5k      $	��235��5l      $
��Left=�5m      $	 0.5Q�5n      $��25��5o      $��63,0,0,0q�5p      6'     5r      $ Account=�5s      $��Center=�5t      $��Center=�5u      
�������5v      5w      �� 5y      $	��250��5z      $��2��5{      
�������$	 0.5Q�5}      �� 5�      $ 
Horizontal=�6   $��0, 20 ,0 ,0q�66   .+�5�      �� -   5        $ age_txt��5�      $��Times New Roman)�5�      $��Light"�5�      $��20(�5�      $��Center=�5�      
�������
������ $��0q�5�      $	��235��5�      $
��Left=�5�      $	 0.5Q�5�      $��25��5�      $��63,0,0,0q�5�      6'     5�      $ Account=�5�      $��Center=�5�      $��Center=�5�      
�������5�      5�      �� 5�      $	��250��5�      $��2��5�      
�������$	 0.5Q�5�      �� 5�      $ 
Horizontal=�6   $��0, 20 ,0 ,0q�66   .+�5�      �� -   5        $ 	login_txt��5�      $��Times New Roman)�5�      $��Light"�5�      $��20(�5�      $��Center=�5�      
�������
������ $��0q�5�      $	��235��5�      $
��Left=�5�      $	 0.5Q�5�      $��25��5�      $��63,0,0,0q�5�      6'     5�      $ Account=�5�      $��Center=�5�      $��Center=�5�      
�������5�      5�      �� 5�      $	��250��5�      $��2��5�      
�������$	 0.5Q�5�      �� 5�      $ 
Horizontal=�6   $��0, 20 ,0 ,0q�66   .+�5�      �� -   5        $ pass_txt��5�      $��Times New Roman)�5�      $��Light"�5�      $��20(�5�      $��Center=�5�      
�������
������ $��0q�5�      $	��235��5�      $
��Left=�5�      $	 0.5Q�5�      $��25��5�      $��63,0,0,0q�5�      6'     5�      $ Account=�5�      $��Center=�5�      $��Center=�5�      
�������5�      5�      �� 5�      $	��250��5�      $��2��5�      
�������$	 0.5Q�5�      �� 5�      $ 
Horizontal=�6   $��0, 20 ,0 ,0q�66   .+�5�      �� -	   5        $ 	phone_txt��5�      $��Times New Roman)�5�      $��Light"�5�      $��20(�5�      $��Center=�5�      
�������
������ $��0q�5�      $	��235��5�      $
��Left=�5�      $	 0.5Q�5�      $��25��5�      $��63,0,0,0q�5�      6'     5�      $ Account=�5�      $��Center=�5�      $��Center=�5�      
�������5�      5�      �� 5�      $	��250��5�      $��2��5�      
�������$	 0.5Q�5�      �� 5�      $ 
Horizontal=�6   $��0, 20 ,0 ,0q�66   .+�5�      �� -
   5        $ 	email_txt��5�      $��Times New Roman)�5�      $��Light"�5�      $��20(�5      $��Center=�5     
�������
������ $��0q�5     $	��235��5     $
��Left=�5     $	 0.5Q�5     $��25��5     $��63,0,0,0q�5	     6'     5     $ Account=�5     $��Center=�5     $��Center=�5     
�������5     5     �� 5     $	��250��5     $��2��5     
�������$	 0.5Q�5     �� 5     $ 
Horizontal=�6   $��0, 29, 0, 0q�66   $��Center=�6K   .+�5     �� -   5        $ reg_btn��5     $	��194��6.   $��40��6:   $��Update��6F   $��18(�6m   $
��Bold"�6{   5     5     5      5!     5"     