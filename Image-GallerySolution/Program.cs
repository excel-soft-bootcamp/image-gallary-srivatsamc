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
            Gmail _gmail = new Gmail();
            Bluetooth _bluetooth = new Bluetooth();
            
            
            ImageGallery _imageGallery = new ImageGallery();
            _imageGallery.Share(_whatsapp);//_whatsapp
            _imageGallery.Share(_gmail);
            _imageGallery.Share(_bluetooth);
        
           
            
        }

    }
}

