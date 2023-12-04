public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        
        int i, j;
        
        if(a == b)
        {
            return a;
        }
        else if(a > b)
        {
            i = b;
            j = a;
        }
        else
        {
            i = a;
            j = b;
        }
        
        for(i=i; i<=j; i++)
        {
            answer += i;
        }
        
        return answer;
    }
}