namespace PracticesAndSolutions.HackerRank.ProblemSolving;

public static class CatAndMouseProblem
{
    //https://www.hackerrank.com/challenges/cats-and-a-mouse/problem
    public static string CatAndMouse(int x, int y, int z)
    {
        var catA = Math.Abs(z - x);
        var catB = Math.Abs(z - y);

        return catA < catB
            ? "Cat A" : catB == catA ? "Mouse C"
            : "Cat B";
    }
}
