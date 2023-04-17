using GBUZhilishnikKuncevo.Classes;
using GBUZhilishnikKuncevo.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            //Обнуляем таблицу, затем добавляем в нее данные
            DataClient.ItemsSource = null;
            DataClient.ItemsSource = DBConnection.DBConnect.Client.ToList();
        }

        private void BtnShowInfo_Click(object sender, RoutedEventArgs e)
        {
            //В зависимости от выбранной строки, передаём её данные на следующую страницу и используем там
            Navigation.frameNav.Navigate(new ClientInfoPage((sender as Button).DataContext as Client));
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (TxbSearch.Text != "")
                {
                    string searchString = TxbSearch.Text.ToLower();

                    var itemsList = DBConnection.DBConnect.Client.ToList();

                    //Ищем совпадения в таблице по фамилии
                    var searchResults = itemsList.Where(item => item.surname.ToLower().Contains(searchString)).ToList();

                    //Заполняем таблицу записями, где есть совпадения
                    DataClient.ItemsSource = searchResults.ToList();
                }
                else {
                    DataClient.ItemsSource = DBConnection.DBConnect.Client.ToList();
                }
                

            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void TxbSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            //Убираем подпись
            TxbSearch.Text = "";
        }

        private void BtnEditInfo_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new ClientEditPage((sender as Button).DataContext as Client));
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            //Обновляем таблицу. При редактировании данных придется перезапустить приложение
            DataClient.ItemsSource = null;
            DataClient.ItemsSource = DBConnection.DBConnect.Client.ToList();
        }
    }
}
