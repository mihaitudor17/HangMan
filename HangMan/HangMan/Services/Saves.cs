using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HangMan.Services
{
    static class Saves
    {

        static public ObservableCollection<User> Unload_Saves()
        {
            if (File.Exists("../../../Resources/Saves/Users.json"))
            {
                string json = File.ReadAllText("../../../Resources/Saves/Users.json");
                return JsonConvert.DeserializeObject<ObservableCollection<User>>(json);
            }
            else
            {
                File.Create("../../../Resources/Saves/Users.json");
                return new ObservableCollection<User> {};
            }
        }
        static public void Load_Saves(ObservableCollection<User> list)
        {
                var json = JsonConvert.SerializeObject(list);
                File.WriteAllText("../../../Resources/Saves/Users.json", json);
        }
        
    }
}
