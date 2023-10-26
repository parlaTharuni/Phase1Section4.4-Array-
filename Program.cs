using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            //Arrays
            string[] students3A, students3B;

            students3A = new string[10] { "tharuni\n", "Sheela\n", "Mukesh\n", "Afzal\n", "Ramesh\n", "Geeta\n", "Jason\n", "Robert\n", "Gopal\n", "Meera\n" };
            students3B = new string[10] { "Pinky\n", "Rakesh\n", "Rafi\n", "Mumtaz\n", "Derek\n", "Sukhwinder\n", "Gopi\n", "Tulsi\n", "Chandrika\n", "Ann\n" };

            string[] subjects = new string[6];
            subjects[0] = "Physics";
            subjects[1] = "Chemistry";
            subjects[2] = "Biology";
            subjects[3] = "Calculus";
            subjects[4] = "Computer Science";
            subjects[5] = "Algebra";

            int[] marks = new int[6];
            marks[0] = 67;
            marks[1] = 90;
            marks[2] = 80;
            marks[3] = 55;
            marks[4] = 71;
            marks[5] = 92;

            Console.WriteLine("Students of Class 3A:");
            foreach (string s in students3A)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Students of Class 3B:");
            foreach (string s in students3B)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Marks of Kamal:");
            int total = 0;
            for (int i = 0; i < 6; i++)
            {
                total += marks[i];
                Console.WriteLine(subjects[i] + " = " + marks[i]);
            }
            Console.WriteLine("TOTAL = " + total + "/600 = " + (total * 100 / 600) + " percent");
            Console.ReadLine();
        }
    }

}
    

