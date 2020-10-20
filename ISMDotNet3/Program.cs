using System;
using System.Linq;

namespace ISMDotNet3
{
    class Program
    {

        public static int NegativeElementsSumm(int[] array)
        {
            int negativeElementsSumm = 0;
            for (int i = 0; i < array.Length; i++) if (array[i] < 0)
                {
                    negativeElementsSumm += array[i];
                }
            return negativeElementsSumm;
        }

        public static int MaxElement(int[] array)
        {
            int maxValue = array.Max();
            return maxValue;
        }

        public static int MaxElementIndex(int[] array)
        {
            return Array.FindIndex(array, e => e == array.Max());
        }

        public static int MaxModuleElement(int[] array)
        {
            
            int maxModule = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (maxModule < Math.Abs(array[i]))
                {
                    maxModule = Math.Abs(array[i]);
                }
            }
            return maxModule;
        }

        public static int PositiveElementsIndexSumm(int[] array)
        {
            
            int indexSumm = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0 && array[i] > 0)
                {
                    indexSumm += array[i];
                }

            }
            return indexSumm;
        }

        public static int IntegersElements(int[] array)
        {
            
            int integersElements = 0;
            for (int i = 0; i < array.Length; i++)
            {
                integersElements += array[i];
            }
            return integersElements;
        }

        public static void DescendingOrderSort(int[] array)
        {
            
            Array.Sort(array);
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Element #{i} = {array[i]}");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter size of array:");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Element #{i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }



            int task_1 = NegativeElementsSumm(array);
            Console.WriteLine("Sum of negative elements :" + task_1);

            int task_2 = MaxElement(array);
            Console.WriteLine("Max value:" + task_2);

            int task_3 = MaxElementIndex(array);
            Console.WriteLine("Index of max value:" + task_3);

            int task_4 = MaxModuleElement(array);
            Console.WriteLine("Max module element:" + task_4);

            int task_5 = PositiveElementsIndexSumm(array);
            Console.WriteLine("Summ of index positive elements:" + task_5);

            int task_6 = IntegersElements(array);
            Console.WriteLine("The number of integers in the array:" + task_6);
        }
    }
}
