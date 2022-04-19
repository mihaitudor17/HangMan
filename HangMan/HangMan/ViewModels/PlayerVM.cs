using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using HangMan.Models;

namespace HangMan.ViewModels
{
    class PlayerVM : INotifyPropertyChanged
    {
        Player player { get => this.player; set { player = value; OnPropertyChanged(); } }
        public PlayerVM()
        {
            player = new Player();
            player.GarrowPath = @"\Resources\Garrow\1.png";
            player.Timer = "5:00";
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
