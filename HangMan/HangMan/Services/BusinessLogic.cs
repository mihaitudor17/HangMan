using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HangMan.Services
{
    class BusinessLogic
    {
        private ObservableCollection<User> users;
        public BusinessLogic(ObservableCollection<User> users)
        {
            this.users = users;
        }
        public void DeleteUser(int index)
        {
            if (File.Exists(users[index].SavePath))
            {
                var path = @"../../../Resources/Saves/";
                path += users[index].Name;
                System.IO.DirectoryInfo di = new DirectoryInfo(path);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
                Directory.Delete(path);
            }
            users.RemoveAt(index);
        }
        public void AddUser(string name, string iconPath, string savePath)
        {
            User user = new User();
            user.Name = name;
            user.IconPath = iconPath;
            user.SavePath = savePath;
            this.users.Add(user);
        }
        public void SetUsers(ObservableCollection<User> users)
        {
            if (users != null)
                foreach (object User in users)
                    this.users.Add((User)User);
        }
        public ObservableCollection<User> GetUsers()
        {
            return this.users;
        }
    }
}
