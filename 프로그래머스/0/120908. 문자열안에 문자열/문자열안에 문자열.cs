using System;

public class Solution 
{
    public int solution(string str1, string str2) 
    {
    int answer = 2;
        for(int i = 0; i < str1.Length - str2.Length + 1; i++)
        {
            if(str2 == str1.Substring(i, str2.Length))
            {
                answer = 1;
            }
        }
        return answer;
    }
}