﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_GallerySolution
{
    public class Bluetooth:ICommunicationapplication
    {
        public void Send()
        {
            Console.WriteLine("Image sent through Bluetooth");
        }
    }
}
