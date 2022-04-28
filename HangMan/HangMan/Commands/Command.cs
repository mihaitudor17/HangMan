using HangMan.Models;
using HangMan.Services;
using HangMan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HangMan.Commands
{
    class Command : ICommand
    {
        PlayerVM player;
        GameLogic gl;
        public event EventHandler? CanExecuteChanged;
        public Command(PlayerVM player)
        {
            this.player = player;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if ((parameter as Button).Content.ToString() != " ")
            {
                gl = this.player.GL;
                if (gl.Letter((parameter as Button).Content.ToString().ToUpper(), (parameter as Button)) == 1)
                    (parameter as Button).IsEnabled = false;
            }
        }
    }
}
