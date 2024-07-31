namespace PracticesAndSolutions.Leetcode;

public class ValidSudokuProblem
{
    //https://leetcode.com/problems/valid-sudoku/description/
    public static bool IsValidSudoku(char[][] board)
    {
        var rows = new HashSet<char>[9];
        var columns = new HashSet<char>[9];
        var subSquare = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            columns[i] = new HashSet<char>();
            subSquare[i] = new HashSet<char>();
        }

        for (int i = 0; i < 9; i++)
        {
            for (int ii = 0; ii < 9; ii++)
            {
                if (board[i][ii] == '.')
                    continue;

                if (rows[i].Add(board[i][ii]) == false)
                    return false;

                if (columns[ii].Add(board[i][ii]) == false)
                    return false;

                // 3x3 sub square control
                int squareIndex = (i / 3) * 3 + (ii / 3);
                if (subSquare[squareIndex].Add(board[i][ii]) == false)
                    return false;
            }
        }

        return true;
    }
}
