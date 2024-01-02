public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] arr = s.Split(' ');

        for (int i = 0; i < arr.Length; i++)
        {
            char[] c = arr[i].ToCharArray();

            for (int j = 0; j < arr[i].Length; j++)
            {
                if (j % 2 == 0)
                {
                    c[j] = char.ToUpper(c[j]);
                    answer += c[j];
                }
                else
                {
                    c[j] = char.ToLower(c[j]);
                    answer += c[j];
                }
                arr[i] = string.Join("", c);
            }
        }        
        answer = string.Join(" ", arr);
        
        return answer;
    }
}