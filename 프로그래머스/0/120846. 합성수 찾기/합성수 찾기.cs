using System;

public class Solution {
    public int solution(int n) {
            int answer = 0;
            for(int j = 3; j <= n; j++)
            {
                for(int i = 2; i < j; i++)
                {
                    if(j % i  == 0)
                    {
                        answer++;
                        break;
                    }
                }
            }                
            return answer;
    }
}