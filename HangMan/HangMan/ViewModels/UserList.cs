using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using HangMan.Services;

namespace HangMan
{
    class UserList:INotifyPropertyChanged
    {
        public ObservableCollection<User> Users { get; set; }
        public string Icon { get => icon; set {icon = value; OnPropertyChanged(); } }

        private string icon = @"\Resources\Avatars\default.png";

        public event PropertyChangedEventHandler? PropertyChanged;

        public UserList()
        {
            Users = new ObservableCollection<User> { };
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

