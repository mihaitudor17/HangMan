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
        public Command Command { get=>command; }
        public ObservableCollection<Button> MyData { get; } = new ObservableCollection<Button>();
        public PlayerVM()
        {
            _player = new Player();
            _player.GarrowPath = @"\Resources\Garrow\1.png";
            _player.Timer = "5:00";
            _player.Letters = "Pick a category";
            string qwerty = "Q W E R T Y U I O P A S D F G H J K L Z X C V B N M";
            foreach (var letter in qwerty.Split(' '))
            {
                Button button = new Button();
                button.Content = letter;
                button.Command = Command;
                MyData.Add(button);
            }
            Button button1 = new Button();
            MyData.Add(button1);
        }
        public Player player { get { return _player; } set { _player = value; OnPropertyChanged(); } }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
