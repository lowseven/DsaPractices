using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.HackerRank.ProblemSolving
{
    public static class GradingProblem
    {
        /*
         * Complete the 'gradingStudents' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
         */

        public static List<int> GradingStudents(List<int> grades)
        {
            for (var i = 0; i < grades.Count; ++i)
            {
                if (grades[i] < 38)
                    continue;

                var nextGrade = (grades[i] / 5) * 5 + 5;
                if (nextGrade - grades[i] < 3)
                    grades[i] = nextGrade;
            }

            return grades;
        }
    }
}
