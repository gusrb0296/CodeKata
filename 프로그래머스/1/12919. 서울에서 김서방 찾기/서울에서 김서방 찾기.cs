public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        
        int i;
        for(i = 0; i < seoul.Length; i++)
        {
            if(seoul[i] == "Kim")
                break;
        }
        
        answer = $"김서방은 {i}에 있다";
        
        return answer;
    }
}