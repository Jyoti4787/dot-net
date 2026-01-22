using System;

namespace MyLibrary
{
    public class ClassA : I1, I2, I3
    {
        public virtual void M1()
        {
            Console.WriteLine("ClassA: M1 logic applied");
        }

        public void M2()
        {
            Console.WriteLine("ClassA: M2 logic applied");
        }

        public void M3()
        {
            Console.WriteLine("ClassA: M3 logic applied");
        }

        public void M4()
        {
            Console.WriteLine("ClassA: M4 logic applied");
        }
    }
}
