using System;

public class Solution {
    public string solution(string cipher, int code) 
    {
        string answer = "";
        char[] charArray = new char[cipher.Length];
        charArray = cipher.ToCharArray();
        for(int i = code-1; i<charArray.Length; i+=code)
        {
            answer += charArray[i];
        }             
        return answer;
    }
}