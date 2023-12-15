public class Solution {
    public string solution(int n) {
        string code = "수박";
        string answer = "";
        
        for (int i = 0; i < n/2; i ++)
        {
            answer += code;
        }
        
        if(n % 2 == 1)
        {
            answer += "수";
        }
        
        return answer;
    }
}