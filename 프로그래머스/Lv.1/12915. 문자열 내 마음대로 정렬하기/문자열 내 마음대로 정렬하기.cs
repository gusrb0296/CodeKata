using System;
public class Solution {
    public string[] solution(string[] strings, int n) {
        int length = strings.Length;
        
        string[] answer = new string[length];        
        
        for(int i = 0; i<length; i++)
        {
            answer[i] = (strings[i][n]) + strings[i];
        }
        
        Array.Sort(answer);
        
        for(int i = 0; i<length; i++)
        {
            answer[i] = answer[i].Substring(1);
        }
        return answer;
    }
}