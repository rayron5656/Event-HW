using System;

namespace Events_HW
{
    class QST1
    {
        public string Name { get; set; }
        public bool NameCheck = false;
        

        public QST1(string name)
        {
            NameTooLongEvent = PrintQST1;
            do
            {
                if (name.Length <= 10)
                {
                    Name = name;
                    NameCheck = true;
                }
                else
                {
                    NameTooLongEvent();
                    
                    name = Console.ReadLine();


                }
            } while (!NameCheck);
            
        }

        public static event SimpleDelegate NameTooLongEvent;

        public static void PrintQST1()
        {
            Console.WriteLine("Name to long");
            Console.WriteLine("please try again");
        }

    }
}
