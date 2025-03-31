using System;

public class Solution {
    public string solution(string my_string) 
    {
        char[] ch = my_string.ToLower().ToCharArray();
        Array.Sort(ch);
        string answer = new string(ch);
        return answer;
    }
}