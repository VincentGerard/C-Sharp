   M S B A M L   `   `   `  ����M  IPersonalMapManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:PersonalMapManager.windowPersonalMapManager.window  5   	   )    #PersonalMapManager.window.PoiWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:PersonalMapManager.window     5   	   -   5          � Title$  Point Of Interest (POI)��5   	   $	��450��5	      $	��350��5
       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5      .��5      � .+�5      �� ��5      �� 5      .��5      �  � Color$ #0935e6��6    � Offset$	 0.0Q�6$   � 5      $ #5c6bab��6   $ 1Q�6$   5      5      �� 5      $��Point of Interest:��6
   $��20,20,20,351q�6'   $��Unispace)�6=   $��24(�6S   $
��Left=�6a   $��Center=�6�   �� 5      $��	Latitude:��6
   $��20,89,170,287q�6   $��Unispace)�65   $��22(�6K   $
��Left=�6Y   $��Center=�6{   �� 5      $��
Longitude:��6
   $��20,134,170,242q�6   $��Unispace)�67   $��22(�6M   $
��Left=�6[   $��Center=�6}   �� 5      $��Description:��6
   $��20,210,144,166q�6!   $��Unispace)�69   $��22(�6O   $
��Left=�6]   $��Center=�6   �� 5      -   5         ��Name$ TextBoxLatitude��5      $��179,94,20,287q�6@   
������ 
�������$��1q�6�   $��Unispace)�6�   $��20(�6�   $��Center=�6�   $��Center=�6�   
���������6&   �� *
Latitude+6  �� 5      -   5        $ TextBoxLongitude��5      $��179,139,20,242q�6A   
������ 
�������$��1q�6�   $��Unispace)�6�   $��20(�6�   $��Center=�6�   $��Center=�6�   
���������6&   �� *	Longitude+6  �� 5       -   5        $ TextBoxDescription��5        �� TextWrapping$ WrapWithOverflow=�6E   $��20,255,20,105q�6e   
������ 
�������$��1q�6�   $��Unispace)�6�   $��15(�6�   $
��Left=�6�   $	��Top=�6  $��1q�6"  
���������6(   �� *Description+6.  �� 5"      -   5         ��Name$ ButtonAnnuler��5"      $��Annuler��6>   $��
20,0,20,20q�6P   $��70��6d   $��30��6o   $��Bottom=�6{   $
��Left=�6�   
���  ��
���   �$��2q�6�   $��14(�6�   $��Unispace)�6�   $��Center=�6  $��Center=�62  �� 5#      -   5        $ ButtonAppliquer��5#      $��	Appliquer��6B   $��
20,0,20,20q�6V   $��90��6j   $��30��6u   $��Bottom=�6�   $��Center=�6�   
��� � �
���   �$��2q�6�   $��14(�6�   $��Unispace)�6  $��Center=�6  $��Center=�6<  �� 5$      -   5        $ ButtunOk��5$      $��Ok��64   $��
20,0,20,20q�6A   $��70��6U   $��30��6`   $��Bottom=�6l   $��Right=�6�   
������ 
���   �$��2q�6�   $��14(�6�   $��Unispace)�6�   $��Center=�6  $��Center=�6,  5&      5'      