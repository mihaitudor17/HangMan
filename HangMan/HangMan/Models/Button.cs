using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HangMan.Models
{
    class Button
    {
        public string Content { get; }

        public ICommand Command { get; }

        public Button(string content, ICommand command)
        {
            Content = content;
            Command = command;
        }
    }
}
