public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        for (long i = 1; i <= n; i ++)
        {
            if (i * i == n)
            {
                answer = i+1;
                answer = (answer * answer);
                break;
            }
            else
                answer = -1;
        }
        
        return answer;
    }
}