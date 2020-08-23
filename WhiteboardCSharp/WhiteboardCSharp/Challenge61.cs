using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardCSharp
{
    public class Challenge61
    {
        public void RunChallenge()
        {
            ChallengeDescription();
            Console.WriteLine($"       {ConvertTime("12:00 am")}");
            Console.WriteLine($"       {ConvertTime("6:20 pm")}");
            Console.WriteLine($"       {ConvertTime("21:00")}");
            Console.WriteLine($"       {ConvertTime("5:05")}");
        }
        public static string ConvertTime(string time)
        {
            DateTime dt = DateTime.Parse(time); 
            return (time.Contains("am")) || (time.Contains("pm")) ? dt.ToString("H:mm") : dt.ToString("h:mm tt").ToLower();
        }
        public void ChallengeDescription()
        {
            Console.WriteLine("       Challenge 61: 12 vs 24 Hours");
            Console.WriteLine("       Create a function that converts 12-hour time to 24-hour time or vice versa.Return the output as a string.");
            Console.WriteLine("       Examples");
            Console.WriteLine("       ConvertTime(12:00 am) --> 0:00");
            Console.WriteLine("       ConvertTime(6:20 pm) --> 18:20");
            Console.WriteLine("       ConvertTime(21:00) --> 9:00 pm");
            Console.WriteLine("       ConvertTime(5:05) --> 5:05 am");
            Console.WriteLine("       Notes");
            Console.WriteLine("       A 12-hour time input will be denoted with an am or pm suffix.");
            Console.WriteLine("       A 24-hour input time contains no suffix.\n");
        }
    }
}
//12 vs 24 Hours
//Create a function that converts 12-hour time to 24-hour time or vice versa.Return the output as a string.
//Examples
//ConvertTime("12:00 am") --> "0:00"
//ConvertTime("6:20 pm") --> "18:20"
//ConvertTime("21:00") --> "9:00 pm"
//ConvertTime("5:05") --> "5:05 am"
//Notes
//A 12-hour time input will be denoted with an am or pm suffix.
//A 24-hour input time contains no suffix.
// Steps
// For 12 hour time ==> 24 hour time
// split time into hoursMinutes and amPm
// split hourMinutes into hours and minutes
// if amPm = am then
// return hoursMinutes
// if amPm = pm then
// add 12 to hours and return hours + ":" + minutes
// For 24 hour time ==> 12 hour time
// split time into hours and minutes
// if hours > 12
// subtract 12 from hours and return hours + minutes + amPm
// if hours < 12
// return hours + minutes + amPm

