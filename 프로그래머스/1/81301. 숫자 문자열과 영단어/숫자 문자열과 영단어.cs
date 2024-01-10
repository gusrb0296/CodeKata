using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Solution {
    public int solution(string s) {
        Dictionary<string, string> dicNum= new Dictionary<string, string>{
            {"one", "1"},
            {"two", "2"},
            {"three", "3"},
            {"four", "4"},
            {"five", "5"},
            {"six", "6"},
            {"seven", "7"},
            {"eight", "8"},
            {"nine", "9"},
            {"zero", "0"}
        };
        
        string str = s;
        //foreach(var replaceAnswer in dicNum){ var 사용 가능
        foreach(KeyValuePair<string, string> replaceAnswer in dicNum){
            str = Regex.Replace(str, replaceAnswer.Key, replaceAnswer.Value);
        }
        int answer = int.Parse(str);
        return answer;
    }
}