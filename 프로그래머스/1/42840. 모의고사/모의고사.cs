using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public List<int> solution(int[] answers) {
        List<int> answer = new List<int>();
        int[] case1 = new int[5] {1, 2, 3, 4, 5};
        int[] case2 = new int[8] {2, 1, 2, 3, 2, 4, 2, 5};
        int[] case3 = new int[10] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        int[] board = new int[3] {0, 0, 0};
        int max = 0;
        
        for(int i = 0; i < answers.Length; i++)
        {
            if(answers[i] == case1[i%case1.Length])
            {  
                board[0]++;
            }
            
            if(answers[i] == case2[i%case2.Length])
            {  
                board[1]++;
            }
            
            if(answers[i] == case3[i%case3.Length])
            {  
                board[2]++;
            }
        }
        
        max = board.Max();
        
        for(int i = 0; i < 3; i++) 
        { 
            if(max == board[i]) 
            { 
                answer.Add(i+1); 
            } 
        }
        
        return answer;
    }
}