using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_GallerySolution
{
    public class ImageGallery
    {
        Iapplication application;

        public ImageGallery(Iapplication image)
        {
            this.application = image;
        }

        public void Share()
        {
            application.Send();
        }
    }
}
