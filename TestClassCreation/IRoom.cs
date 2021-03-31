using System;
using System.Collections.Generic;
using System.Text;

namespace TestClassCreation
{
    interface IRoom
    {
        public int Capacity { get; }
        public int Remaining { get; }
        public string Name { get; }

        public float ValueSold();

        public float ValueLeft();
    }
}
