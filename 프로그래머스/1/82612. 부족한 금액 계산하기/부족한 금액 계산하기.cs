using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long result = 0;
        long blowup = price;
        
        for(int i = 0; i < count; i ++)
        {
            result += blowup;
            blowup += price;
        }
        
        if (money - result > 0)
        {
            return 0;
        }
        else
        {
            return (money - result) * (-1);
        }
    }
}