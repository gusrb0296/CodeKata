using System;
using System.Linq;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 0;
        
        for(int i = 0; i < signs.Length; i++)
        {
            if( signs[i] == false)
            {
                absolutes[i] *= -1;
            }
        }
        
        answer = absolutes.Sum();
        
        return answer;
    }
}