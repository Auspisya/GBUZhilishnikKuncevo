   M S B A M L   `   `   `  ����O  KGBUZhilishnikKuncevo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:GBUZhilishnikKuncevoGBUZhilishnikKuncevo  5   	   %    GBUZhilishnikKuncevo.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:GBUZhilishnikKuncevo     5   	     � Title$9  3ГБУ Жилищник Района Кунцево��5	   	   $	��600��6-   $
��1200��6=   $	��600��5
   	   $
��1200��6    � Icon$% ./Icons/gerb_kuncevo_moskva.jpg��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � ���#EFEFEF � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   ��  �� CornerRadius$ 1��6   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6#      Color$ 	LightGray��5   #      ShadowDepth$ 0Q�5   #   ._�5      �� 
�������	 �� Orientation$	 
Horizontal=�5      $��2q�5      .+�5      �� $%��./Icons/gerb_kuncevo_moskva.jpg��6   $��50��5      $��50��5      �� 5          MaterialDesignBody1TextBlock#��[  5       $��Center=�5!      $��30(�5"      ���#045E30��5      �� 
 �� ElementName$
 	MainFrame�� �� Path$ Content.Title�5#      5$      5%      �� 5'   
   $��1��6   $��5q�5(      $
��Left=�5)      $	��250��5*      $	��480��5+      
�������$ 20��5-       5.        5/      $ 20Q�6#   $ 	LightGray��50   #   $ 0Q�51   #   ._�53      �� $��6q�6   .+�54      �� $��Меню��6    �� TextAlignment$ Center=�55      $��25(�56      ���#045E30$��0, 10, 0, 10q�58      �� 59      -   5        $��BtnClientPage��59        MaterialDesignFlatButton#��[ 5;      $&�� Квартиросъёмщики��5<      ���#0850A4$��20(�5>      $��
0, 0, 0, 5q�5?      $��40��5@       � Cursor$
 Hand��5A      �� 5B      -   5        $��BtnBankBookPage��5B      #��[ 5D      $��Лицевые счета��5E      ���#0850A4$��20(�5G      $��
0, 0, 0, 5q�5H      $��40��5I      $
 Hand��5J      �� 5K      -   5        $��BtnCounterPage��5K      #��[ 5M      $��Счётчики��5N      ���#0850A4$��20(�5P      $��40��5Q      $��
0, 0, 0, 5q�5R      �� 5S      -   5        $��BtnAccountingPage��5S      #��[ 5U      $��Показания��5V      ���#0850A4$��20(�5X      $��40��5Y      $��
0, 0, 0, 5q�5Z      $
 Hand��6-   �� 5[      -   5        $��BtnServiceCheckPage��5[      #��[ 5]      $��Квитанции��5^      ���#0850A4$��20(�5`      $��40��5a      $��
0, 0, 0, 5q�5b      �� 5c      -   5        $��BtnDebtPage��5c      #��[ 5e      $��Должники��5f      ���#0850A4$��20(�5h      $��40��5i      $��
0, 0, 0, 5q�5j      $
 Hand��6-   5k      5l      �� 5n   
   $��1��6   $��5q�5o      $��Right=�5p      $	��900��5q      $	��480��5r      
�������$ 20��5t       5u        5v      $ 20Q�6#   $ 	LightGray��5w   #   $ 0Q�5x   #   ._�5z       � -   5          �Name$ 	MainFrame��5z      $��6q�5{        � NavigationUIVisibility$ Hidden=�5|      5}      5~      5      