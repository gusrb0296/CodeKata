public class Solution {
    public int solution(string s) {
        int answer = 0;
        string a = "";
        
        foreach (var item in s.ToCharArray())
        {
            a = a + item;
        }
        answer = int.Parse(a);
        return answer;
    }
}