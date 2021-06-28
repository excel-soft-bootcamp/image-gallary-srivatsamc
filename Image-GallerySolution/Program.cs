using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_GallerySolution
{
    public class Program
    {
        static void Main(string[] args)
        {
            Whatsapp _whatsapp = new Whatsapp();
            ImageGallery _imageGallery1 = new ImageGallery(_whatsapp);
            _imageGallery1.Share();

            Gmail _gmail = new Gmail();
            ImageGallery _imageGallery2 = new ImageGallery(_gmail);
            _imageGallery2.Share();

            Bluetooth _bluetooth = new Bluetooth();
            ImageGallery _imageGallery3 = new ImageGallery(_bluetooth);
            _imageGallery3.Share();

            
        }

    }
}

