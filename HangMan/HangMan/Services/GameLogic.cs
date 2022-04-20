using HangMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace HangMan.Services
{
    class GameLogic
    {
        Player player;
        public GameLogic(Player player)
        {
            this.player = player;
        }
    public void EndGame()
    {

    }
    public void StartTimer()
        {
            var _time = TimeSpan.FromMinutes(5);
            var _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                var temp= _time.ToString("c");
                this.player.Timer = temp.Remove(0, 4);
                if (_time != TimeSpan.Zero)
                    _time = _time.Add(TimeSpan.FromSeconds(-1));
                else
                    EndGame();
            }, Application.Current.Dispatcher);
            _timer.Start();
        }
    public void ChooseWord(short choice)
        {
            Words word = new Words();
            List<string> temp;
            Random rand=new Random();
            int index;
            switch (choice)
            {
                case 1:
                    List<string> vs = new List<string>();
                    foreach(List<string> item in word.words.Values)
                    {
                        if(!vs.Any())
                        {
                            vs = item;
                        }
                        else
                            vs.AddRange(item);
                    }
                    temp=vs;
                    index = rand.Next(temp.Count);
                    this.player.Letters = temp[index];
                    break;
                case 2:
                    temp = word.words["cars"];
                    index = rand.Next(temp.Count);
                    this.player.Letters=temp[index];
                    break;
                case 3:
                    temp = word.words["movies"];
                    index = rand.Next(temp.Count);
                    this.player.Letters = temp[index];
                    break;
                case 4:
                    temp = word.words["rivers"];
                    index = rand.Next(temp.Count);
                    this.player.Letters = temp[index];
                    break;
            }
        }
    }
}
