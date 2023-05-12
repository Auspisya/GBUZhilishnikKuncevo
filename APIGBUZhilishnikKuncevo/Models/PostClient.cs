using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIGBUZhilishnikKuncevo.Models
{
    public class PostClient
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string patronymic { get; set; }
        public string genderName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string phoneNumber { get; set; }
        public string passportNumber { get; set; }
        public string passportSeries { get; set; }
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