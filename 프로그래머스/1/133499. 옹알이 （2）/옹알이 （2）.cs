using System;
using System.Linq;

public class Solution {
    public int solution(string[] babbling) {
        string[] words = new string[4] {"aya", "ye", "woo", "ma"};
        int answer = 0;
        
        for(int i = 0; i < babbling.Length; i++)
        {
            for(int j = 0; j < words.Length; j++)
            {
                string twice = words[j] + words[j];
                
                babbling[i] = babbling[i].Replace(twice, "1");
                babbling[i] = babbling[i].Replace(words[j], " ");                
            }
            
            if(babbling[i].Trim().Length == 0)
            {
                answer++;
            }
        }
        return answer;
    }
}