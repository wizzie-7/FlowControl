using System;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter specific number :");
            a = Convert.ToInt32(Console.ReadLine());
            ForLoop FL = new ForLoop();
            FL.calculation(a);


            int i = 0;
            Console.WriteLine("Enter the size of Array :");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[size];
            for (i=0; i <= size-1; i++)
            {
                Console.WriteLine("Enter the Numbers in Array :");
                 Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            ForEachLoopDemo FED = new ForEachLoopDemo();
            FED.PrintMax(Arr);

        }
    }

    //print fibonacci series using for loop
    class ForLoop
    {
        public void calculation(int a)
        {
            int num1 = 0, num2 = 1, num3 = 0;
            Console.Write(num1 + " " + num2);
            for (int i = 0; i <= a; i++)
            {
                num3 = num1 + num2;
                Console.Write(" " + num3);
                num1 = num2;
                num2 = num3;
            }

        }

    }
    
    //print maximum no from array using for each loop

    public class ForEachLoopDemo
    {
        public void PrintMax(int[] arr)
        {
            int max = arr[0];
            foreach(int num in arr)
            {
                if(num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("Maximum no in array is :" + max);
        }
    }

    
}
