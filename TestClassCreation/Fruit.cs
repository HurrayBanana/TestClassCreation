using System;
using System.Collections.Generic;
using System.Text;

namespace TestClassCreation
{
    public class Fruit
    {
        private string growingSpot;
        private string name;

        public string GrowingSpot
        {
            get { return growingSpot; }
            set { growingSpot = value; }
        }


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }



        public Fruit(string name)
        {
            //this.name = name;
            Name = name;
        }

        public Fruit(string name, string growingSpot)
            :this(name)
        {
            this.growingSpot = growingSpot;
        }
    }
}
