using System;

namespace Type_7_params_parameter
{
    class Program
    {
        static void show(params int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(" "+ item);
            }
        }
        static void Main(string[] args)
        {
            show();
            Console.WriteLine();
            show(1,12,2);
            Console.WriteLine();
            show(9,5,4,3,2,4,5,6,7,7,8,9,0);
         



        }
    }
}
