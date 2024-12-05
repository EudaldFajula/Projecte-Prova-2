/*
//PRE: rep 3 números
program validate_num:							
	var 
		int dia;
        int mes;
        int any;
        bool validat;
	endvar
	write("Introdueix el dia, mes i any");
	if (day < 1 || day > 31) then
		write("Introdueix el dia, mes i any");

	if (month < 1 || month > 12) then
		int totalDaysMonth = 0;

	if (month==1 || month==3 || month==5 || month==7 || month==8 || month==10 || month==12 ) then
		totalDaysMonth = 31; break;

	else
		totalDaysMonth = 30; break;

	if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))) then
		totalDaysMonth = 29;

	else totalDaysMonth = 28;
		break;
endprogram	
//POST: retorna si els números (dd, mm, yyyy) estan dins del rang de data corresponent
*/

using System;

namespace Prova_Practica2
{
	public static class Activitat3
	{
		public static bool ValidateNum(int min, int max, int input)
		{
			return (input < min || input > max);
        }
		public static int ChangeTotalDaysMonthByMonth(int month)
		{
            int[] monthTotalDays = { 1, 3, 5, 7, 8, 10, 12 };
            int totalDaysMonth = 0;
            for (int i = 0; i < monthTotalDays.Length; i++)
            {
                if (month == monthTotalDays[i]) { totalDaysMonth = 30; } else { totalDaysMonth = 31; }
            }
			return totalDaysMonth;
        }
		public static int ChangeTotalDaysMonthByYear(int year, int totalDaysMonth)
		{
            if (year % 400 == 0) { totalDaysMonth = 29; } else { totalDaysMonth = 28; }
			return totalDaysMonth;
        }
		public static void Main()
		{
			//Constants
			const string AskDay = "Introdueix el dia: ";
			const string AskMonth = "Introdueix el mes: ";
			const string AskYear = "Introdueix el any: ";
			//Variables
            int day;
            int month;
            int year;
			try
			{
				//Ask to introduce the days
				do
				{
					Console.WriteLine(AskDay);
					day = Convert.ToInt32(Console.ReadLine());
				} while (ValidateNum(1,31,day));
				//Ask to introduce the month
				do
				{
					Console.WriteLine(AskMonth);
					month = Convert.ToInt32(Console.ReadLine());
				}while (ValidateNum(1, 12, month));
				//Ask to introduce the year
                Console.WriteLine(AskYear);
				year = Convert.ToInt32(Console.ReadLine());
				//Search how many total days has his month
                int totalDaysMonth = ChangeTotalDaysMonthByMonth(month);
				//See if the year change the total days of the month
				totalDaysMonth = ChangeTotalDaysMonthByYear(year, totalDaysMonth);
            }
			catch (FormatException) 
			{
				Console.WriteLine("Error");
			}
        }
	}
}
