using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int[] HeadCount = new int[n];
        int answer = 0;
        int i;
        
        Array.Fill(HeadCount, 1);
        for(i = 0; i < lost.Length; i++)
            HeadCount[lost[i] - 1] -= 1;
        for(i = 0; i < reserve.Length; i++)
            HeadCount[reserve[i] - 1] += 1;
        
        for(i = 0; i < HeadCount.Length -1; i++)
        {
            if(Math.Abs(HeadCount[i] - HeadCount[i+1]) == 2)
            {
                HeadCount[i] = 1;
                HeadCount[i + 1] = 1;
            }
        }
        
        foreach(int num in HeadCount)
        {
            Console.Write(num);
            if(num >= 1)
            {
                answer++;
            }
        }
        
        return answer;
    }
}