using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Models
{
    class Player : INotifyPropertyChanged
    {
        string name;
        string savePath;
        string iconPath;
        string garrowPath;
        string timer;
        string letters;
        string usedLetters;
        string mistakes;
        int level;
        Tuple<int, int> statistics;
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
                NotifyPropertyChanged("Level");
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
        public string Mistakes
        {
            get
            {
                return mistakes;
            }
            set
            {
                mistakes = value;
                NotifyPropertyChanged("Mistakes");
            }
        }
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
        public string UsedLetters { get => usedLetters; set { usedLetters = value; NotifyPropertyChanged("UsedLetters"); } }

        public string Letters { get => letters; set { letters = value; NotifyPropertyChanged("Letters"); } }

        public string Timer { get => timer; set { timer = value; NotifyPropertyChanged("Timer"); } }

        public string GarrowPath { get => garrowPath; set { garrowPath = value; NotifyPropertyChanged("GarrowPath"); } }

        public string SavePath { get => savePath; set { savePath = value; NotifyPropertyChanged("SavePath"); } }
        public Tuple<int, int> Statistics { get => statistics; set { statistics = value; NotifyPropertyChanged("Statistics"); } }

        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
