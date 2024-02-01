using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        int sum = 0;
        
        for(int i=0; i<nums.Length-2; i++)
        {
            for(int j=i+1; j<nums.Length-1; j++)
            {
                for(int k=j+1; k<nums.Length; k++)
                {
                    sum = nums[i] + nums[j] + nums[k];
                    
                    if(Check(sum))
                    {
                        answer++;
                    }
                }
            }
        }   

        return answer;
    }
    
    private bool Check(int num)
    {
        for(int i=2; i<num/2; i++)
        {
            if(num%i == 0)
            {
                return false;
            }
        }        
        return true;
    }
}