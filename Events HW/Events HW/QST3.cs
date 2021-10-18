using System.Collections.Generic;

namespace Events_HW
{
    public static class studentlist
    {
        public static List<Student> List;
        public static int Amount = 0;

        public static event SimpleDelegate FivePerDiscount = Discounts.FivePer; 


        public static void Add(Student S)
        {
            

            List.Add(S);
            Amount++;
            if (Amount % 5 == 0 )
            {
                FivePerDiscount();
            }

        }

       
    }
    public class Student
    {

    }

    public static class Discounts
    {
        

        

        public static void FivePer()
        {
            System.Console.WriteLine("You Got 5% Discount");
        }

    }
}
