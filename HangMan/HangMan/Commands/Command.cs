using HangMan.Models;
using HangMan.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace HangMan.Commands
{
    class Command : ICommand
    {
        private GameLogic gl;
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            (parameter as Letter).IsEnabled = false;
            gl.Letter((parameter as Letter).Content.ToString());
        }
    }
}
