using System;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        
        int[] x = new int[10];
        int[] y = new int[10];

        for (int i = 0; i < X.Length; i++)
        {
            x[int.Parse(X[i].ToString())]++;
        }
        for (int i = 0; i < Y.Length; i++)
        {
            y[int.Parse(Y[i].ToString())]++;
        }
        
        for (int i = 9; i >= 0; i--)
        {
            if (x[i] == 0 || y[i] == 0)
                continue;

            int min = Math.Min(x[i], y[i]);

            answer += string.Concat(Enumerable.Repeat(i, min));
        }

        if (answer.Length == 0)
            answer = "-1";
        else if (answer[0] == '0')
            answer = "0";

        return answer;
    }
}