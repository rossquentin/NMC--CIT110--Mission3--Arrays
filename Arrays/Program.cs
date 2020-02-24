using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numOfQuizzes = 5;
            double[] quizArray = new double[numOfQuizzes];

            quizArray = GetQuizScores(5);
            DisplayQuizScores(quizArray);
            DisplayQuizAverage(quizArray);
        }

        public static double[] GetQuizScores(int numOfQuizzes)
        {
            double[] array = new double[numOfQuizzes];
            double score;

            for (int i = 0; i < numOfQuizzes; i++)
            {
                Console.Write("Quiz {0} score: ", i + 1);
                double.TryParse(Console.ReadLine(), out score);
                array[i] = score;
            }

            DisplayContinuePrompt();

            return array;
        }
        
        public static void DisplayQuizScores(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Quiz {0} score: {1}", i + 1, array[i]);
            }

            DisplayContinuePrompt();
        }

        public static void DisplayQuizAverage(double[] array)
        {
            double sum = 0;
            double average;

            foreach (int quiz in array)
            {
                sum += quiz;
            }
            average = sum / array.Length;
            Console.WriteLine("Average is: {0}", average);

            DisplayContinuePrompt();
        }

        public static void DisplayContinuePrompt()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.Clear();
        }
    }
}
