using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WhiteboardCSharp
{
    public class Challenge46
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       WeekdayRobWasBornInDutch(new DateTime(1970, 9, 21)) --> {WeekdayRobWasBornInDutch(new DateTime(1970, 9, 21))}");
            Console.WriteLine($"       WeekdayRobWasBornInDutch(new DateTime(1945, 9, 2)) --> {WeekdayRobWasBornInDutch(new DateTime(1945, 9, 2))}");
            Console.WriteLine($"       WeekdayRobWasBornInDutch(new DateTime(2001, 9, 11)) --> {WeekdayRobWasBornInDutch(new DateTime(2001, 9, 11))}");
        }
        public string WeekdayRobWasBornInDutch(DateTime inputTime)
        {
            return inputTime.ToString("dddd", new CultureInfo("nl-NL"));
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 46: The Day Rob Was Born in Dutch");
            Console.WriteLine("       I was born on the 21st of September in the year of 1970. That was a Monday.");
            Console.WriteLine("       Write a method that when passed a date as year/month/ day and returns the date's");
            Console.WriteLine("       weekday name in the Dutch culture. The culture identifier to use is 'nl-NL'. Not 'nl-BE'.");
            Console.WriteLine("       You can assume the specified date is valid.");
            Console.WriteLine("       Looking at the tests and doing a switch statement or similar is considered cheating.");
            Console.WriteLine("       System.Globalization.CultureInfo should be used.");
            Console.WriteLine("       The method may be used to get the name of the Dutch weekday of other memorable days too, like in the examples below:");
            Console.WriteLine("       Examples");
            Console.WriteLine("       WeekdayRobWasBornInDutch(new DateTime(1970, 9, 21)) --> maandag");
            Console.WriteLine("       WeekdayRobWasBornInDutch(new DateTime(1945, 9, 2)) --> zondag");
            Console.WriteLine("       WeekdayRobWasBornInDutch(new DateTime(2001, 9, 11)) --> dinsdag\n");
        }
    }
}
//The Day Rob Was Born in Dutch
//I was born on the 21st of September in the year of 1970. That was a Monday.Where I was born that weekday is called måndag.
//Write a method that when passed a date as year/month/ day and returns the date's weekday name in the Dutch culture. The culture identifier to use is 'nl-NL'. Not 'nl-BE'.
//You can assume the specified date is valid.
//Looking at the tests and doing a switch statement or similar is considered cheating.
//System.Globalization.CultureInfo should be used.
//The method may be used to get the name of the Dutch weekday of other memorable days too, like in the examples below:
//Examples
//WeekdayRobWasBornInDutch(new DateTime(1970, 9, 21)) --> 'maandag'
//WeekdayRobWasBornInDutch(new DateTime(1945, 9, 2)) --> 'zondag'
//WeekdayRobWasBornInDutch(new DateTime(2001, 9, 11)) --> 'dinsdag'
// 