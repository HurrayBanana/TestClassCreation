using System;
using System.Collections.Generic;
using System.Text;

namespace TestClassCreation
{
    public class Triangle : Shape
    {
        private float tribase;
        private float height;

        public new float Area
        {
            get { return tribase * height * 0.5f; }
        }

        public Triangle(float tribase, float height, string colour)
            : base(colour)
        {
            this.tribase = tribase;
            this.height = height;
        }

        public Triangle(float width, float length)
            : this(width, length, "gray")
        {
        }

        public new string toString()
        {
            return "tri base:" + tribase + " height:" + height +
                    " area:" + Area;
        }

    }
}
