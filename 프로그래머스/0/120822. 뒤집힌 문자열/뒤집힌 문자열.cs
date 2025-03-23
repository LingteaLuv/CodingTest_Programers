using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        char[] charString = new char[my_string.Length];
        for(int i = 0; i < my_string.Length; i++)
        {
            charString[i] = my_string[i];
        }
        Array.Reverse(charString);
        return new string(charString);
    }
}