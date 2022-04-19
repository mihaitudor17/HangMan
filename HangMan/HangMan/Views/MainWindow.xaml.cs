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
namespace HangMan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User user;
        GameLogic gl;
        public MainWindow(object user)
        {
            InitializeComponent();
            this.user = user as User;
            text.Text=this.user.Name;
            image.Source= new BitmapImage(new Uri(this.user.IconPath.ToString()));
            gl = new GameLogic(this.DataContext as Player);
        }

    }
}
