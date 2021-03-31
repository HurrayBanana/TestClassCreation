using System;
using System.Collections.Generic;
using System.Text;

namespace TestClassCreation
{
    public class ScreenOne : IRoom
    {
        private int seats;
        private int seatsBooked;
        private bool inuse;

        public int Capacity
        {
            get
            {
                return seats;
            }
        }

        public int Remaining
        {
            get
            {
                return seats - seatsBooked;
            }
        }

        public string Name
        {
            get
            {
                return "SCREEN ONE";
            }
        }

        public float ValueLeft()
        {
            throw new NotImplementedException();
        }

        public float ValueSold()
        {
            throw new NotImplementedException();
        }
    }
}
