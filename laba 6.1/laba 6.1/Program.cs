using System;

namespace laba_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("With what time of number you would like to work with:\n 1) integers\n 2) double\n 3) complex\n");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("menu:\n 1) add\n 2) substract\n 3) multiply\n 4) divide\n");
                    Console.WriteLine("Your disition:");
                    int choiceNum = Int32.Parse(Console.ReadLine());
                    IntegersNum integer = new IntegersNum(num1, num2);
                    switch (choiceNum)
                    {
                        case 1:
                            //IntegersNum integer = new IntegersNum(num1, num2);
                            Console.WriteLine("Your answer:");
                            integer.addNum();
                            break;
                        case 2:
                            //IntegersNum integer = new IntegersNum(num1, num2);
                            Console.WriteLine("Your answer:");
                            integer.minusNum();
                            break;
                        case 3:
                            //IntegersNum integer = new IntegersNum(num1, num2);
                            Console.WriteLine("Your answer:");
                            integer.multiNum();
                            break;
                        case 4:
                            //IntegersNum integer = new IntegersNum(num1, num2);
                            Console.WriteLine("Your answer:");
                            integer.divideNum();
                            break;
                        default:
                            Console.WriteLine("Wrong answer");
                            return;

                    }
                    break;
                case 2:
                    Console.WriteLine("menu:\n 1) add\n 2) substract\n 3) multiply\n 4) divide\n");
                    Console.WriteLine("Your disition:");
                    int choiceNum2 = Int32.Parse(Console.ReadLine());
                    DoubleNum doublee = new DoubleNum(num1, num2);
                    switch(choiceNum2)
                    {
                        case 1:
                            //IntegersNum integer = new IntegersNum(num1, num2);
                            Console.WriteLine("Your answer:");
                            doublee.addNum();
                            break;
                        case 2:
                            //IntegersNum integer = new IntegersNum(num1, num2);
                            Console.WriteLine("Your answer:");
                            doublee.minusNum();
                            break;
                        case 3:
                            //IntegersNum integer = new IntegersNum(num1, num2);
                            Console.WriteLine("Your answer:");
                            doublee.multiNum();
                            break;
                        case 4:
                            //IntegersNum integer = new IntegersNum(num1, num2);
                            Console.WriteLine("Your answer:");
                            doublee.divideNum();
                            break;
                        default:
                            Console.WriteLine("Wrong answer");
                            return;
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter the first complex numer:");
                    int complexNum1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second complex numer:");
                    int complexNum2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("menu:\n 1) add\n 2) substract\n 3) multiply\n 4) divide\n");
                    Console.WriteLine("Your disition:");
                    int choiceNum3 = Int32.Parse(Console.ReadLine());
                    ComplecsNum cNumber = new ComplecsNum(num1, num2, complexNum1, complexNum2);
                    switch (choiceNum3)
                    {
                        case 1:
                            //IntegersNum integer = new IntegersNum(num1, num2);
                            Console.WriteLine("Your answer:");
                            cNumber.addNum();
                            break;
                        case 2:
                            //IntegersNum integer = new IntegersNum(num1, num2);
                            Console.WriteLine("Your answer:");
                            cNumber.minusNum();
                            break;
                        case 3:
                            //IntegersNum integer = new IntegersNum(num1, num2);
                            Console.WriteLine("Your answer:");
                            cNumber.multiNum();
                            break;
                        case 4:
                            //IntegersNum integer = new IntegersNum(num1, num2);
                            Console.WriteLine("Your answer:");
                            cNumber.divideNum();
                            break;
                        default:
                            Console.WriteLine("Wrong answer");
                            return;
                    }
                    break;
                default:
                    Console.WriteLine("Wrong answer");
                    return;


            }
            
        }
    }
    
    
}
