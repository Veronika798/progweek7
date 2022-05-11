using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta esimest arvu");
            int userNubmerOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teist arvu");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vali tehe(sisesta '+', '-', '*' voi '/')");
            char userOperator = Convert.ToChar(Console.ReadLine());


            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(userNubmerOne, userNumberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNubmerOne, userNumberTwo);
                    break;
                default:
                    Console.WriteLine("Kena paeva!");
                    break;

                case '*':
                    MultyplyTwoNumbers(userNubmerOne, userNumberTwo);
                    break;

                case '-':
                    MinusTwoNumbers(userNubmerOne, userNumberTwo);
                    break;
            }

        }

        public static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }

        public static void MultyplyTwoNumbers(double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }


        public static void MinusTwoNumbers(double x, double y)
        {
            double result = x - y;
            Console.WriteLine(result);
        }




    }
}
