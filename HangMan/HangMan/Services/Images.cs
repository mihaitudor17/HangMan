using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HangMan.Services
{
    class Images
    {
        private int count = 1;
        public BitmapImage NextImage()
        {
            if (count < 16)
                count++;
            else
                count = 1;
            return new BitmapImage(new Uri("/Resources/Avatars/" + count.ToString() + ".jpg",UriKind.Relative));
        }
        public BitmapImage PrevImage()
        {
            if (count > 1)
                count--;
            else
                count = 16;
            return new BitmapImage(new Uri("/Resources/Avatars/" + count.ToString() + ".jpg", UriKind.Relative));
        }
    }
}
