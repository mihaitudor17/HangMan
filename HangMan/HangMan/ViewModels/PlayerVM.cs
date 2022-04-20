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
        private  Player _player;
        public PlayerVM()
        {
            _player = new Player();
            _player.GarrowPath = @"\Resources\Garrow\1.png";
            _player.Timer = "5:00";
            _player.Letters = "Pick a category";
        }
        public Player player { get { return _player; } set { _player = value; OnPropertyChanged(); } }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
