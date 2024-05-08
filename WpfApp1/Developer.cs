using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    public enum Position
    {
        Junior,
        Middle,
        Senior
    }

    public class Developer : IDataErrorInfo
    {
        public string DeveloperId { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public Position Position { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Добавленное поле Password
        public bool isAdmin { get; set; }
        public ICollection<Project> projects { get; set; }=new List<Project>();

        public Developer(string login, string name, Position position, string email, string password, byte[] image, bool isAdmin)
        {
            DeveloperId = login;
            Name = name;
            Position = position;
            Image = image;
            Email = email;
            Password = password;
            this.isAdmin = isAdmin;
        }

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Name":
                        Regex regex = new Regex(@"^[А-ЯЁ][а-яё]+\s[А-ЯЁ][а-яё]+\s[А-ЯЁ][а-яё]+$");
                        if (!regex.IsMatch(Name))
                        {
                            error = "Incorrect name";
                        }
                        break;
                    case "Email":
                        // Дополнительная проверка валидности email
                        if (!IsValidEmail(Email))
                        {
                            error = "Invalid email";
                        }
                        break;
                    case "Login":
                        if (string.IsNullOrWhiteSpace(DeveloperId))
                        {
                            error = "Invalid login";
                        }
                        break;
                    case "Password":
                        if (string.IsNullOrWhiteSpace(Password))
                        {
                            error = "Invalid password";
                        }
                        break;
                }
                return error;
            }
        }

        [JsonIgnore]
        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public Developer(string login, string name, string password)
        {
            DeveloperId = login;
            Name = name;
            Password = password;
            Image = null;
        }
        public Developer(string login, string name, Position position, string password)
        {
            DeveloperId = login;
            Name = name;
            Position = position;
            Password = password;
            Image = null;
        }

        public Developer()
        {
            DeveloperId = "";
            Name = String.Empty;
            Position = Position.Junior;
            Image = null;
        }

        private bool IsValidEmail(string email)
        {
            // Проверка валидности email с использованием регулярного выражения или других методов
            // В этом примере используется простая проверка на наличие символа @
            return email.Contains("@");
        }
    }
}
