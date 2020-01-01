using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded_40
{
    class Program
    {
        public static int[] numbers = new int[1000000];

        public static void Set100ItemsInArray(object index)
        {
            int intedIndex = (int)index;
            for (int i = intedIndex; i < intedIndex + 100000; i++)
            {
                numbers[i] = 1;
            }
            Console.WriteLine($"finished settings cells {intedIndex} - {intedIndex + 100000}");
        }

        static void Main(string[] args)
        {
            //Question 1:

            //Thread QThread = new Thread(MathQuiz);
            //Thread TThread = new Thread(QuizTimer);
            //QThread.Start();
            //Thread.Sleep(250);
            //TThread.Start();
            //while(QThread.ThreadState != ThreadState.Stopped && TThread.ThreadState != ThreadState.Stopped)
            //{
            //    Thread.Yield();
            //}
            //if (TThread.ThreadState != ThreadState.Stopped)
            //{
            //    TThread.Abort();
            //    Console.WriteLine("Correct!");
            //}

            //if (QThread.ThreadState != ThreadState.Stopped)
            //{
            //    QThread.Abort();
            //    Console.WriteLine("Game Over!");
            //}
            //===============================================================================
            //Question 2:

            Set100ItemsInArray(0);
            Set100ItemsInArray(100000);
            Set100ItemsInArray(200000);
            Set100ItemsInArray(300000);
            Set100ItemsInArray(400000);
            Set100ItemsInArray(500000);
            Set100ItemsInArray(600000);
            Set100ItemsInArray(700000);
            Set100ItemsInArray(800000);
            Set100ItemsInArray(900000);
            Console.WriteLine("done!");
            Console.WriteLine(Stopwatch.GetTimestamp()); //52,549,581,734 //57,283,827,147


            //Thread t1 = new Thread(Set100ItemsInArray);
            //Thread t2 = new Thread(Set100ItemsInArray);
            //Thread t3 = new Thread(Set100ItemsInArray);
            //Thread t4 = new Thread(Set100ItemsInArray);
            //Thread t5 = new Thread(Set100ItemsInArray);
            //Thread t6 = new Thread(Set100ItemsInArray);
            //Thread t7 = new Thread(Set100ItemsInArray);
            //Thread t8 = new Thread(Set100ItemsInArray);
            //Thread t9 = new Thread(Set100ItemsInArray);
            //Thread t10 = new Thread(Set100ItemsInArray);

            //t1.Start(0);
            //t2.Start(100000);
            //t3.Start(200000);
            //t4.Start(300000);
            //t5.Start(400000);
            //t6.Start(500000);
            //t7.Start(600000);
            //t8.Start(700000);
            //t9.Start(800000);
            //t10.Start(900000);
            //Console.WriteLine("Done!");
            //Console.WriteLine(Stopwatch.GetTimestamp()); //54,669,706,721 //55,491,111,666

            //singlethreading: 1000: 52,549,581,734 // 1000000: 57,283,827,147
            //multi-threading: 1000: 54,669,706,721 // 1000000: 55,491,111,666
        }

        static void MathQuiz()
        {
            Random rng = new Random();
            int num1 = rng.Next(1, 10);
            int num2 = rng.Next(1, 10);
            int answer = num1 * num2;

            Console.WriteLine($"what's {num1} X {num2} ?");
            int guess = -1;
            while (int.TryParse(Console.ReadLine(), out guess) == false || guess != answer)
            {
                if(guess == answer)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong! Try again!");
                }
            }
            
        }

        static void QuizTimer()
        {
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine("                    " + i);
                Thread.Sleep(1000);
            }
        }
    }
}
