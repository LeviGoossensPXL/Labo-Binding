using System.ComponentModel;

namespace ActorsApplication.Data
{
    public class Actor : INotifyPropertyChanged
    {
        private string _lastName = "";
        private string _firstName = "";
        private string _profilePicture = "";
        private int _birthYear = 1950;
        private string _shortBio = "";

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                RaiseEventPropChanged(nameof(LastName));
            }
        }

        public string FirstName
        {
            get => _firstName;
            set 
            {
                _firstName = value;
                RaiseEventPropChanged(nameof(FirstName));
            }
        }

        public string ProfilePicture
        {
            get => _profilePicture;
            set
            {
                _profilePicture = value;
                RaiseEventPropChanged(nameof(ProfilePicture));
            }
        }

        public int BirthYear
        {
            get => _birthYear;
            set
            {
                _birthYear = value;
                RaiseEventPropChanged(nameof(BirthYear));
            }
        }

        public string ShortBio
        {
            get => _shortBio;
            set 
            { 
                _shortBio = value;
                RaiseEventPropChanged(nameof(ShortBio));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaiseEventPropChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
