using GBUZhilishnikKuncevo.Classes;
using GBUZhilishnikKuncevo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GBUZhilishnikKuncevo.Pages
{
    /// <summary>
    /// Логика взаимодействия для BankBookPage.xaml
    /// </summary>
    public partial class BankBookPage : Page
    {
        public BankBookPage()
        {
            InitializeComponent();

            DataBankBook.ItemsSource = null;
            DataBankBook.ItemsSource = DBConnection.DBConnect.BankBook.ToList();
        }
        /// <summary>
        /// Убирает подсказку из поисковика
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxbSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbSearch.Text = "";
        }
        /// <summary>
        /// Поиск по лицевому счёту, наполняет таблицу результатами поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxbSearch.Text != "")
                {
                    string searchString = TxbSearch.Text;

                    var itemsList = DBConnection.DBConnect.BankBook.ToList();

                    var searchResults = itemsList.Where(item => item.bankBookNumber.Contains(searchString)).ToList();
                    DataBankBook.ItemsSource = searchResults.ToList();
                }
                else
                {
                    DataBankBook.ItemsSource = DBConnection.DBConnect.BankBook.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        /// <summary>
        /// Обновляет таблицу актуальными записями из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            DataBankBook.ItemsSource = null;
            DataBankBook.ItemsSource = DBConnection.DBConnect.BankBook.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new BankBookAddPage());
        }

        private void BtnEditInfo_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new BankBookEditPage((sender as Button).DataContext as BankBook));
        }
    }
}
