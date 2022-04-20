using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Models
{
    class Words
    {
        Dictionary<string, List<string>> _words = new Dictionary<string, List<string>>
        {
            { "cars", new List<string> { "Audi", "Bmw", "Ferari", "Alfa Romeo", "Aston Martin", "Dacia" } },
            { "movies", new List<string> { "Dune", "Titanic", "Avatar", "Matrix Reloaded", "Lord of the rings" } },
            { "rivers", new List<string> { "Nile", "Amazon", "Yangtze", "Mississippi", "Yenisei", "Congo" } }
        };
        public Dictionary<string, List<string>> words { get { return _words; } }
    }
}
