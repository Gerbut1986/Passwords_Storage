   M S B A M L   `   `   `  ���� O  KStorageInfoApp_Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:StorageInfoApp_FinalStorageInfoApp_Final  +    %StorageInfoApp_Final.Windows.Register   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     e aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a^	 ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af
 bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks     	 
                 Xlocal"clr-namespace:StorageInfoApp_Final     	 
                 -     � Title$  LoginWindow��$��640.909��$	��382�� � AllowsTransparency . 
������  � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�.��� .+��  � RowDefinitions �� $	��200 ��� .+���  �� CornerRadius$ 10��$��2��$��0,0,1,0q�._��� -    ��Name$ 	close_btn��$��X��$��344,4,3,607q����� .���  � Color$
 Blue�� � Offset$	 0.0Q�� $ #f083da��$ 1Q��� $	��top=�$	��119��$��0,8,0,0q�.+��� $��icon_register.png��$��129,0,131,0q�$	��115���� $��Bottom=�$��80��$��0,0,0,2q�.+��� $��Register��$��Light"�$��Palatino Linotype)�$��22(�$��Center=����� 	 �� EndPoint$	 0.5,1&�
 �� 
StartPoint$
 0.5,0&�.��� $ Black��$ 0Q�� $ 	#FF18AAAA��$ 1Q��� $��Sign Up��$��Heavy"�$��Palatino Linotype)�$��33(�$��Center=����� $	 0.5,1&�$
 0.5,0&�.��� $ Black��$ 0Q�� $ White��$ 1Q��� $��1��.+���  �� Orientation$ 
Horizontal=�$��0, 20, 0, 0q�.+��� -    ��Name$ 	fName_txt��$��Times New Roman)�$��Light"�$��First Name:��$��20(�$��Center=�
�������
������ $��0q�$	��235��$
��Left=� J� Opacity$	 0.5Q�$��25��$��63,0,0,0q�.  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ Account=�$��Center=�$��Center=�
��������� $	��250��$��2��
�������$	 0.5Q��� $ 
Horizontal=�$��0,20,0,0q�.+��� -   $ 	lName_txt��$��Times New Roman)�$��Light"�$��
Last Name:��$��20(�$��Center=�
�������
������ $��0q�$	��235��$
��Left=�$	 0.5Q�$��25��$��63,0,0,0q�  $ Account=�$��Center=�$��Center=�
��������� $	��250��$��2��
�������$	 0.5Q��� $ 
Horizontal=�$��0, 20 ,0 ,0q�.+��� -   $ age_txt��$��Times New Roman)�$��Light"�$
��Age:��$��20(�$��Center=�
�������
������ $��0q�$	��235��$
��Left=�$	 0.5Q�$��25��$��63,0,0,0q�  $ Account=�$��Center=�$��Center=�
��������� $	��250��$��2��
�������$	 0.5Q��� $ 
Horizontal=�$��0, 20 ,0 ,0q�.+��� -   $ 	login_txt��$��Times New Roman)�$��Light"�$��Login:��$��20(�$��Center=�
�������
������ $��0q�$	��235��$
��Left=�$	 0.5Q�$��25��$��63,0,0,0q�  $ Account=�$��Center=�$��Center=�
��������� $	��250��$��2��
�������$	 0.5Q��� $ 
Horizontal=�$��0, 20 ,0 ,0q�.+��� -   $ pass_txt��$��Times New Roman)�$��Light"�$��	Password:��$��20(�$��Center=�
�������
������ $��0q�$	��235��$
��Left=�$	 0.5Q�$��25��$��63,0,0,0q�  $ Account=�$��Center=�$��Center=�
��������� $	��250��$��2��
�������$	 0.5Q��� $ 
Horizontal=�$��0, 20 ,0 ,0q�.+��� -   $ 	phone_txt��$��Times New Roman)�$��Light"�$��Phone:��$��20(�$��Center=�
�������
������ $��0q�$	��235��$
��Left=�$	 0.5Q�$��25��$��63,0,0,0q�  $ Account=�$��Center=�$��Center=�
��������� $	��250��$��2��
�������$	 0.5Q��� $ 
Horizontal=�$��0, 20 ,0 ,0q�.+��� -	   $ 	email_txt��$��Times New Roman)�$��Light"�$��Email:��$��20(�$��Center=�
�������
������ $��0q�$	��235��$
��Left=�$	 0.5Q�$��25��$��63,0,0,0q�  $ Account=�$��Center=�$��Center=�
��������� $	��250��$��2��
�������$	 0.5Q��� $ 
Horizontal=�$��0, 20 ,0 ,0q�.+��� -
   $ role_txt��$��Times New Roman)�$��Light"�$��Role:��$��20(�$��Center=�
�������
������ $��0q�$	��235��$
��Left=�$	 0.5Q�$��25��$��63,0,0,0q�  $ Account=�$��Center=�$��Center=�
��������� $	��250��$��2��
�������$	 0.5Q��� $ 
Horizontal=�$��0, 14, 0, 0q�$��Center=�.+��� -   $ reg_btn��$	��194��$��40��$��Create Account��$��18(�$
��Bold"�