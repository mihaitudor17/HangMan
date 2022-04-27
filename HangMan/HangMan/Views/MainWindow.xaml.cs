using HangMan.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HangMan.Models;
using HangMan.ViewModels;
using HangMan.Views;

namespace HangMan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameLogic gl;
        bool flag=false;
        public MainWindow(object user)
        {
            InitializeComponent();
            gl = new GameLogic((this.DataContext as PlayerVM).player);
            (this.DataContext as PlayerVM).GL= gl;
            (this.DataContext as PlayerVM).player.Name = (user as User).Name;
            (this.DataContext as PlayerVM).player.IconPath = (user as User).IconPath;
        }
        private void StartGame(object sender, RoutedEventArgs e)
        {
            if ((this.DataContext as PlayerVM).player.Letters== "Pick a category")
            {
                flag= true;
                gl.StartTimer();
                gl.ChooseWord(short.Parse(((MenuItem)sender).Tag.ToString()),ref flag);
            }
        }

        private void NewGame(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                gl.RestartGame();
                flag = false;
            }
        }

        private void SaveGame(object sender, RoutedEventArgs e)
        {
            if(flag == true)
            gl.SaveGame();
        }

        private void OpenGame(object sender, RoutedEventArgs e)
        {
            gl.StopTimer();
            gl.OpenGame();
            flag = true;
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            gl.SaveGame();
            this.Close();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c start https://github.com/mihaitudor17");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            gl.SaveGame(); 
        }

        private void Statistics(object sender, RoutedEventArgs e)
        {

            Statistics statistics = new Statistics((this.DataContext as PlayerVM).player.Statistics.Item1, (this.DataContext as PlayerVM).player.Statistics.Item2);
            statistics.Show();
        }
    }
}
