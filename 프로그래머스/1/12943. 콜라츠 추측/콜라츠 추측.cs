public class Solution {
    public int solution(long num) {
        int answer = 0;
        
        if (num == 1)
            return 0;
        
        while (num != 1)
        {
            num = num % 2 == 0 ? num / 2 : num * 3 + 1;
            answer ++;
        }
        
        if (answer >= 500)
            answer = -1;
            
        return answer;
    }
}