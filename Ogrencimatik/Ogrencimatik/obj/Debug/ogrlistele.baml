   M S B A M L   `   `   `  ����G  COgrencimatik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:OgrencimatikOgrencimatik  5   	       Ogrencimatik.ogrlistele   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ` \Xceed.Wpf.Toolkit, Version=3.3.17121.18230, Culture=neutral, PublicKeyToken=ba83ff368b7563c64xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   
   &localclr-namespace:Ogrencimatik  5   	     � Title$&   Ogrencimatik - Öğrenci Listele��5	   	   $��578.865��60   $��935.515��6A   .��5
      � $��0,0,0,6q�6   .+�5   
   �� -   5         ��Name$ button��5      $�� ��6!   $
��Left=�6,   $��	24,25,0,0q�6G   $	��Top=�6Z   $	��116��6r   $	��107��6~   ��6�   Z� ��6�   Z� ��5      �� 5       �� ImageSource$ geri-don.png��6   5      �� 5   
   -   5        $ ogrlsls��5      $��LİSTELE��6"   $
��Left=�64   $��
586,25,0,0q�6O   $	��Top=�6c   $	��146��6{   $��92��6�   $��Segoe UI Black)�6�   $��24(�6�   ���	#FF3498DB���	#FF2980B9��6�   Z� 6  �� 5   
   -   5        $ btnogrlskyt��5      $��Kayıt
Penceresi��6&   $
��Left=�6I   $��
750,25,0,0q�6d   $	��Top=�6x   $	��150��6�   $��92��6�   ���	#FF2980B9���	#FF3498DB$��Segoe UI Black)�6�   $��24(�6	  ��6�   Z� 6	  �� 5   
   -   5        $ btnogrlssil��5      $��Öğrenci
     Sil
��6&   $
��Left=�6T   $��685,172,0,0q�6o   $	��Top=�6�   $	��142��6�   $��73��6�   ���	#FFC0392B���	#FFE74C3C$��Segoe UI Black)�6�   $��24(�6  ��6�   Z� 6$  �� 5   
   -   5         ��Name$ groupBox��5      $��Öğrenci Arama��6%   $
��Left=�6<   $��
10,142,0,0q�6W   $	��Top=�6k   $	��120��6�   $	��467��6�   ���	#FF27AE60$��18(�6�   .��5      �� -   5         ��Name$ txtogrlsnara��5      $
��Left=�6,   $��54��6G   $��	10,24,0,0q�6S    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $��60��6�   5      �� 5   
   -   5        $ txtogrlsara��5      $
��Left=�6'   $��54��6B   $��
96,190,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��362��6�   6�   �� 5   
   -   5         ��Name$ label��5      $��No��6   $
��Left=�6,   $��
39,166,0,0q�6G   $	��Top=�6[   $��18(�6s   ���	#FF27AE60 J� RenderTransformOrigin$ 0.412,0.103&�6�   �� 5   
   -	   5        $ label1��5      $��İsim��6    $
��Left=�6/   $��125,166,0,0q�6J   $	��Top=�6_   $��18(�6w   ���	#FF27AE60$ 
0.69,0.368&�6�   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ dataGrid��5      $
��Left=�6%   $	��246��6@   $��
10,286,0,0q�6M   $	��Top=�6a   $	��908��6y   6�   5      5      