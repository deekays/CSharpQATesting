using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDraperAssignment2
{
    public class Rectangle
    {
        private int length;
        private int width;
        private int defaultLength = 1;
        private int defaultWidth = 1;

        public Rectangle()
        {
            length = defaultLength;
            width = defaultWidth;
        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return width;
        }

        public int GetPerimeter()
        {
            int perimeter = length * 2 + width * 2;
            return perimeter;
        }

        public int GetArea()
        {
            int area = length * width;
            return area;
        }
    }
}
