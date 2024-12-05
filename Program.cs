using Microsoft.VisualBasic;
using System;

/*He fet servir les llibreries de SearchClass i SecondSort, perque la de SearchClass busca el numero fent servir el binary search
 * i la llibreria de SecondSort perque fa servir el algoritme de bubbleSort per a ordenar el array*/

namespace ProvaPractica2
{
    public static class Activitat2
    {
        public static int BinarySearch(int[] arr, int first, int last, int key)
        {
            if (last >= first)
            {
                int mid = first + (last - first) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                if (arr[mid] > key)
                {
                    return BinarySearch(arr, first, mid - 1, key);//cerca en el subarray esquerre
                }
                else
                {
                    return BinarySearch(arr, mid + 1, last, key);//cerca en el subarray dret
                }
            }
            return -1;
        }
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static int Divide(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return (i + 1);
        }

        public static void Order(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Divide(arr, low, high);
                Order(arr, low, pi - 1);
                Order(arr, pi + 1, high);
            }
        }
        public static void Main()
        {
            const string Msg = "Introdueix un valor: ";
            const string NotInList = "El teu valor no esta en la llista";
            const string InList = "EL teu valor esta en la llista";
            int[] array = { 10, 4, 6, 4, 8, -13, 2, 3 };
            int num;
            Console.WriteLine(Msg);
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(BinarySearch(array));
                Console.WriteLine(Order(array));
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}