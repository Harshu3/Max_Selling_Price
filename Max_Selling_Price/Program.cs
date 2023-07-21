using System;

namespace Max_Selling_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum Selling Price Problem!");
            Console.WriteLine("Enter the values of N and K");
            string str = Console.ReadLine();
            string[] input = str.Split(' ');
            int N = Convert.ToInt32(input[0]);
            int K = Convert.ToInt32(input[1]);

            Console.WriteLine("Enter the selling price of fruits in Basket-A space seperated");
            string str1 = Console.ReadLine();
            string[] Basket_A = str1.Split(' ');
            Console.WriteLine("Enter the selling price of fruits in Basket-B space seperated");
            string str2 = Console.ReadLine();
            string[] Basket_B = str2.Split(' ');
            int[] basket_A = SortArray(Basket_A);
            int[] basket_B = SortArray(Basket_B);
            Array.Sort(basket_A);
            Array.Sort(basket_B);
            List<int> l = basket_B.ToList();
            l.Reverse();
            int count = 0;
            for (int i = 0; i < basket_A.Length; i++)
            {
                if (l[i] > basket_A[i])
                {
                    basket_A[i] = l[i];
                    count++;
                }
                if (count == K)
                    break;
            }
            Console.WriteLine("Swapped array");
            int sum = 0;
            foreach (int i in basket_A)
            {
                sum += i;
            }
            Console.WriteLine("Sum: " + sum);
        }

        public static int[] SortArray(string[] arr)
        {
            int[] intArr1 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                intArr1[i] = Convert.ToInt32(arr[i]);
            }
            return intArr1;
        }
    }
}