   M S B A M L   `   `   `  ����F  BStorage_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Storage_AppStorage_App  5   	       Storage_App.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Storage_App     5   	     � Title$  Log In Form��5   	   $��275.219��6   $��359.153��6.    � WindowStartupLocation$ CenterScreen=�6>   $
��Bold"�6c   $��14(�6u   ���	#FF061D6A���	#FFE2F56A.��5	      � $��0,0,-0.2,-0.6q�6    � ColumnDefinitions 5
   
   �� 5      $
��102* �6   �� 5      $
��128* �6   �� 5      $
��110* �6   �� 5      $	��11* �6    � RowDefinitions 5   
   �� 5      $	��31* �6   �� 5      $
��108* �6   �� 5      $	��82* �6   .+�5   
   �� $��Login:��6   $
��Left=�6!   $��40,0,0,0q�6<   $	��Top=�6N   $��16(�6f   $��1��6t   $��32��6�   $��57��6�   $
��Bold"�6�   �� 5   
   $��	Password:��6   $
��Left=�6$   $��
10,47,0,41q�6?   $��16(�6S   $��1��6a   $��87��6n   $
��Bold"�6y   �� 5   
   -   5        $��loginTxt��5   .   $
��Left=�6   $��40��6>   $��0,1,0,0q�6J    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��222��6�   $��24(�6�   $��1��6�   $��1��6�   $��2��6�   G� 5   
   -   5         G�Name$ passTxt��5      $
��Left=�6'   $��40��6B   $��0,46,0,0q�6N   $	��Top=�6a   $	��222��6y   $��24(�6�   $��1��6�   $��1��6�   $��2��6�   �� 5   
   -   5        $��okBtn��5   "   $��Log in��6   $
��Left=�60   $��0,3,0,0q�6K   $	��Top=�6\   $	��120��6t   $��40��6�   $��20(�6�   $��2��6�   $��Palatino Linotype)�6�   $��1��6�   ���	#FF72F7EB6�   �� 5   
   -   5         ��Name$ regBtn��5   $   $��Register��6   $
��Left=�65   $��	0,55,-1,0q�6P   $	��Top=�6c   $	��352��6{   $��30��6�   $��18(�6�   $��2��6�   $��Palatino Linotype)�6�    J� RenderTransformOrigin$ 	0.48,0.58&�6�   $��4��6  ���	#FFAAF7AA6  �� 5   
   -   5         ��Name$ rememberCheck��5      $��Remember Me?��6*   $��1��6A   $
��Left=�6Q   $��18��6l   $��	93,91,0,0q�6x   $��1��6�   $	��Top=�6�   ���	#FF03074C$��16(�6�   $��Times New Roman)�6�   $
��Bold"�6�   $	��129��6  $��2��6  5      5      