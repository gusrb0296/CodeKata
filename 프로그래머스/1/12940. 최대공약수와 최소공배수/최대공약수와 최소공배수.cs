public class Solution 
{
    public int[] solution(int n, int m) 
    {
        int[] answer = new int[2];
        int big, small;
        int remain;
        
        if(n > m)
        {
            big = n;
            small = m;
        }
        else 
        {
            big = m;
            small = n;
        }
        
        answer[0] = gcd(big, small);
        answer[1] = lcm(big, small);
            
        return answer;
    }
    
    public static int lcm(int a, int b)
    {
        return (a * b) / gcd(a, b);
    }
    
    public static int gcd(int a, int b)
    {
        int r;
        
        while (b != 0)
        {
            r = a % b;
            a = b;
            b = r;
        }
        
        return a;
    }
}