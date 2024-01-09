using System;
public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        int temp;
                
        foreach(char c in s)
        {
            if(c!=' ')
            {
                temp = 0;
                if((int)c < 91)
                {
                    
                    temp = (int)c + n;
                    if(temp>90) 
                    {
                        temp = 64 + (temp-90);
                    }
                }
                else
                {
                    temp = (int)c + n;
                    if(temp>122) temp = 96 + (temp-122);                       
                }
                
                answer += Convert.ToChar(temp);
            }
            else
                answer += ' ';
        }
        return answer;
    }
}