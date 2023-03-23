namespace modelirov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //на вход подаются 3 числа, вывести большее (если числа целые и разные)
            int one = Convert.ToInt32(Console.ReadLine());
            int two = Convert.ToInt32(Console.ReadLine());
            int three = Convert.ToInt32(Console.ReadLine());

            if (one > two)
            {
                if (one > three) { Console.WriteLine($"Наибольшее число - {one}"); }
                else { Console.WriteLine($"Наибольшее число - {three}"); }
            }
            else
            {
                if (two > three) { Console.WriteLine($"Наибольшее число - {two}"); }
                else { Console.WriteLine($"Наибольшее число - {three}"); }
            }


            //на вход подаются 3 числа, вывести меньшее (если числа целые и разные)
            int one1 = Convert.ToInt32(Console.ReadLine());
            int two2 = Convert.ToInt32(Console.ReadLine());
            int three3 = Convert.ToInt32(Console.ReadLine());

            if (one1 < two2)
            {
                if (one1 < three3) { Console.WriteLine($"Наименьшее число - {one1}"); }
                else { Console.WriteLine($"Наименьшее число - {three3}"); }
            }
            else
            {
                if (two2 < three3) { Console.WriteLine($"Наименьшее число - {two2}"); }
                else { Console.WriteLine($"Наименьшее число - {three3}"); }
            }


            //на вход подаются 3 числа, вывести их сумму (целые числа)
            int one4 = Convert.ToInt32(Console.ReadLine());
            int two4 = Convert.ToInt32(Console.ReadLine());
            int three4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(one4 + two4 + three4);


            //Перебрать все элементы массива и вывести их сумму
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int sum = default;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }
            Console.WriteLine(sum);


            //Найти наибольший элемент массива с помощью цикла
            int[] nums1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int big = nums1[0];
            for (int i = 1; i < nums1.Length; i++)
            {
                if (big < nums1[i])
                { big = nums1[i]; }
            }
            Console.WriteLine(big);


            //Вывести все четные элементы из массива
            int[] nums2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < nums2.Length; i++)
            {
                if (nums2[i] % 2 == 0) { Console.WriteLine(nums2[i]); }
            }


            //Найти наименьший элемент массива с помощью цикла
            int[] nums3 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int mini = nums3[0];
            for (int i = 1; i < nums3.Length; i++)
            {
                if (mini > nums3[i])
                { mini = nums3[i]; }
            }
            Console.WriteLine(mini);


            //Вывести все нечетные элементы из массива
            int[] nums4 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < nums4.Length; i++)
            {
                if (nums4[i] % 2 != 0) { Console.WriteLine(nums4[i]); }
            }


            //На вход подаются 3 числа вывести среднее арифметическое
            double one6 = Convert.ToInt32(Console.ReadLine());
            double two6 = Convert.ToInt32(Console.ReadLine());
            double three6 = Convert.ToInt32(Console.ReadLine());

            double result = (one6 + two6 + three6) / 3;

            Console.WriteLine(result);


            //Вывести все элементы из массива которые больше 0
            int[] nums5 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < nums5.Length; i++)
            {
                if (nums5[i] > 0) { Console.WriteLine(nums5[i]); }
            }


            //Вывести все элементы из массива которые меньше 0
            int[] nums6 = { -1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < nums6.Length; i++)
            {
                if (nums6[i] < 0) { Console.WriteLine(nums6[i]); }
            }
        }
    }
}