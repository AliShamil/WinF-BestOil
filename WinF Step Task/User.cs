using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinF_Step_Task
{
    internal class User
    {
        private bool ValidateName(string? name) => Regex.IsMatch(name!, @"^[a-zA-Z]+$");
        private bool ValidatePhone(string? phone) => Regex.IsMatch(phone!, @"^([0|\+[0-9]{1,5})?([0-9]{10})$");
        private string? _name;
        private string? _surname;
        private string? _email;
        private string? _phone;

        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        public string? Name
        {
            get { return _name; }
            set
            {

                if (!ValidateName(value))
                    throw new ArgumentException("Invalid Name");
                    

                _name = value;
            }
        }



        public string? Surname
        {
            get { return _surname; }
            set
            {

                if (!ValidateName(value))
                    throw new ArgumentException("Invalid Surname");
              

                _surname = value;
            }
        }


        public string? Email
        {
            get { return _email; }
            set
            {
                if (!IsValidEmail(value))
                    throw new ArgumentException("Invalid Email");
        

                _email = value;
            }
        }


        public string? Phone
        {
            get { return _phone; }
            set
            {
                if (!ValidatePhone(value))
                    throw new ArgumentException("Invalid Phone");

                _phone = value;
            }
        }

       
        public DateTime BirthDate { get; set; }

        public User(string? name, string? surname, string? email, string? phone, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            BirthDate = birthDate;
        }


        public override string ToString() =>
            $@"{Name}
{Surname}
{Email}
{Phone}
{BirthDate.ToShortDateString()}";
    }
}
