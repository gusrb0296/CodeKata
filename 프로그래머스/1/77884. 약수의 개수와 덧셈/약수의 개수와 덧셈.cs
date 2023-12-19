using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        int count = 0;
        
        for(left = left; left <= right; left++)
        {
            for(int i = 1; i < left; i++)
            {
                if(left % i == 0)
                {
                    count++;
                }
            }
            answer = count % 2 == 0 ? answer - left : answer + left;
            count = 0;
        }
        return answer;
    }
}