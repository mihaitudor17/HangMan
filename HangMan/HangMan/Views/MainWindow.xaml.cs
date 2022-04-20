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
            (this.DataContext as PlayerVM).player.Name = (user as User).Name;
            (this.DataContext as PlayerVM).player.IconPath = (user as User).IconPath;
        }
        private void StartGame(object sender, RoutedEventArgs e)
        {
            if (flag == false)
            {
                flag= true;
                gl.StartTimer();
                gl.ChooseWord(short.Parse(((MenuItem)sender).Tag.ToString()));
            }
        }
    }
}
