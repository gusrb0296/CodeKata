using System;
using System.Linq;

public class Solution {
    public bool solution(string s) {
        bool answer = false;
        bool isNumeric = s.All(char.IsDigit);
        if(isNumeric)
        {
            if(s.Length == 4 || s.Length == 6)
                return isNumeric;
        }
        
        return answer;
    }
}