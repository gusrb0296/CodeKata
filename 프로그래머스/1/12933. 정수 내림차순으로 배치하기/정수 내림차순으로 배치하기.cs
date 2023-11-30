using System;
using System.Linq;
public class Solution {
    public long solution(long n) {
        
        char[] str = n.ToString().ToArray();

        Array.Sort(str);
        Array.Reverse(str);
        
        string temp;

        temp = string.Join("", str);        
        long answer = long.Parse(temp);
        
        return answer;
    }
}