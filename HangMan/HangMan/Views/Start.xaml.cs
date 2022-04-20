using HangMan.Services;
using HangMan.Views;
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
using System.ComponentModel;
namespace HangMan
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Window
    {
        private BusinessLogic bl;
        public Start()
        {
            InitializeComponent();
            bl = new BusinessLogic((this.DataContext as UserList).Users);
            bl.SetUsers(Saves.Unload_Saves());
            
        }
        void WindowClosing(object sender, CancelEventArgs e)
        {
            Saves.Load_Saves((this.DataContext as UserList).Users);
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listbox.SelectedItem != null)
            { 
                (DataContext as UserList).Icon = ((sender as ListBox).SelectedItem as User).IconPath;
            }
            else
            {
                (DataContext as UserList).Icon = @"\Resources\Avatars\default.png";
            }
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            bl.DeleteUser(listbox.SelectedIndex);
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            listbox.SelectedItem = null;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            AddUser addUser=new AddUser(bl);
            addUser.Show();
        }
        private void Play(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow = new MainWindow(listbox.SelectedItem);
            Application.Current.MainWindow.Show();
            this.Close();
        }
    }
}
