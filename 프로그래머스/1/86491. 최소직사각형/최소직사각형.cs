using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        
        int maxW = 0;
        int maxH = 0;
        int temp;


        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            if (sizes[i, 0] < sizes[i, 1])
            {
                temp = sizes[i, 0];
                sizes[i, 0] = sizes[i, 1];
                sizes[i, 1] = temp;
            }

            if (sizes[i, 0] > maxW)
                maxW = sizes[i, 0 ];

            if (sizes[i, 1] > maxH)
                maxH = sizes[i, 1 ];

        }
        
        answer = maxH * maxW;
        
        return answer;
    }
}