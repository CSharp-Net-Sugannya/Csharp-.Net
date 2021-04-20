using System;

namespace ArithmeticDecrement
{
    /*
     *Class Decrement is used to increment the number predecrement and postdecrement
     *Author:Netravati
     *Date:3/2/2021
     */
    class Decrement
    {
        //Main Method Creation
        static void Main(string[] args)
        {
            //decrementnum is variable
            int decrementnum = 500;
            Console.WriteLine("Number Before decrement is : " + decrementnum);
            --decrementnum;
            Console.WriteLine("Predecrement number is : " + decrementnum);
            decrementnum--;
            Console.WriteLine("Postdecrement number is : " + decrementnum);
        }
    }
}


        
