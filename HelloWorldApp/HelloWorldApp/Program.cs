using System;
using static System.Console;
using Introduction = Company.MyProject.Basics;

namespace HelloWorldApp
{
    class Program
    {
        static int DoSomething(int a)
        {
            return a + a;
        }
        public class PhoneCustomer
        {
            public const string DayOfSandingBill = "Monday";
            public int CustomerID;
            
            public string LastName;
            private string _firstName;
            public string FirstName
            {
                get { return _firstName; }
                set { _firstName = value; }
            }
            private decimal _data;
            public decimal Data
            {
                get { return _data; }
                set { _data = value; }
            }

            public decimal DataAutoImplemented
            {
                get;
                set;
            }
        }

        public enum TimeOfDay
        {
            Morning = 0,
            Afternoon = 1,
            Evening = 2
        }
        static void Main(string[] args)
        {
            var name = "Bob";
            var age = 21;
            var isRabbit = true;

            {
                int dupaukryta = 12;
                WriteLine(dupaukryta);
            }

            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isRabbitType = isRabbit.GetType();

            WriteLine($"name is type {nameType}");
            WriteLine($"name is type {name.GetType()}");
            WriteLine($"age is type {ageType}");
            WriteLine($"isRabbit is type {isRabbitType}");

            int a = 23;

            string s = a.ToString();

            WriteLine($"{s} = {a}");

            char characters = '\x0051';
            char characters1 = (char)65;
            char alert = '\a';
            char backspace = '\b';
            char formFeed = '\f';
            char Carriagereturn = '\r';
            char vericaltab = '\v';

            WriteLine(characters + " " + characters1);
            //WriteLine(alert);
            WriteLine("stackoverflow " + '\b' + " is " + backspace + " good");
            WriteLine(vericaltab);
            WriteLine("dupa" + Carriagereturn + "pa");
            //WriteLine("stackoverflow" + formFeed + "is" + formFeed + "good");


            string jeby = @"'Cos tam mam
            ale nie dam";
            WriteLine(jeby);

            int b = 2;


            if (DoSomething(b) != 0)
            {
                WriteLine(DoSomething(b));
            }
            else
            {
                WriteLine("Zero");
            }
            WriteLine("\n\n\n\n");

            string[] arrayOfStrings = new string[5];

            for (int i = 0; i < 5; i++)
            {
                arrayOfStrings[i] = "string_" + i.ToString();
            }

            int[] arrayOfInts = new int[5];

            goto Label1;
            foreach (var item in arrayOfStrings)
            {
                WriteLine(item);
            }
            arrayOfInts[2] = 2;
            Label1:
            foreach (var item in arrayOfInts)
            {
                Write($"{item} \t");
            }
            WriteLine();

            TimeOfDay time = TimeOfDay.Afternoon;
            WriteLine(time.ToString());

            TimeOfDay time2 = (TimeOfDay)Enum.Parse(typeof(TimeOfDay), "morning", true);
            WriteLine((int)time2);

            //namespace
            Introduction::NamespaceExample NSEx = new Introduction::NamespaceExample();
            WriteLine(NSEx.GetNamespace());


            for (int i = 0; i < args.Length; i++)
            {
                WriteLine(args[i]);
            }
            var customer1 = new PhoneCustomer();


            WriteLine($"\n{customer1.GetType()}");
            WriteLine($"{customer1.Data.GetType()}");
            WriteLine($"{customer1.DataAutoImplemented}");

            string message = "WITAM";
            string upperMessage = message.ToLower();
            WriteLine(upperMessage);

            int xMessage = 2017;
            message += xMessage.ToString();
            WriteLine(message);


            // C# 6.0 pl

            int[,] matrix2D = new int[3,3];

            int[,] rectangularMatrix =
            {
                {0, 1, 2 },
                {0, 2, 3 },
                {1, 2, 3 }
            };

            int[][] matrix = new int[][]
            {
                new int[] {3, 3, 3},
                new int[] {2, 2, 2},
                new int[] {1, 1, 1, 2}
            };

            var matrixVar = new int[][]
            {
                new int[] {3, 3, 3},
                new int[] {2, 2, 2},
                new int[] {1, 1, 1, 2}
            };

            var charArray = new[] { 'a', 'b', 'c' };

            //różna długość tablicy wewn
            int[][] matrix2 = new int[3][];



        }
    }
}

namespace Company.MyProject.Basics
{
    class NamespaceExample
    {
        public  string GetNamespace()
        {
            return this.GetType().Namespace;
        }
    }
}