   M S B A M L   `   `   `  ����O  KStorageInfoApp_Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:StorageInfoApp_Final.WindowsStorageInfoApp_Final.Windows  5   	   )    #StorageInfoApp_Final.Windows.Create   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:StorageInfoApp_Final.Windows     5   	   e aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a^	 ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af
 bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks     	 
                 6B   -   5        $��609.409��5   	   $	��380��6   
������   � AllowsTransparency  .  � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�6.   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $	��212 �6    �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   $��0,0,1,0q�68   ._�5      �� -   5         ��Name$ 	close_btn��5      $��X��6,   $��	344,4,3,0q�68   $��30��6c   $	��Top=�6o   6�   ��5      �� 5      .��5      �  � Color$ 
Aquamarine��6'    � Offset$	 0.0Q�6:   � 5      $ Black��6'   $ 1Q�65   5      5      �� 5      $	��top=�6   $	��327��61   $��0,-1,0,0q�6>   $��2��6P   .+�5      �� $��
create.png��6   $��	71,0,70,0q�6,   $	��141��6?   5       �� 5#      $��Bottom=�6   $��85��64   $��0,0,0,2q�6@   .+�5$      �� -   5         ��Name$ 	text1_txt��5$      $��Add New one Info��5%      $��Light"�5&      $��Palatino Linotype)�5'      $��29(�5(      $��Center=�5)      ��5*      �� 5+      	 �� EndPoint$	 0.5,1&�6.   
 �� 
StartPoint$
 0.5,0&�6?   .��5,      � $ Black��6+   $ 0Q�69   � 5-      $ 	#FF5A18AA��6+   $ 0.649Q�6=   � 5.      $ 	#FF1E083A��6+   � 5/      $ 	#FFA318AA��6+   $ 0.793Q�6=   50      52      �� 53      -   5        $ 	text2_txt��53      $��about your website��54      $��Heavy"�55      $��Palatino Linotype)�56      $��33(�57      $��Center=�58      ��59      �� 5:      $	 0.5,1&�6.   $
 0.5,0&�6?   .��5;      � $ Black��6+   $ 0Q�69   � 5<      $ 	#FF9609B6��6+   $ 0.633Q�6=   5=      5?      5@      �� 5C      $��1��6   .+�5E      ��  �� Orientation$ 
Horizontal=�6   $��0, 20, 0, 0q�66   .+�5F      �� -   5         ��Name$ name_txt��5F      $��Times New Roman)�5G      $��Light"�5H      $��
Site Name:��5I      $��20(�5J      $��Center=�5K      
�������
������ $��0q�5N      $	��235��5O      $
��Left=�5P       J� Opacity$	 0.5Q�5Q      $��25��5R      $��63,0,0,0q�5S      6D   .  (MahApps.Metro.IconPacks.PackIconMaterial  5U         Kind$ 	Wordpress=�5V      $��Center=�5W      $��Center=�5X      
�������5Y      5Z      �� 5\      $	��250��5]      $��2��5^      
�������$	 0.5Q�5`      �� 5d      $ 
Horizontal=�6   $��0, 20 ,0 ,0q�66   .+�5e      �� -   5        $ url_txt��5e      $��Times New Roman)�5f      $��Light"�5g      $
��URL:��5h      $��20(�5i      $��Center=�5j      
�������
������ $��0q�5m      $	��235��5n      $
��Left=�5o      $	 0.5Q�5p      $��25��5q      $��63,0,0,0q�5r      6C     5t      $ 	Stackpath=�5u      $��Center=�5v      $��Center=�5w      
�������5x      5y      �� 5{      $	��250��5|      $��2��5}      
�������$	 0.5Q�5      �� 5�      $ 
Horizontal=�6   $��0, 20 ,0 ,0q�66   .+�5�      �� -   5        $ 	login_txt��5�      $��Times New Roman)�5�      $��Light"�5�      $��Login:��5�      $��20(�5�      $��Center=�5�      
�������
������ $��0q�5�      $	��235��5�      $
��Left=�5�      $	 0.5Q�5�      $��25��5�      $��63,0,0,0q�5�      6E     5�      $ Account=�5�      $��Center=�5�      $��Center=�5�      
�������5�      5�      �� 5�      $	��250��5�      $��2��5�      
�������$	 0.5Q�5�      �� 5�      $ 
Horizontal=�6   $��0, 20 ,0 ,0q�66   .+�5�      �� -   5        $ pass_txt��5�      $��Times New Roman)�5�      $��Light"�5�      $��	Password:��5�      $��20(�5�      $��Center=�5�      
�������
������ $��0q�5�      $	��235��5�      $
��Left=�5�      $	 0.5Q�5�      $��25��5�      $��63,0,0,0q�5�      6D     5�      $ FormTextboxPassword=�5�      $��Center=�5�      $��Center=�5�      
�������5�      5�      �� 5�      $	��250��5�      $��2��5�      
�������$	 0.5Q�5�      �� 5�      $ 
Horizontal=�6   $��0, 20 ,0 ,0q�66   .+�5�      �� -	   5        $ 	phone_txt��5�      $��Times New Roman)�5�      $��Light"�5�      $��Phone:��5�      $��20(�5�      $��Center=�5�      
�������
������ $��0q�5�      $	��235��5�      $
��Left=�5�      $	 0.5Q�5�      $��25��5�      $��63,0,0,0q�5�      6E     5�      $ Phone=�5�      $��Center=�5�      $��Center=�5�      
�������5�      5�      �� 5�      $	��250��5�      $��2��5�      
�������$	 0.5Q�5�      �� 5�      $ 
Horizontal=�6   $��0, 20 ,0 ,0q�66   .+�5�      �� -
   5        $ 	email_txt��5�      $��Times New Roman)�5�      $��Light"�5�      $��Email:��5�      $��20(�5�      $��Center=�5�      
�������
������ $��0q�5�      $	��235��5�      $
��Left=�5�      $	 0.5Q�5�      $��25��5�      $��63,0,0,0q�5�      6E     5�      $ Email=�5�      $��Center=�5�      $��Center=�5�      
�������5�      5�      �� 5�      $	��250��5�      $��2��5�      
�������$	 0.5Q�5�      �� 5     $ 
Horizontal=�6   $��0, 20 ,0 ,0q�66   .+�5     �� -   5        $ comment_txt��5     $��Times New Roman)�5     $��Light"�5     $��Comment:��5     $��20(�5     $��Center=�5	     
�������
������ $��0q�5     $	��235��5     $
��Left=�5     $	 0.5Q�5     $��25��5     $��63,0,0,0q�5     6G     5     $ Comment=�5     $��Center=�5     $��Center=�5     
�������5     5     �� 5     $	��250��5     $��2��5     
�������$	 0.5Q�5     �� 5"     $ 
Horizontal=�6   $��0, 14, 0, 0q�66   $��Center=�6K   .+�5#     �� -   5        $ add_btn��5#     $	��194��6.   $��40��6:   $��Add New Info��6F   $��18(�6]   $
��Bold"�6k   6}   5$     5&     5'     5(     5)     