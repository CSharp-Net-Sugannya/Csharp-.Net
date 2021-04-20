using System;


namespace Task.Utility
{
    class Helper
    {
        public static int RandomSelection(int length)
        {
            
            Random fruitChoice = new Random();
            int value = fruitChoice.Next(1, length);
            Console.WriteLine("The value is:" + value);

            if (value == 3)
            {
                Console.WriteLine("Congratulations you have won ORANGE today");
            }
            else
            {
                Console.WriteLine("You lose it ");
            }
            
            return value;

        }
    }
    }

