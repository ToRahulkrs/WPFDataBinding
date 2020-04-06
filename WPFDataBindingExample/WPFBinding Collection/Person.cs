using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPFBindingCollection
{
    public class Person:INotifyPropertyChanged
    {
        private string name;
        public string Name {
            get { return name; }
                set{ name = value;
                OnPropertyRaised(Name);
            }
            
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyRaised(LastName);
            }
        }

        private int age;
        public int Age {
            get {
                Thread.Sleep(6000); 
                return age;}
            set
            {
                age = value;
                OnPropertyRaised("Age");
            }
        }

        private string picturPath;
        public string PicturePath {
            get { return picturPath; }
            set
            {
                picturPath = value;
                OnPropertyRaised(PicturePath);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyRaised(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
