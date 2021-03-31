using System;
using System.Collections.Generic;
using System.Text;

namespace TestClassCreation
{
    public class Rectangle : Shape
    {
        private float width;
        private float length;

        public new float Area
        {
            get { return width * length; }
        }

        public Rectangle(float width, float length, string colour) 
            : base(colour)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(float width, float length)
            :this(width, length, "gray")
        {
        }

        public new string toString()
        {
            return "rect width:" + width + " length:" + length +
                    " area:" + Area;
        }


    }
}
