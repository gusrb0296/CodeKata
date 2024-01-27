using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int index1 = 0; 
        int index2 = 0;
        
        for(int i = 0; i < goal.Length; i++)
        {
            if(index1 < cards1.Length && cards1[index1] == goal[i])
            {
                index1++;
                continue;
            }
            else if(index2 < cards2.Length && cards2[index2] == goal[i])
            {
                index2++;
                continue;
            }
            else
            {
                return "No";
            }            
        }
        return "Yes";
    }
}