using System;
using System.Collections.Generic;
using System.Text;

namespace TestClassCreation
{
    public class Shape
    {
        
        private string colour;

        public float Area
        {
            get { return 0; }
        }

        public Shape(string colour)
        {
            this.colour = colour;
        }

        public string toString()
        {
            return "!%$&£$!$^£ - oh no";
        }
    }
}
