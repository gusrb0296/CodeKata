using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        List<int> containList = new List<int>();
        
        for(int i = 0; i < numbers.Length-1; i++)
        {
            for(int j = i+1; j < numbers.Length; j++)
            {
                containList.Add(numbers[i] + numbers[j]);
            }
        }
        
        containList.Sort();
        
        int[] answer = new int[containList.Count];
        
        answer = containList.Distinct().ToArray();
        
        return answer;
    }
}