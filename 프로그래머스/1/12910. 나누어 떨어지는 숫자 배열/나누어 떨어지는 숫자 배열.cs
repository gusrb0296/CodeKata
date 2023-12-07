using System;
using System.Collections.Generic;
public class Solution {
    public List<int> solution(int[] arr, int divisor) {
        int index;
        int isfound=0;
        
        List<int> answer = new List<int> {};
        
        for (index = 0; index < arr.Length; index ++)
        {
            int x = arr[index] % divisor;
            if(x == 0)
            {
                answer.Add(arr[index]);
                isfound++;
            }
        }
        if(isfound == 0)
            answer.Add(-1);
        
        answer.Sort();
        
        return answer;
    }
}