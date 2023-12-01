public class Solution {
    public int[] solution(long n) {
       
        int count = 0;
        int index = 0;
        long temp = n;
        while(temp > 0)
        {
            temp /= 10;
            count++;
        }
        
        int[] answer = new int[count];    
        
        while(n>0)
        {
            answer[index] = (int)(n % 10);         
            n /= 10;
            
            index++;
        }
        return answer;
    }
}