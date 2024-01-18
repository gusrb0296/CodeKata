using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];        
        int Value = -1;
        
        for(int i = 0; i < s.Length; i++)
        {
            Value = -1;
            for(int j = i - 1; j >= 0; j--)
            {
                if(s[i] == s[j])
                {
                    Value = i - j;
                    break;
                }
            }
            answer[i] = Value;
        }
        return answer;
    }
}