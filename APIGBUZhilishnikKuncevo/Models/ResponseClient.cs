using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIGBUZhilishnikKuncevo.Models
{
    public class ResponseClient
    {
        public ResponseClient(Client client) 
        {
            surname = client.surname;
            name = client.name;
            patronymic = client.patronymic;
            genderName = client.Gender.genderName;
            dateOfBirth = client.dateOfBirth;
            phoneNumber = client.phoneNumber;
            passportSeries = client.Passport.passportSeries;
            passportNumber = client.Passport.passportNumber;
            passportIssuedBy = client.Passport.passportIssuedBy;
            dateOfIssue = client.Passport.dateOfIssue;
            divisionCode = client.Passport.divisionCode;
            placeOfBirth = client.Passport.placeOfBirth;
            snilsNumber = client.SNILS.snilsNumber;
            snilsRegistrationDate = client.SNILS.registrationDate;
            tinNumber = client.TIN.tinNumber;
            tinRegistrationDate = client.TIN.registrationDate;
            tinWhoRegistered = client.TIN.whoRegistered;
        }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string genderName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string phoneNumber { get; set; }
        public string passportSeries { get; set; }
        public string passportNumber { get; set; }
        public string passportIssuedBy { get; set; }
        public DateTime dateOfIssue { get; set; }
        public string divisionCode { get; set; }
        public string placeOfBirth { get; set; }
        public string snilsNumber { get; set; }
        public DateTime snilsRegistrationDate { get; set; }
        public string tinNumber { get; set; } 
        public DateTime tinRegistrationDate { get; set; }
        public string tinWhoRegistered { get; set; }
    }
}