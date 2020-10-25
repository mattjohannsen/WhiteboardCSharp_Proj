using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge126
    {
        public static string Accum(string str)
        {

            char[] arr = str.ToCharArray();
            List<char> solution = new List<char>();
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < i + 1; j++)
                {
                    if (count == 0)
                    {
                        solution.Add(Char.ToUpper(arr[i]));
                    }
                    else
                    {
                        solution.Add(Char.ToLower(arr[i]));
                    }
                    count++;
                }
                if (i < arr.Length - 1)
                {
                    solution.Add(Char.ToLower('-'));
                }
            }
            return new string(solution.ToArray());
        }
    }
}
