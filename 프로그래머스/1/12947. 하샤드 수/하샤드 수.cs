public class Solution {
    public bool solution(int x) {
        bool answer = true;
        int hashard = 0;
        int temp = x;
        
        while(temp>0)
        {
            hashard += temp % 10;
            temp /= 10;
        }
        
        if (x % hashard == 0)
             answer = true;
        else
             answer = false;
        
        return answer;
    }
}