using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class User : INotifyPropertyChanged
    {
        private string iconPath;
        private string savePath;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }
        public string SavePath
        {
            get
            {
                return savePath;
            }
            set
            {
                savePath = value;
                NotifyPropertyChanged("SavePath");
            }
        }
        public string IconPath
        {
            get
            {
                return iconPath;
            }
            set
            {
                iconPath = value;
                NotifyPropertyChanged("IconPath");
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
