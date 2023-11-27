public class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[n];
        
        long y = x;
        int temp = x;
        for (int i = 0; i < n; i++)
        {
            answer[i] = y;
            y += temp;
        }
        return answer;
    }
}