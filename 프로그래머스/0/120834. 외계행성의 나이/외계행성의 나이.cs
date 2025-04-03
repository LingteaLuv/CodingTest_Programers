using System;
using System.Collections.Generic;

public class Solution 
{
    public string solution(int age) 
    {
        string answer = "";
            int temp = 0;
            int ega = 0;
            Stack<int> stack = new Stack<int>();
            char[] charArr = new char[10]{'a','b','c','d','e','f','g','h','i','j'};
            while(age != 0)
            {
                stack.Push(age%10);
                age/= 10;
            }

            while (stack.Count != 0) 
            {
                answer += charArr[stack.Pop()];
            }
        
            return answer;
    }
}