using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge37
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       SockPairs('AA') --> {SockPairs("AA")}");
            Console.WriteLine($"       SockPairs('ABABC') --> {SockPairs("ABABC")}");
            Console.WriteLine($"       SockPairs('CABBACCC') --> {SockPairs("CABBACCC")}");
        }
        public static int SockPairs(string str)
        {
            int sockPairs = 0;
            List<char> stringAsList = str.ToList();
            List<char> charactersInString = new List<char>();
            for (int i = 0; i < stringAsList.Count; i++)
            {
                if (!charactersInString.Contains(stringAsList[i]))
                {
                    charactersInString.Add(stringAsList[i]);
                }
            }
            List<int> numberOfSocks = new List<int>();
            for (int i = 0; i < charactersInString.Count; i++)
            {
                var count = stringAsList.Count(x => x == charactersInString[i]);
                numberOfSocks.Add(count);
            }
            for (int i = 0; i < charactersInString.Count; i++)
            {
                if (numberOfSocks[i] == 1)
                {
                    continue;
                }
                else if (numberOfSocks[i] % 2 == 0)
                {
                    sockPairs += (numberOfSocks[i] / 2);
                }
                else
                {
                    sockPairs += ((numberOfSocks[i] - 1) / 2);
                }
            }
            return sockPairs;
        }
        private void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 37: Sock Pairs");
            Console.WriteLine("       Joseph is in the middle of packing for a vacation.");
            Console.WriteLine("       He's having a bit of trouble finding all of his socks, though.");
            Console.WriteLine("       Write a function that returns the number of sock pairs he has.");
            Console.WriteLine("       A sock pair consists of two of the same letter, such as 'AA'.");
            Console.WriteLine("       The socks are represented as an unordered sequence.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       SockPairs(AA) --> 1");
            Console.WriteLine("       SockPairs(ABABC) --> 2");
            Console.WriteLine("       SockPairs(CABBACCC) --> 4");
            Console.WriteLine("       Notes");
            Console.WriteLine("       If given an empty string (no socks in the drawer), return 0.");
            Console.WriteLine("       There can be multiple pairs of the same type of sock, such as two pairs of CC for the last example.\n");
        }
    }
}
//Sock Pairs
//Joseph is in the middle of packing for a vacation.
//He's having a bit of trouble finding all of his socks, though. Write a function that returns the number of sock pairs he has. A sock pair consists of two of the same letter, such as 'AA'. The socks are represented as an unordered sequence.
//Examples
//SockPairs("AA") --> 1
//SockPairs("ABABC") --> 2
//SockPairs("CABBACCC") --> 4
//Notes
//If given an empty string (no socks in the drawer), return 0.
//There can be multiple pairs of the same type of sock, such as two pairs of CC for the last example.
// Steps
// Turn inputString into --> List<char> stringAsList

// create List<char> charactersInString;
// Loop through stringAsList --> i loop
// if (!stringAsList.Contains(stringAsList[i])
// then charactersInString.Add(stringAsList[i]) 
// create List<int> numberOfSocks = new List<int>();

// loop through charactersInString
// var count = mystring.Count(x => x == 'charactersInString[i]')
// add count to numberOfSocks list

// create int sockPairs = 0
// loop through charactersInString
// if numberOfSocks[i] % 2 = 0 then
// add numberOfSocks[i]/2 to the sockPairs
// else if numberOfSocks[i] = 1 then
// continue
// else
// add numberOfSocks -1/2 to the sockPairs
// return sockPairs