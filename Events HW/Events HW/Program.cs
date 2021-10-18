using System;

namespace Events_HW
{

    public delegate void SimpleDelegate();



    class Program
    {
        public static event SimpleDelegate LuckyNumberEvent;

        static void Main(string[] args)
        {
            LuckyNumberEvent = QST2;
            int NumberForQST2 = 0;

            


            Console.WriteLine("please enter a name");

            QST1 qST1 = new QST1(Console.ReadLine());


            do
            {
                Console.WriteLine("please enter a whole number");
                NumberForQST2 = int.Parse(Console.ReadLine());


            } while (NumberForQST2 != 999);

            LuckyNumberEvent();





        }


        static void QST2()
        {
            Console.WriteLine("Lucky Number Was Entered");
        }

    }
}
