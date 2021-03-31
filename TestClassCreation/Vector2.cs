using System;
using System.Collections.Generic;
using System.Text;

namespace TestClassCreation
{
    public class Vector2
    {
        public float x;
        public float y;

        public static Vector2 One { get { return new Vector2(1, 1); } }
        public static Vector2 Right { get { return new Vector2(1, 0); } }
        public static Vector2 Left { get { return new Vector2(-1, 0); } }
        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;

        }

        public static Vector2 Empty()
        {
            return new Vector2(0, 0);
        }
    }
}
