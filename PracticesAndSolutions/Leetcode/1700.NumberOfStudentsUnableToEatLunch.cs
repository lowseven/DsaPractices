using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode;

//https://leetcode.com/problems/number-of-students-unable-to-eat-lunch/
public class NumberOfStudentsUnableToEatLunchProblem
{
    public static int CountStudents(int[] students, int[] sandwiches)
    {
        //-----------------------
        var dict = new Dictionary<int, int>()
        {
            [0] = 0,
            [1] = 0,
        };

        foreach (var student in students)
            dict[student]++;

        var count = students.Length;
        foreach (var s in sandwiches)//the order of the sandwitched matter
        {
            if (dict[s] > 0)
            {
                count--;
                dict[s]--;
            }
            else
            {
                //no more student willing to eat
                //the remaining sandwitched in the listed order
                return count;
            }
        }

        return count;

        //brute force solution
        //-----------------------
        //var stack = new LinkedList<int>(sandwiches);
        //var queue = new LinkedList<int>(students);
        //var aa = 0;

        //while (stack.Count != aa)
        //{
        //    if (stack.First.Value == queue.First.Value)
        //    {
        //        stack.RemoveFirst();
        //        queue.RemoveFirst();
        //        aa = 0;
        //    }
        //    else
        //    {
        //        queue.AddLast(queue.First.Value);
        //        queue.RemoveFirst();
        //        aa++;
        //    }
        //}

        //return queue.Count;
    }
}
