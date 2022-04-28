using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using HangMan.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using HangMan.Services;
using HangMan.Commands;
using System.Windows.Controls;

namespace HangMan.ViewModels
{
    class PlayerVM : INotifyPropertyChanged
    {
        private  Player _player;
        Command command;
        GameLogic gl;
        public Command Command { get=>command;}
        List<string> letters =new List<string>(){ "Q" ,"W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M" ," "};
        public PlayerVM()
        {
            _player = new Player();
            command=new Command(this);
            _player.GarrowPath = @"\Resources\Garrow\1.png";
            _player.Timer = "5:00";
            _player.Letters = "Pick a category";
            _player.Mistakes = "";
            _player.Level = 1;
            _player.Statistics =(0, 0).ToTuple<int,int>();
        }
        public GameLogic GL { get=>gl; set=>gl = value;}
        public Player player { get { return _player; } set { _player = value; OnPropertyChanged(); } }

        public List<string> Letters { get => letters; set => letters = value; }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
