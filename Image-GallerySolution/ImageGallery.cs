using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_GallerySolution
{
    public class ImageGallery
    {
        ICommunicationapplication application;
        
        public void ImageGallery_ref(ICommunicationapplication imageRef)
        {
            this.application = imageRef;
        }

        public void Share()
        {
            this.application.Send();
        }
    }
}
