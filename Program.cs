using System;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("*******Welcome To Program Find Maximum Using Generics*********");
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            //Creating Variable To Store Input From User.
            int Choice;
            {
                Console.WriteLine("****Press 0 For Exit****");
                Console.WriteLine("**1.Find Maximum Among Three Integer.**");
                Console.WriteLine("**2.Find Maximum Among Three Float.**");
                Console.WriteLine("**3.Find Maximum Among Three String.**");
                Console.WriteLine("**4.Find Maximum Among Three Value Using Generic Method.**");
                Console.WriteLine("**5.Find Maximum Among Three Value Using Generic Class.**");
                Console.WriteLine("**Enter Your Choice:**");
                Choice = Convert.ToInt32(Console.ReadLine()); // store input From User and Convert into Integer Type.

                //Using Switch Case To Excute Program Input by User.
                switch (Choice)
                {
                    case 1:

                        //Creating Instance Of Class FindMaxInt
                        Console.WriteLine("***Output For Maximum Integer Number***");
                        IntMaximum objmaximumint = new IntMaximum();
                        int value3 = objmaximumint.MaximumIntegerNumber(40, 50, 60);
                        Console.WriteLine("The max value is:" + value3);
                        Console.WriteLine("::::::::::::::::::::::::::");
                        break;
                    case 2:
                        Console.WriteLine("***Output For Maximum Float Number***");
                        FloatMaximum floatMaximum = new FloatMaximum();
                        float value4 = floatMaximum.MaximumFloatNumber(11.2f, 22.3f, 66.5f);
                        Console.WriteLine("The max Floating Value is :" + value4);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::");
                        break;

                    case 3:
                        Console.WriteLine("***Output For Maximum String Number***");
                        StringMaximum stringMaximum = new StringMaximum();
                        string value5 = stringMaximum.MaximumStringNumber("Apple", "Peach", "Banana");
                        Console.WriteLine("The max String Value is: " + value5);
                        Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 4:
                        Console.WriteLine("***Output For Maximum  Among Three Generic Type Variable Using Generic Method.***");
                        //For Integer Value
                        GenericsMaxThreeMethod GenericsMaxInt = new GenericsMaxThreeMethod();
                        int Value1 = GenericsMaxInt.GenericsMaxAmongThre(66, 55, 22);
                        Console.WriteLine("The Maximum Inter is:" + Value1);

                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

                        //For Float Value
                        GenericsMaxThreeMethod GenericsMaxFloat = new GenericsMaxThreeMethod();
                        float Value2 = GenericsMaxFloat.GenericsMaxAmongThre(11.2f, 22.3f, 55.5f);
                        Console.WriteLine("The Maximum  Float is:" + Value2);

                        Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::");

                        //For String Value
                        GenericsMaxThreeMethod GenericsMaxString = new GenericsMaxThreeMethod();
                        string Value3 = GenericsMaxFloat.GenericsMaxAmongThre("Aaple", "Peach", "Banana");
                        Console.WriteLine("The Maximum String is:" + Value3);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 5:
                        Console.WriteLine("***Output For Maximum  Among Three Generic Type Variable Using Generic Class.***");
                        //For Integer Value
                        GenericsMaxThreeClass<int> maximumInt = new GenericsMaxThreeClass<int>(66, 11, 200);
                        int value = maximumInt.GenericsMaxAmong(66, 11, 200);
                        Console.WriteLine("The Maximum Integer is: " + value);

                        Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::");

                        //For Float Value
                        GenericsMaxThreeClass<float> maximumfloat = new GenericsMaxThreeClass<float>(22.3f, 56.05f, 99.23f);
                        float value1 = maximumfloat.GenericsMaxAmong(22.3f, 56.05f, 99.23f);
                        Console.WriteLine("The Maximum Float is:" + value1);

                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");

                        //For String Value
                        GenericsMaxThreeClass<string> maximumString = new GenericsMaxThreeClass<string>("Apple", "Peach", "Banana");
                        string value2 = maximumString.GenericsMaxAmong("Apple", "Peach", "Banana");
                        Console.WriteLine("The Maximum String is:" + value2);
                        Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::");
                        break;




                }
            }
        }
    }
}
