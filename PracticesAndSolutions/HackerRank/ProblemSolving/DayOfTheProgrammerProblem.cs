namespace PracticesAndSolutions.HackerRank.ProblemSolving;

public static class DayOfTheProgrammerProblem
{
    //https://www.hackerrank.com/challenges/day-of-the-programmer
    /*
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string DayOfProgrammer(int year)
    {
        //from jan to sept, without feb
        var days = 215;
        var month = 9;
        var isLeapyear = year >= 1918
            ? year % 4 == 0 && year % 100 != 0 || year % 400 == 0
            : year % 4 == 0;

        if (year == 1918)
        {
            days -= 13;
        }

        var day = 256 - (days + (isLeapyear ? 29 : 28));

        return $"{day:00}.{month:00}.{year}";
    }

    //better solution
    public static string DayOfProgrammerBetterBetterSolution(int year) 
    {
        //changing the calendar they skip 14 days, so you can just add it
        if (year is 1918) return "26.09.1918";

        var isLeapyear = year >= 1918
           ? year % 4 == 0 && year % 100 != 0 || year % 400 == 0
           : year % 4 == 0;

        return $"{(isLeapyear ? 12 : 13):00}.{09:00}.{year}";
    }
}
