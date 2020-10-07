using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge108
    {
		public static bool KToK(string n, int k)
		{
			return false;
		}
	}
}
//Testing K^K == N?
//Write a function that returns true if k^k == n for input(n, k) and return false otherwise.
//Examples
//KToK("4", 2) --> true
//KToK("387420489", 9) --> true
//# 9^9 == 387420489
//KToK("3124", 5) --> false
//KToK("17", 3) --> false
//Notes
//The ^ operator refers to exponentiation operation, not the bitwise XOR operation.