   M S B A M L   `   `   `  ����O  KGBUZhilishnikKuncevo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:GBUZhilishnikKuncevo.PagesGBUZhilishnikKuncevo.Pages  5      /    )GBUZhilishnikKuncevo.Pages.TotalCheckPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:GBUZhilishnikKuncevo.Pages     5        N� Title$  Чеки��5	      .��5      � 
�������.+�5   
   �� -   5        $��BtnBack��5      $��
Назад��5      ���#0850A4   MaterialDesignFlatButton#��[  5      $	��Top=�5      $��Right=�5      $��
0, 0, 0, 0q�5      �� 5   
   -   5        $��	TxbSearch��5      $	��Top=�5      $
��Left=�5      $R��LВведите номер лицевого счёта для поиска...��5        MaterialDesignTextBox#��[ 5      $	��250��5       �� 
CaretBrush �	#FF0850A4 �� SelectionBrush �	#FF0850A45      �� 5   
   -   5        $��	BtnSearch��5      $��Искать��5      ���#0850A4#��[  5!      $	��Top=�5"      $
��Left=�5#      $��260, 0, 0, 0q�5$      �� 5%   
   -   5        $��
BtnRefresh��5%      $��Обновить��5'      ���#0850A4#��[  5)      $	��Top=�5*      $��Right=�5+      $��0, 0, 75, 0q�5,      �� 5-   
   -   5        $��BtnAddTotalCheck��5-      $��Добавить��5.      ���#0850A4#��[  51      $	��Top=�52      $��Right=�53      $��0, 0, 180, 0q�54      &   System.Windows.Controls.DataGrid  55   
   -   5        $��DataTotalCheck��55         AutoGenerateColumns .     
IsReadOnly . $��0, 40, 0, 0q�58         Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 5<   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5;   %   �� *id+5<   %     5=      $
 ЛС��6%   $ * 5?   %    5>   %   �� *BankBook.bankBookNumber+5?   %     5@      $ Оплатить к��6%   $ * 5B   %    5A   %   �� *requiredPaymentDate+	 �� StringFormat$	 
dd/MM/yyyy��5B   %     5C      $ Оплачено��6%   $ * 5E   %    5D   %   �� *paymentDate+$	 
dd/MM/yyyy��5E   %     5F      $ Льгота��6%   $ * 5H   %    5G   %   �� *Benefit.benefitName+5H   %     5I      $ Пени��6%   $ * 5K   %    5J   %   �� *fine+5K   %     5L      $ К оплате��6%   $ * 5N   %    5M   %   �� *totalPayble+5N   %     5O      $ Статус��6%   $	 200 5Q   %    5P   %   �� *PaymentState.paymentStateName+5Q   %   5S      5T      5U      