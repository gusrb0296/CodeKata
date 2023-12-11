public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        
        int NumIndex = phone_number.Length-4;        
        
        for (int i = 0; i < NumIndex; i ++)
        {
            answer += "*";
        }
        
        phone_number = phone_number.Remove(0, NumIndex);
            
        answer = answer + phone_number;
        
        return answer;
    }
}