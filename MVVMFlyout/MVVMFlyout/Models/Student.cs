using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MVVMFlyout.Models
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }

       /* private string firstName;
        private string lastName;
        private string country;
        private string language;

        public bool ViewModelIsLoading { get; set; }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (firstName == value)
                    return;
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
                OnPropertyChanged(nameof(FullName));
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName == value)
                    return;
                lastName = value;
                OnPropertyChanged(nameof(LastName));
                OnPropertyChanged(nameof(FullName));
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                if (!ViewModelIsLoading)
                {
                    if (country == value)
                        return;
                    country = value;
                    OnPropertyChanged(nameof(Country));
                }
            }
        }
        public string Language
        {
            get { return language; }
            set
            {
                if (language == value)
                    return;
                language = value;
                OnPropertyChanged(nameof(Language));
            }
        }

        public string FullName
        {
            get
            {
                return (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName)) ? "Student Details" : $"{FirstName} {LastName}";
            }
            set { }
        }

        public Student()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }*/
    }
}
