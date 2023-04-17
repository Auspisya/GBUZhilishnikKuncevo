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
    /// Логика взаимодействия для ClientAddPage.xaml
    /// </summary>
    public partial class ClientAddPage : Page
    {
        public ClientAddPage()
        {
            InitializeComponent();

            //Заполняем поле выбора данными из БД
            CmbGender.DisplayMemberPath = "genderName";
            CmbGender.SelectedValuePath = "id";
            CmbGender.ItemsSource = DBConnection.DBConnect.Gender.ToList();
        }

        /// <summary>
        /// Возвращаемся назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.GoBack();
        }

        /// <summary>
        /// Добавляем нового пользователя в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Passport passport = new Passport()
                {
                    passportNumber = TxbPassportNumber.Text,
                    passportSeries = TxbPassportSeries.Text,
                    passportIssuedBy = TxbPassportIssuedBy.Text,
                    placeOfBirth = TxbPlaceOfBirth.Text,
                    dateOfIssue = DateTime.Parse(DPDateOfIssue.Text),
                    divisionCode = TxbDivisionCode.Text
                };

                SNILS snils = new SNILS()
                { 
                    snilsNumber = TxbSNILS.Text,
                    registrationDate = DateTime.Parse(DPSNILSRegistationDate.Text)
                };

                TIN tin = new TIN()
                {
                    tinNumber = TxbTIN.Text,
                    whoRegistered = TxbWhoRegisteredTIN.Text,
                    registrationDate = DateTime.Parse(DPTINRegistrationDate.Text)
                };

                Client client = new Client()
                {
                    Gender = CmbGender.SelectedItem as Gender,
                    name = TxbName.Text,
                    surname = TxbSurname.Text,
                    patronymic = TxbPatronymic.Text,
                    phoneNumber = TxbPhoneNumber.Text,
                    dateOfBirth = DateTime.Parse(DPDateOfBirth.Text),
                    passportId = passport.id,
                    snilsId = snils.id,
                    tinId = tin.id
                };
                DBConnection.DBConnect.Client.Add(client);
                DBConnection.DBConnect.Passport.Add(passport);
                DBConnection.DBConnect.TIN.Add(tin);
                DBConnection.DBConnect.SNILS.Add(snils);
                DBConnection.DBConnect.SaveChanges();
                MessageBox.Show("Данные успешно добавлены!",
                    "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                Navigation.frameNav.GoBack();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    "Критическая ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }
    }
}
