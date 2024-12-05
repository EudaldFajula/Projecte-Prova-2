using System;

namespace Prova_Practica2
{
	public class Activitat6
	{	
        public static bool ContrasenyaLength(string password)
		{
			if (password.Length < 6 || password.Length > 15)
			{
				return false;
			}
			else
			{
				return true;
			}
        }
		public static bool ContrasenyaValues(string password)
		{
			char[] bannedValues = {'@','/','*','^'};
            for (int i = 0; i < password.Length; i++)
            {
                for (int j = 0; j < bannedValues.Length; j++)
                {
                    if (password[i] == bannedValues[j])
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }

            }
			return false;
			
		}
		public static bool ContrasenyaValue(string password)
		{
			char[] bannedValues = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
			for (int i = 0; i < bannedValues.Length; i++)
			{
				if (password.StartsWith(bannedValues[i]) || password.EndsWith(bannedValues[i]))
				{
					return false;
				}
				else
				{
					return true;
				}
			}
			return false;
		}
		public static void Main()
		{

		}
    }
}
