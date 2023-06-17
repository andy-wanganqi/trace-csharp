using ImportedCSharpLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    public class Teacher : Person, INotifyPropertyChanged
    {
        public DateTime DOB { get; init; }

        private string? _gender;
        public string? Gender
        {
            get { return _gender; }
            set 
            {
                if(value != _gender)
                {
                    _gender = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Gender)));
                }
            }
        }

        public string FullName => $"{FirstName} {LastName}";

        public Teacher(): base(string.Empty, string.Empty) { }
        public Teacher(string firstName, string lastName) : base(firstName, lastName) { }

        public void AddJuniorToFirstName()
        {
            this.FirstName += "Junior "; 
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
