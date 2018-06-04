using System;

namespace SortingPractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 11, 1, 40, 90, 8, 120, 58, 68, 21, 5 };
            int numb;

            numb = array.Length;
            Console.WriteLine("Origional Array Elements: ");
            show_array_elements(array);
            shellSort(array, numb);
            Console.WriteLine("\nSorted Array Elements: ");
            show_array_elements(array);

        }

        static void shellSort(int[] arr, int array_size) {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0) {
                for (i = 0; i < array_size; i++) {
                    j = i;
                    temp = arr[i];
                    while((j >= inc) && (arr[j - inc] > temp)) {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }

        static void show_array_elements(int[] arr) {
            foreach(var element in arr) {
                Console.Write(element + " ");
            }
            Console.Write("\n");
        }
    }
}
