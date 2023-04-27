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
    /// Логика взаимодействия для BankBookEditPage.xaml
    /// </summary>
    public partial class BankBookEditPage : Page
    {
        public BankBookEditPage(BankBook bankBook)
        {
            InitializeComponent();

            #region Наполняем элементы управления данными из БД по выбранной записи
            //Наполняем поля выбора из БД
            CmbClient.DisplayMemberPath = "fullName";
            CmbClient.SelectedValuePath = "id";
            CmbClient.ItemsSource = DBConnection.DBConnect.Client.ToList();
            CmbClient.Text = bankBook.Client.fullName.ToString();

            CmbOwnership.DisplayMemberPath = "typeName";
            CmbOwnership.SelectedValuePath = "id";

            #endregion
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
