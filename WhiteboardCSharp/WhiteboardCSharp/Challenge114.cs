using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge114
    {
		public static bool GreaterThanOne(string str)
		{
			string[] arr = str.Split('/');
			return Convert.ToInt32(arr[0]) > Convert.ToInt32(arr[1]);
		}
	}
}
