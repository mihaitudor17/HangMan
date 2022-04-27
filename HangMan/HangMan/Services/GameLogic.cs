using HangMan.Commands;
using HangMan.Models;
using HangMan.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace HangMan.Services
{
    
    class GameLogic
    {
        Player player;
        DispatcherTimer _timer;
        int mistakes;
        string guess;
        List<Button> buttons=new List<Button>();
        bool flag;
        public GameLogic(Player player)
        {
            this.player = player;
            mistakes =  this.player.Mistakes.Count(f => f == 'X');
            if (mistakes == 0)
                mistakes++;
        }
        public void EndGame(int win)
        {
            if(win==1)
                player.Statistics = (player.Statistics.Item1+1,player.Statistics.Item2).ToTuple<int,int>();
            else
                player.Statistics = (player.Statistics.Item1,player.Statistics.Item2+1).ToTuple<int, int>();
            Statistics statistics=new Statistics(player.Statistics.Item1,player.Statistics.Item2);
            statistics.Show();
            RestartGame();
        }
        public void StartTimer(double time=5)
        {
            var _time = TimeSpan.FromMinutes(time);
            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                var temp = _time.ToString("c");
                temp = temp.Remove(0, 4);
                this.player.Timer = temp.Substring(0, 4);
                if (_time != TimeSpan.Zero)
                    _time = _time.Add(TimeSpan.FromSeconds(-1));
                else
                    EndGame(0);
            }, Application.Current.Dispatcher);
            _timer.Start();
        }
        public void RestartGame()
        {
            _timer.Stop();
            this.player.Timer = "5:00";
            this.player.Letters = "Pick a category";
            foreach (Button button in buttons)
                button.IsEnabled = true;
            buttons.Clear();
            buttons = new List<Button>();
            this.player.GarrowPath = @"\Resources\Garrow\1.png";
            this.player.Mistakes = "";
            flag = false;
            mistakes = 1;
        }
        public void StopTimer()
        {
            if(_timer != null)
            _timer.Stop();
        }
        public void ChooseWord(short choice,ref bool flag)
        {
            Words word = new Words();
            List<string> temp;
            Random rand = new Random();
            int index;
            this.flag = flag;
            switch (choice)
            {
                case 1:
                    List<string> vs = new List<string>();
                    foreach (List<string> item in word.words.Values)
                    {
                        if (!vs.Any())
                        {
                            vs = item;
                        }
                        else
                            vs.AddRange(item);
                    }
                    temp = vs;
                    index = rand.Next(temp.Count);
                    guess = temp[index];
                    this.player.Letters = string.Concat(Enumerable.Repeat("_ ",temp[index].Length));
                    break;
                case 2:
                    temp = word.words["cars"];
                    index = rand.Next(temp.Count);
                    guess = temp[index];
                    this.player.Letters = string.Concat(Enumerable.Repeat("_ ", temp[index].Length));
                    break;
                case 3:
                    temp = word.words["movies"];
                    index = rand.Next(temp.Count);
                    guess = temp[index];
                    this.player.Letters = string.Concat(Enumerable.Repeat("_ ", temp[index].Length));
                    break;
                case 4:
                    temp = word.words["rivers"];
                    index = rand.Next(temp.Count);
                    guess = temp[index];
                    this.player.Letters = string.Concat(Enumerable.Repeat("_ ", temp[index].Length));
                    break;
            }
        }
        public void SaveGame()
        {
            var path = @"../../../Resources/Saves";
            path += @"\" + this.player.Name;
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path += @"\" + this.player.Name + ".json";
            var json = JsonConvert.SerializeObject(this.player);
            File.WriteAllText(path, json);
        }
        public void OpenGame()
        {
            var path = @"../../../Resources/Saves/";
            path +=this.player.Name +@"/"+this.player.Name+".json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                Player temp=JsonConvert.DeserializeObject<Player>(json);
                this.player.Name = temp.Name;
                this.player.SavePath = temp.SavePath;
                this.player.IconPath = temp.IconPath;
                this.player.GarrowPath=temp.GarrowPath;
                this.player.Timer = temp.Timer;
                this.player.Letters=temp.Letters;
                this.player.UsedLetters=temp.UsedLetters;
                this.player.Statistics=temp.Statistics;
                this.player.Mistakes=temp.Mistakes;
                string temp1 = "";
                temp1+=temp.Timer[0];
                string temp2 = "";
                temp2+=temp.Timer[2];
                temp2 += temp.Timer[3];
                StartTimer(Double.Parse(temp1)+(Double.Parse(temp2)/60));
            }
        }
        public int Letter(string letter,Button button)
        {
            if (player.Letters!= "Pick a category")
            {
                guess = guess.ToUpper();
                int index = guess.IndexOf(letter);
                player.UsedLetters += letter;
                buttons.Add(button);
                if (index == -1)
                {
                    mistakes++;
                    if (mistakes <= 6)
                    {
                        player.GarrowPath = @"\Resources\Garrow\" + mistakes.ToString() + ".png";
                        player.Mistakes += "X  ";
                    }
                    else
                    {
                        EndGame(0);
                        return 0;
                    }
                }
                while (index != -1)
                {
                    StringBuilder sb = new StringBuilder(player.Letters);
                    sb[index * 2] = letter[0];
                    player.Letters = sb.ToString();
                    index = guess.IndexOf(letter, index + 1);
                }
                if (player.Letters.IndexOf("_") == -1)
                { 
                    EndGame(1);
                    return 0;
                }
                return 1;
            }
            else
            return 0;
        }
       
    }
}
