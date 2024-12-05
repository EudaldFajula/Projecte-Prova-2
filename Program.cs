using System;

namespace Prova_Practica2
{
	public static class Activitat5
	{	
		public static int[] BubbleSort(int[] arrayBubbleSort)
		{
			for (int i = 0; i < arrayBubbleSort.Length; i++)
			{
				for (int j = i + 1; j < arrayBubbleSort.Length; j++)
				{
					if (arrayBubbleSort[i] < arrayBubbleSort[j])
					{
						int aux = arrayBubbleSort[i];
						arrayBubbleSort[i] = arrayBubbleSort[j];
						arrayBubbleSort[j] = aux;
                    }
				}

            }
			return arrayBubbleSort;
		}
        public static bool BinarySearch(int[] array, int numSearch)
        {
			int i = 0;
            while (i < array.Length)
			{
				if (array[i] == numSearch)
				{
					return true;
				}
				else
				{
					i++;
				}
            }
			return false;
        }
        public static void Main()
		{
			//Constant strings
			const string Msg = "Introdueix ara 20 valors: ";
			const string Msg1Value = "Introdueix el valor: ";
			const string AskSearchNum = "Quin valor vols buscar? ";
			const string NumFound = "El teu valor esta dintre de la llista!!";
			const string NumNotFound = "El teu valor no esta dintre de la llista :(";
			//Variables
			int[] arrayNumsUser = new int[20];
			Console.WriteLine(Msg);
			try
			{
				//Afegir numeros al array
				for (int i = 0; i < arrayNumsUser.Length; i++)
				{
					Console.WriteLine(Msg1Value);
					arrayNumsUser[i] = Convert.ToInt32(Console.ReadLine());
				}
				//Ordernar el array
                arrayNumsUser = BubbleSort(arrayNumsUser);
				//Imprimir el array ordenar
				for (int i = 0;i < arrayNumsUser.Length; i++)
				{
					Console.Write($"{arrayNumsUser[i]}, ");
				}
				Console.WriteLine($"\n{AskSearchNum}");
				int numSearch = Convert.ToInt32(Console.ReadLine());
				//Avisar si el numero que a entrat esta en el array o no
				Console.WriteLine(BinarySearch(arrayNumsUser, numSearch) ? NumFound : NumNotFound);
            }
			catch (FormatException) 
			{
				Console.WriteLine("Error");
			}
        }
	}
}
