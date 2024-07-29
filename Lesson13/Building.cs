using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    internal class Building
    {
        string adress;
        double length;
        double width;
        double height;

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public double Length
        {
            get { return length; }
            set 
            {
                if (value < 0) 
                    length = 0; 
                else
                    length = value; 
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                    width = 0;
                else
                    width = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                    height = 0;
                else
                    height = value;
            }
        }

        public Building (string adress, double length, double width, double height)
        {
            Adress = adress;
            Length = length;   
            Width = width;
            Height = height;
        }
        public virtual string Print()
        {
            return $"Здание по адресу {adress} с габаритными размерами LxWxH {length}x{width}x{height}";
        }
    }
}
