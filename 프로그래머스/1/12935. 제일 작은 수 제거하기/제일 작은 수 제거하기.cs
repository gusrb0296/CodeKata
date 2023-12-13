using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[1];
        
        if(arr.Length == 1)
        {
            answer[0] = -1;
            return answer;
        }
        
        int[] min = new int[1];
        min[0] = arr.Min();
        
        int[] newArray = arr.Except(min).ToArray();
        
        return newArray;
        
    }
}