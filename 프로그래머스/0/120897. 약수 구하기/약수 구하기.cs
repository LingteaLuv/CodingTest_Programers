using System;

public class Solution {
    public int[] solution(int n) 
    {
        int[] answer = new int[n];
        int j = 0; 
        for(int i = 1; i <= n; i++)
        {
            if(n % i == 0)
            {                
                answer[j] = i;
                j++; 
            }
        }
        int[] answer0 = new int[j];
        for(int i = 0; i< j; i++)
        {
            answer0[i] = answer[i];
        }   
        return answer0;
    }
}