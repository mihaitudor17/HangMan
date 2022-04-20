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
using System.Windows.Shapes;

namespace HangMan.Views
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        Images image = new Images();
        BusinessLogic bl;
        public AddUser(object bl)
        {
            InitializeComponent();
            this.bl = (BusinessLogic?)bl;
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            img.Source=image.NextImage();
        }

        private void Prev(object sender, RoutedEventArgs e)
        {
            img.Source = image.PrevImage();
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            var path = @"../../../Resources/Saves/";
            path += this.text.Text.ToString() + @"/" + this.text.Text.ToString() + ".json";
            bl.AddUser(text.Text, img.Source.ToString(), path);
            this.Close();
        }
    }
}
