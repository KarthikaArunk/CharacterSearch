
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace CharacterSearch
{
    public class Character_Search
    {
        public static void Main()
        {
            
            Console.WriteLine("\n\n");

            Console.Write("Enter a string:  ");
            String inputString = Console.ReadLine();
            
            inputString = inputString.ToLower();

            int[] count = new int[256];
            int length = inputString.Length;

            for(int i=0;i<length;i++)
            {
                count[inputString[i]]++;
            }

            int highcount = 0;
            char charac = ' ';

            for(int i=0; i<length;i++)
            {
                if(count[inputString[i]] > highcount)
                {
                    highcount=count[inputString[i]];
                    charac = inputString[i];
                }
            }
            Console.WriteLine("\n");
            Console.Write("The highest occuring character is: " + charac);
            Console.WriteLine("\n");
        }
    }
}
