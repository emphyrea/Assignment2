// using System;

namespace Assignment2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string StudentName;
            int StudentId;
            string StudentMajor;
            string StudentSemester; 

            Console.Write("Enter your Name." + "\n");
            StudentName = Console.ReadLine();

            Console.Write("Enter your Student ID." + "\n");
            StudentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Major." + "\n");
            StudentMajor = Console.ReadLine();

            Console.Write("Enter your current Semester." + "\n");
            StudentSemester = Console.ReadLine();

            Console.WriteLine(StudentName + " " + StudentId + " " + StudentSemester + " is taking " + StudentMajor + ".");

        }
    }
}