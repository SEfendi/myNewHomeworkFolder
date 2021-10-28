using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2810
{
    static class Helper
    {
        public static string ReturnFirstLongestWord(string[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].Length < arr[i + 1].Length)
                {
                    string temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    i = -1;
                }
            }
            return arr[0];
        }
    }
}
