using System;
using System.Collections.Generic;
using System.Text;

namespace TestClassCreation
{
    public class Circle : Shape
    {
        private Vector2 centre;
        private float radius;

        public Vector2 Centre
        {
            get { return centre; }
        }
        public new float Area
        {
            get { return MathF.PI * radius * radius; }
        }
        public Circle(Vector2 centre, float radius)
            :this(centre, radius, "gray")
        { }

        public Circle(Vector2 centre, float radius, string colour)
            :base(colour)
        {
            this.centre = centre;
            this.radius = radius;
        }

        public new string toString()
        {
            return "circ centre:" + centre.x + "," + centre.y +
                " radius:" + radius + " area:" + Area;
        }
    }
}
