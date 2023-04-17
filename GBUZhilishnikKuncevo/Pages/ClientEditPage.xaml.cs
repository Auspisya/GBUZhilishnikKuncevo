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
            //Заполняем поля для выбора готовыми данными из БД
            CmbGender.SelectedItem = client.Gender.genderName;
            CmbGender.DisplayMemberPath = "genderName";
            CmbGender.SelectedValuePath = "id";
            CmbGender.ItemsSource = DBConnection.DBConnect.Gender.ToList();
            //Заполняем дата-пикеры готовыми данными из БД
            DPDateOfBirth.Text = client.dateOfBirth.ToString();
            DPDateOfIssue.Text = client.Passport.dateOfIssue.ToString();

            clientId = client.id;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите внести изменения?", " ", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                Navigation.frameNav.GoBack();
            }
            else
            {
                menshakova_publicUtilitiesEntities context = new menshakova_publicUtilitiesEntities();

                var client = context.Client.Where(c => c.id == clientId).FirstOrDefault();
                client.surname = TxbSurname.Text;
                client.name = TxbName.Text;
                client.patronymic = TxbPatronymic.Text;
                client.phoneNumber = TxbPhoneNumber.Text;
                client.genderId = (CmbGender.SelectedItem as Gender).id;
                client.dateOfBirth = DateTime.Parse(DPDateOfBirth.Text);
                client.Passport.placeOfBirth = TxbPlaceOfBirth.Text;

                context.SaveChanges();
                Navigation.frameNav.GoBack();
            }
        }
    }
}
