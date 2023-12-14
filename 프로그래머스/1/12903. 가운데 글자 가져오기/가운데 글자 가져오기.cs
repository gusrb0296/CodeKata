public class Solution {
    public string solution(string s) {
        string answer = "";
        int howLong = s.Length;
        if(howLong % 2 == 1)
        {
            answer = s.Substring(howLong/2, 1);
        }
        else
            answer = s.Substring(howLong/2-1, 2);
        return answer;
    }
}