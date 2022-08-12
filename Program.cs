using System;

namespace Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("Output For Four Integer Number Using Compare To Method And Check The Maximum Number.");
            MaximumFour maximumFour = new MaximumFour();
            int Value = maximumFour.MaximumInteger(11, 22, 33,88);
            Console.WriteLine(Value);

            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("Output For Four Integer Number Using Compare To Method By Using Generics And Check The Maximum Number.");
            MaximumFourGenerics<int> MaximumFour = new MaximumFourGenerics <int>(11, 22, 33, 88);
            int value1 = MaximumFour.CheckFourGenerics(11, 22, 33, 88);
            Console.WriteLine("The Maximum Number Is: " + value1);

           


        }
    }
}
