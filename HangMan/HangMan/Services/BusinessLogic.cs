using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
