   M S B A M L   `   `   `  ����G  COgrencimatik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:OgrencimatikOgrencimatik  5   	       Ogrencimatik.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Ogrencimatik     5   	     � Title$   Ogrencimatik - Üye Giriş��5   	   $��632.407��6*   $��722.057��6;    � Icon$ ogrencimatiklg.png��6K   .��5	      � $��1,4,3,0q�6    J� RenderTransformOrigin$ 0.5,0.5&�6   $	��597��6<   $	��Top=�6I   z�5
   
   V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.121Q�6"   T� 5      5      ��5   
   �� 5       � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ txtAd��5      $
��Left=�6!   $��50��6<   $��216,265,0,0q�6H    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��374��6�   $��38(�6�    �� IsUndoEnabled .  	 J� IsManipulationEnabled	 . 4  .System.Windows.Automation.AutomationProperties
   Name$
 txtAd��6�   $��1��6�   �� 5   
   -   5         ��Name$ image��5      $	��219��6   $��114,41,90,0q�6,   $	��Top=�6A   $��ogrencimatiklg.png��6Y   $��Center=�6u   �� 5   
   -   5         ��Name$ btnGiris��5      $��Giriş��6#   $
��Left=�63   $��170,413,0,0q�6N   $	��Top=�6c   $	��180��6{   $��46��6�   $��32(�6�   $��MS Reference Sans Serif)�6�   $
 btngiris��6�   $��3��6   �� 5   
   -   5        $ btnIptal��5      $��İptal��6#   $
��Left=�63   $��370,413,0,0q�6N   $	��Top=�6c   $	��180��6{   $��46��6�   $��MS Reference Sans Serif)�6�   $��32(�6�   $
 btniptal��6�   ��. $��4��6&  �� 5   
   -   5        $ button2��5      $��Center=�6"   $��264,477,242,0q�6?   $	��Top=�6V   $	��172��6n   $	��120��6z   ��. ��6�   Z� ��6�   Z� ��5       �� 5!       �� ImageSource$ 	cikis.png��6   5#      �� 5$   
   -   5         ��Name$ label��5$      $��Kullanıcı Adı

��6   $
��Left=�6K   $��
10,265,0,0q�6f   $	��Top=�6z   $	��194��6�   $��50��6�   $��30(�6�   $��MS Reference Sans Serif)�6�   �� 5%   
   -   5        $ label1��5%      $��Şifre��6    $
��Left=�60   $��
60,333,0,0q�6K   $	��Top=�6_   $��50��6w   $��96��6�   $��30(�6�   $ 0.5,0.5&�6�   $��MS Reference Sans Serif)�6�   z�5&      V� 5'      .~�5(      �� �� 5)      �� 5*      $ 0.654Q�6&   T� 5+      5,      5.      G� 5/   
   -   5         G�Name$ txtSifre��5/      $
��Left=�6(   $��216,336,0,0q�6C   $	��Top=�6X   $��50��6p   $	��374��6|   $��38(�6�   $
 txtSifre��6�   $��2��6�   �� 50   
   -	   5        $ button��50      $��Button��6!   $
��Left=�62   $��604,336,0,0q�6M   $	��Top=�6b   $��52��6z   $��50��6�   ��6�   Z� ��6�   Z� ��51      �� 52      $ 
locker.png��6    j� Stretch$
 None=�66   54      56      57      