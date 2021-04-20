using System;

namespace StudentApp
{
    public class College
    {
        private string collegeName;
        private string city;

        public void collegeDetails()
        {
            Console.WriteLine("Enter the College Name:");
            collegeName = Console.ReadLine();
            Console.WriteLine("Enter the city Name:");
            city = Console.ReadLine();
        }

        public void displayCollegeDetails()
        {
            Console.WriteLine("College Name is:" + collegeName);
            Console.WriteLine("City Name is:" + city);
        }
    }
}
