   M S B A M L   `   `   `  ����M  IPersonalMapManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:PersonalMapManager.windowPersonalMapManager.window  5   	   .    (PersonalMapManager.window.PolylineWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:PersonalMapManager.window     5   	   -   5          � Title$  Polyline��5   	   $	��550��5	      $	��500��5
       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5      .��5      � $	��521��6   $��Bottom=�6   .+�5      �� ��5      �� 5      .��5      �  � Color$ #0935e6��6    � Offset$	 0.0Q�6$   � 5      $ #5c6bab��6   $ 1Q�6$   5      5      �� 5      $��	Polyline:��6
   $��20,20,20,451q�6   $��Unispace)�64   $��24(�6J   $
��Left=�6X   $��Center=�6z   �� 5      $��Couleur:��6
   $��20,70,192,411q�6   $��Unispace)�64   $��22(�6J   $
��Left=�6X   $��Center=�6z   �� 5      $��
Epaisseur:��6
   $��20,115,175,366q�6   $��Unispace)�67   $��22(�6M   $
��Left=�6[   $��Center=�6}   �� 5      $��Description:��6
   $��20,160,175,321q�6!   $��Unispace)�69   $��22(�6O   $
��Left=�6]   $��Center=�6   �� 5      -   5         ��Name$ ComboBoxColors��5      $��Center=�6F   $��192,70,20,411q�6h   $��Unispace)�6   $��18(�6�   
������ 
�������
�������$��1q�6�    �� SelectedItem 6%   �� *	Couleur+6�   �� 5      $��Unispace)�6'   $��22(�6=   $��192,115,20,366q�6K   $��Center=�6c   $��Center=�6�   
������ 
�������
�������$��1q�6�   ��6   �� *	Epaisseur+6�   �� 5       $��Unispace)�6)   $��22(�6?   $��192,160,20,321q�6M   $
��Left=�6e   $��Center=�6�   
������ 
�������
�������$��1q�6�   ��6   �� *Description+6�   �� 5"      $��Coordonnee:��6
   $��20,210,175,278q�6    $��Unispace)�68   $��22(�6N   $
��Left=�6\   $��Center=�6~   �� 5$      $��	Latitude:��6
   $��40,248,175,238q�6   $��Unispace)�66   $��18(�6L   $
��Left=�6Z   $��Center=�6|   �� 5%      $��
Longitude:��6
   $��40,288,155,198q�6   $��Unispace)�67   $��18(�6M   $
��Left=�6[   $��Center=�6}   �� 5&      $��Description:��6
   $��40,327,155,159q�6!   $��Unispace)�69   $��18(�6O   $
��Left=�6]   $��Center=�6   �� 5(      $��Unispace)�6&   $��18(�6<   $��192,248,175,238q�6J   $��Center=�6c   $��Center=�6�   
������ 
�������
�������$��1q�6�   ��6   �� *
Latitude+6�   �� 5)      $��Unispace)�6'   $��18(�6=   $��192,287,175,199q�6K   $��Center=�6d   $��Center=�6�   
������ 
�������
�������$��1q�6�   ��6   �� *	Longitude+6�   �� 5*      $��Unispace)�64   $��18(�6J   $��192,328,20,158q�6X   $��Center=�6p   $��Center=�6�   
������ 
�������
�������$��1q�6�   ��6   �� *DescriptionCoordonnees+6�   �� 5,      -   5         ��Name$ ButtonAjouter��5,      $��344,248,20,238q�6>   $��Ajouter��6V   $��Unispace)�6h   $��18(�6~   $��Center=�6�   $��Center=�6�   
��� � �6�   �� 5-      -   5        $ ButtonRetirer��5-      $��344,287,20,199q�6>   $��Retirer��6V   $��Unispace)�6h   $��18(�6~   $��Center=�6�   $��Center=�6�   
���  ��6�   �� 5/      -   5         ��Name$ ListBoxCoordonnees��5/      $��20,384,20,62q�6(   �� 52      -   5        $ ButtonAnnuler��52      $��Annuler��6>   $��
20,0,20,20q�6P   $��70��6d   $��30��6o   $��Bottom=�6{   $
��Left=�6�   
���  ��
���   �$��2q�6�   $��14(�6�   $��Unispace)�6�   $��Center=�6  $��Center=�62  �� 53      -   5        $ ButtonAppliquer��53      $��	Appliquer��6B   $��
20,0,20,20q�6V   $��90��6j   $��30��6u   $��Bottom=�6�   $��Center=�6�   
��� � �
���   �$��2q�6�   $��14(�6�   $��Unispace)�6  $��Center=�6  $��Center=�6<  �� 54      -   5        $ ButtunOk��54      $��Ok��64   $��
20,0,20,20q�6A   $��70��6U   $��30��6`   $��Bottom=�6l   $��Right=�6�   
������ 
���   �$��2q�6�   $��14(�6�   $��Unispace)�6�   $��Center=�6  $��Center=�6,  56      57      