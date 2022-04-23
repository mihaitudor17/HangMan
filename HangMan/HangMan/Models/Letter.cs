using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
namespace HangMan.Models
{
    class Letter:Button
    {
        public string Content { get; }

        public ICommand Command { get; }

        public Letter(string content, ICommand command)
        {
            Content = content;
            Command = command;
        }
    }
}
