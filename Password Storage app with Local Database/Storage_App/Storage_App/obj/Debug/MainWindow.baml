   M S B A M L   `   `   `  ����F  BStorage_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Storage_AppStorage_App  5   	       Storage_App.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Storage_App     5   	     � Title$  Log In Form��5   	    � 
ResizeMode$ CanResizeWithGrip=�6   $��279.453��6<   $��359.153��6M    � WindowStartupLocation$ CenterScreen=�6^   $
��Bold"�6�   $��14(�6�   ���	#FF061D6A���	#FFE2F56A � Icon$ mainWin.ico��6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��45* �6   �� 5      $	��44* �6   �� 5      $	��43* �6   �� 5      $��33 �6   �� 5      $��42 �6   �� 5      $��8.757 �6   �� 5      $��31 �6   �� 5      $��1 �6    � ColumnDefinitions 5   
   �� 5      $	��10* �6   �� 5      $��2* �6   �� 5      $	��94* �6   �� 5      $��9* �6   �� 5      $	��87* �6   �� 5      $	��34* �6   �� 5      $
��102* �6   �� 5      $��13 �6   .+�5"   
   �� $��Login:��6   $��21,3,1,9q�6!   $��16(�63   $
��Bold"�6A   $��1��6S   $��2��6`   �� 5#   
   $��	Password:��6   $	��1,0q�6$   $��16(�61   $
��Bold"�6?   $��2��6Q   $��2��6^   �� 5$   
   -   5        $��loginTxt��5$       �� TextWrapping$
 Wrap=�6"   $��24(�66   $��4��6D   $��1��6T   $��0,0,2,4q�6a   $��3��6r   G� 5%   
   -   5         G�Name$ passTxt��5%      $��0,0,2,2q�6'   $��24(�68   $��4��6F   $��2��6V   $��3��6c   �� 5&   
   -   5        $��okBtn��5&   "   $��Log in��6   $��0,2,2,0q�6/   $��20(�6@   $��Palatino Linotype)�6O   ���	#FF72F7EB$��4��6�   $��4��6�   $��2��6�   �� 5'   
   -   5         ��Name$ regBtn��5'   $   $��Register��6   $��0,1,1,1q�64   $��18(�6E   $��Palatino Linotype)�6S   	 J� RenderTransformOrigin$	 	0.48,0.58&�6r   ���	#FFAAF7AA$��6��6�   $��5��6�   $��2��6�   �� 5(   
   -   5        
 ��Name$
 rememberCheck��5(      $��Remember Me?��6*   $��3,12,8,1q�6A   ���	#FF03074C$��16(�6j   $��Times New Roman)�6x   $
��Bold"�6�   $��3��6�   $��5��6�   $��2��6�   5*      5+      