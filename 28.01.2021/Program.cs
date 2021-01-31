using System;

namespace _28._01._2021
{
    public static class ArrayHelper
    {
        public static string Pop(ref string[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Ваш массив пуст.");
             
                return "0";
            }

            string deleted = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return deleted;
        }

        public static int Pop(ref int[] arr)
        {
            if (arr.Length == 0)
            {     
                Console.WriteLine("Ваш массив пуст.");
                return 0;
            }

            int deleted = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return deleted;
        }

        public static double Pop(ref double[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Ваш массив пуст.");
                return 0;
            }

            double deleted = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return deleted;
        }

        public static decimal Pop(ref decimal[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Ваш массив пуст.");
                return 0;
            }

            decimal deleted = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return deleted;
        }

        public static float Pop(ref float[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Ваш массив пуст.");

                return 0;
            }

            float deleted = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return deleted;
        }

        public static int Push(ref string[] arr, string added)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = added;
            return arr.Length;
        }
        public static int Push(ref int[] arr, int added)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = added;
            return arr.Length;
        }
        public static int Push(ref double[] arr, double added)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = added;
            return arr.Length;
        }
        public static int Push(ref decimal[] mas, decimal added)
        {
            Array.Resize(ref mas, mas.Length + 1);
            mas[mas.Length - 1] = added;
            return mas.Length;
        }
        public static int Push(ref float[] arr, float added)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = added;
            return arr.Length;
        }

        public static string Shift(ref string[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Ваш массив пуст");
            }
            Array.Reverse(arr);
            string added = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            Array.Reverse(arr);
            return added;
        }

        public static int Shift(ref int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Ваш массив пуст");
            }
            Array.Reverse(arr);
            int added = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            Array.Reverse(arr);
            return added;
        }
        public static double Shift(ref double[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Ваш массив пуст");
            }
            Array.Reverse(arr);
            double added = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            Array.Reverse(arr);
            return added;
        }
        public static decimal Shift(ref decimal[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Ваш массив пуст");
            }
            Array.Reverse(arr);
            decimal added = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            Array.Reverse(arr);
            return added;
        }
        public static float Shift(ref float[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Ваш массив пуст");
            }
            Array.Reverse(arr);
            float added = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            Array.Reverse(arr);
            return added;
        }

        public static int UnShift(ref string[] arr, string added)
        {
            Array.Reverse(arr);
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = added;
            Array.Reverse(arr);
            return arr.Length;
        }
        public static int UnShift(ref int[] arr, int added)
        {
            Array.Reverse(arr);
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = added;
            Array.Reverse(arr);
            return arr.Length;
        }
        public static int UnShift(ref double[] arr, double added)
        {
            Array.Reverse(arr);
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = added;
            Array.Reverse(arr);
            return arr.Length;
        }
        public static int UnShift(ref decimal[] arr, decimal added)
        {
            Array.Reverse(arr);
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = added;
            Array.Reverse(arr);
            return arr.Length;
        }
        public static int UnShift(ref float[] arr, float added)
        {
            Array.Reverse(arr);
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = added;
            Array.Reverse(arr);
            return arr.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] str_arr = { "10", "11", "12", "13" };
            int[] int_arr = { 1, 2, 3, 4, 5 };
            double[] dub_arr = { 2.3, 7.8, 99.8, 110.9 };
            decimal[] dec_arr = { 3.4m, 5.7m, 9.7m, 5.8m };
            float[] flt_arr = { 9.4f, 10.3f, 14.5f, 11.2f };

            Console.WriteLine("Метод Pop: ");

            Console.Write("Массив до использования метода Pop: ");
            for (int i = 0; i < int_arr.Length; i++)
            {
                Console.Write($"{int_arr[i]} ");
            }
            Console.WriteLine($"\nВы удалили элемент массива: {ArrayHelper.Pop(ref int_arr)}");

            Console.Write("Массив после использования метода Pop: ");
            for (int i = 0; i < int_arr.Length; i++)
            {
                Console.Write($"{int_arr[i]} ");
            }
            Console.WriteLine();


            Console.WriteLine("\nМетод Push: ");

            Console.WriteLine($"Размер массива до использования метода Push: {int_arr.Length}");

            Console.Write("Массив до использования метода Push: ");
            for (int i = 0; i < int_arr.Length; i++)
            {
                Console.Write($"{int_arr[i]} ");
            }
            Console.Write($"\nВы добавили элемент ");
            Console.Write("<4>");
            Console.WriteLine($" в массив, " +
                $"его размер после использования метода Push: {ArrayHelper.Push(ref int_arr, 10)}");
            Console.Write("Массив после использования метода Push: ");
            Console.Write("Массив после использования метода Push: ");
            for (int i = 0; i < int_arr.Length; i++)
            {
                Console.Write($"{int_arr[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("\nМетод Shift: ");

            Console.Write("Массив до использования метода Shift: ");
            for (int i = 0; i < int_arr.Length; i++)
            {
                Console.Write($"{int_arr[i]} ");
            }
            Console.WriteLine($"\nВы удалили элемент массива: {ArrayHelper.Shift(ref int_arr)}");
            Console.Write("Массив после использования метода Shift: ");
            for (int i = 0; i < int_arr.Length; i++)
            {
                Console.Write($"{int_arr[i]} ");
            }
            Console.WriteLine();

  
            Console.WriteLine("\nМетод UnShift: ");

            Console.WriteLine($"Размер массива до использования метода UnShift: {int_arr.Length}");
            Console.Write("Массив до использования метода UnShift: ");
            for (int i = 0; i < int_arr.Length; i++)
            {
                Console.Write($"{int_arr[i]} ");
            }
            Console.Write($"\nВы добавили элемент ");
            Console.Write("<46>");
            Console.WriteLine($" в массив, " +
                $"его размер после использования метода UnShift: {ArrayHelper.UnShift(ref int_arr, 46)}");
            Console.Write("Массив после использования метода UnShift: ");
            for (int i = 0; i < int_arr.Length; i++)
            {
                Console.Write($"{int_arr[i]} ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

