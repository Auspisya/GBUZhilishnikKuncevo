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
    /// Логика взаимодействия для ClientEditPage.xaml
    /// </summary>
    public partial class ClientEditPage : Page
    {
        private int clientId;

        public ClientEditPage(Client client)
        {
            InitializeComponent();
            //Заполняем текстовые блоки готовыми данными из БД
            TxbName.Text = client.name.ToString();
            TxbSurname.Text = client.surname.ToString();
            TxbPatronymic.Text = client.patronymic.ToString();
            TxbDivisionCode.Text = client.Passport.divisionCode.ToString();
            TxbPassportIssuedBy.Text = client.Passport.passportIssuedBy.ToString();
            TxbPassportNumber.Text = client.Passport.passportNumber.ToString();
            TxbPassportSeries.Text = client.Passport.passportSeries.ToString();
            TxbPhoneNumber.Text = client.phoneNumber.ToString();
            TxbPlaceOfBirth.Text = client.Passport.placeOfBirth.ToString();
            TxbTIN.Text = client.TIN.tinNumber.ToString();
            TxbWhoRegisteredTIN.Text = client.TIN.whoRegistered.ToString();
            TxbSNILS.Text = client.SNILS.snilsNumber.ToString();
            //Заполняем поля для выбора готовыми данными из БД
            CmbGender.DisplayMemberPath = "genderName";
            CmbGender.SelectedValuePath = "id";
            CmbGender.ItemsSource = DBConnection.DBConnect.Gender.ToList();
            CmbGender.Text = client.Gender.genderName.ToString();
            //Заполняем дата-пикеры готовыми данными из БД
            DPDateOfBirth.Text = client.dateOfBirth.ToString();
            DPDateOfIssue.Text = client.Passport.dateOfIssue.ToString();
            DPTINRegistrationDate.Text = client.TIN.registrationDate.ToString();
            DPSNILSRegistationDate.Text = client.SNILS.registrationDate.ToString();

            //Присваиваем ID квартиросъёмщика, которого выбрали, чтобы использовать в дальнейшем
            clientId = client.id;
        }

        /// <summary>
        ///  Вносим изменения в базу данных или отказываемся от этого действия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите внести изменения?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {

            }
            else
            {
                //Подключаемся к БД
                menshakova_publicUtilitiesEntities context = new menshakova_publicUtilitiesEntities();
                //Берем значения из элементов управления и вносим их в базу данных
                var client = context.Client.Where(c => c.id == clientId).FirstOrDefault();
                client.surname = TxbSurname.Text;
                client.name = TxbName.Text;
                client.patronymic = TxbPatronymic.Text;
                client.phoneNumber = TxbPhoneNumber.Text;
                client.genderId = (CmbGender.SelectedItem as Gender).id;
                client.dateOfBirth = DateTime.Parse(DPDateOfBirth.Text);
                client.Passport.placeOfBirth = TxbPlaceOfBirth.Text;
                client.Passport.passportNumber = TxbPassportNumber.Text;
                client.Passport.passportSeries = TxbPassportSeries.Text;
                client.Passport.passportIssuedBy = TxbPassportIssuedBy.Text;
                client.Passport.divisionCode = TxbDivisionCode.Text;
                client.Passport.dateOfIssue = DateTime.Parse(DPDateOfIssue.Text);
                client.TIN.tinNumber = TxbTIN.Text;
                client.TIN.whoRegistered = TxbWhoRegisteredTIN.Text;
                client.TIN.registrationDate = DateTime.Parse(DPTINRegistrationDate.Text);
                client.SNILS.snilsNumber = TxbSNILS.Text;
                client.SNILS.registrationDate = DateTime.Parse(DPSNILSRegistationDate.Text);
                //Сохраняем данные в БД
                context.SaveChanges();
                //Возвращаемся обратно
                Navigation.frameNav.GoBack();
            }
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
    }
}
