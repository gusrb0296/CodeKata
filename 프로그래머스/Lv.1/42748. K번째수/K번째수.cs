using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
                
        for(int i = 0; i<commands.GetLength(0); i++)
        {
            int a = commands[i, 0];
            int b = commands[i, 1];
            int c = commands[i, 2];
            
            int[] newArray = new int[b - a + 1];            
            for(int j = 0; j < newArray.Length; j++)
            {                
                newArray[j] = array[j + a -1];
                
            }
            Array.Sort(newArray);
            answer[i] = newArray[c-1];
        }
        return answer;
    }
}