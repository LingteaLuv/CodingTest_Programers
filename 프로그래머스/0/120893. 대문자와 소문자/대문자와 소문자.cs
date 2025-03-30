using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        string temp = my_string.ToUpper();

        for (int i = 0; i < my_string.Length; i++)
        {
            if (my_string[i] != temp[i])
            {
                answer += temp[i];
            }
            else
            {
                answer += my_string.ToLower()[i];
            }
        }
        return answer;
    }
}