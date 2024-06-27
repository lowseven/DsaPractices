namespace PracticesAndSolutions.HackerRank.ProblemSolving;

public static class DesignerPdfViewerProblem
{
    //https://www.hackerrank.com/challenges/designer-pdf-viewer/problem
    /*
     * Complete the 'designerPdfViewer' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY h
     *  2. STRING word
     */
    /*
     * 1 <= t[?] <= 7 where  is an English lowercase letter.
     * contains no more than  letters. 
     */

    public static int DesignerPdfViewer(List<int> h, string word)
    {
        int tallest = 0;
        foreach (int i in word)
        {
            if (h[i - 'a'] > tallest)
                tallest = h[i - 'a'];
        }

        return (tallest * word.Length);
    }
}
