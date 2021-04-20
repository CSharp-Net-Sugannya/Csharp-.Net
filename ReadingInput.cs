using System;

namespace InputFromUser
{
    /*
     * Class ReadingInput is taking the number input from user
     * Author:Netravati
     * Date:3/2/2021
     */
    class ReadingInput
    {
        //Main Method Creation
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            //converting string to int
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered Number is: " + number);

            Console.WriteLine("Enter decimal number:");
            //converting string to double
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entered Number is: " + num);

            Console.WriteLine("Enter String:");
            string stringvalue=Console.ReadLine();
            Console.WriteLine("Entered String is: " + stringvalue);
        }
    }
}


