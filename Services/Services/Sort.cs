using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public  class Sort: ISort
    {
        public int[] GetSortedNumbers(int[] numbers)
        {
            int[] sortedNumber = numbers;
            int n = sortedNumber.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortedNumber[j] > sortedNumber[j + 1])
                    {
                        int temp = sortedNumber[j];
                        sortedNumber[j] = sortedNumber[j + 1];
                        sortedNumber[j + 1] = temp;
                    }
                }
            }
            return sortedNumber;
        }
    }
}
