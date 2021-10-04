using System;

namespace ArrayClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 99, 45, 34, 3, 90, 125, 78, 9 };

            BubbleSort(myArray);
            //SelectionSort(myArray);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

        }

        public static void BubbleSort(int[] array)
        {
            for (int wallIndex = array.Length - 1; wallIndex > 0; wallIndex--)
            {
                for (int i = 0; i < wallIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for (int wallIndex = array.Length - 1; wallIndex > 0; wallIndex--)
            {
                int largestAt = 0;
                for (int i = 0; i <= wallIndex; i++)
                {
                    if (array[i] > array[largestAt])
                    {
                        largestAt = i;
                    }
                }
                Swap(array, largestAt, wallIndex);
            }
        }

        public static void Swap(int[] array, int i, int j)
        {
            if (i == j)
            {
                return;
            }
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
