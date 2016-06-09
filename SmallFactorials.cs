using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallFactorial
{ 
    class SmallFactorials
    {
        static string getFactorial(int number)
        {
            int[] array = new int[1000];
            int num = number, index = 0, m = 0;
            while (num != 0)
            {   // inputing of input number into the array in reverse order
                array[index] = num % 10;
                num = num / 10;
                index++;
                m++;
            }
            int temp, x = 0, ind;
            for (int i = 2; i < number; i++)
            {
                temp = 0;
                for (ind = 0; ind < m; ind++)
                {  // multiplying of number on each position of array
                    x = array[ind] * i + temp; 
                    array[ind] = x % 10; // inputing of rest from number on same position
                    temp = x / 10;  //  remembering of smaller number  
                }

                while (temp != 0)
                { // inputing of rest number into the array in reverse order
                    array[ind] = temp % 10;
                    temp = temp / 10;
                    ind++;
                    m++;
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = m - 1; i >= 0; i--)
            {
                string znak = array[i].ToString();
                sb.Append(znak);
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            int countCases;
            Int32.TryParse(Console.ReadLine(), out countCases);
            if (countCases >= 1 && countCases <= 100)
            {
                for (int i = 0; i < countCases; i++)
                {
                    int number;
                    Int32.TryParse(Console.ReadLine(), out number);

                    Console.WriteLine(getFactorial(number));
                }
            }           
        }
    }
}
