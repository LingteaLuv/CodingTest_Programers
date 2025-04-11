using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] names) 
    {
        List<string> list = new List<string>();
        string[] answer = new string[] {};
        for(int i = 0; i < names.Length; i+=5)
        {
            list.Add(names[i]);
        }
        answer = list.ToArray();
        
        
        return answer;
    }
}