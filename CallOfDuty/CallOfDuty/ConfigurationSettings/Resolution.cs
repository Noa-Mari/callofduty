using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallOfDuty.ConfigurationSettings
{
    public class Resolution
    {
        public int Width;
        public int Height;

        public Resolution(int width, int height)
        {
            Width = width;
            Height = height;
        }
            public Resolution() { }
    }
}