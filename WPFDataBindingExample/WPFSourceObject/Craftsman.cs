using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSourceObject
{
    public class Craftsman:INotifyPropertyChanged
    {
        private int age;
        public string Name { get; set; }
        public string LastName { get; set; }

        public int Age {
            get { return age; }
            set { age = value;
                OnPropertyRaised("Age");
            } 
          
        }

        public string PicturePath { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }



    }
}
