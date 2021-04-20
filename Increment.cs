using System;

namespace ArithmeticIncrement
{
    /*
     *Class Increment is used to increment the number preincrement and postincrement
     *Author:Netravati
     *Date:3/2/2021
     */
    class Increment
    {
        //Main Method Creation
        static void Main(string[] args)
        {
            //incrementnum is variable
            int incrementnum = 200;
            Console.WriteLine("Number Before increment is : " + incrementnum);
            ++incrementnum;
            Console.WriteLine("Preincrement number is : " + incrementnum);
            incrementnum++;
            Console.WriteLine("Postincrement number is : " + incrementnum);

        }
    }
}
