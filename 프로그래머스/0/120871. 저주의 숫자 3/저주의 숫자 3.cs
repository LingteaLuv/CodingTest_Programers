using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int offset = 0;
        for(int i = 1; i <= n + offset; i++)
        {
            if(i % 3 == 0)
            {
                offset++;
                continue;
            }
            if(i % 10 == 3 || i / 10 == 3)
            {
                offset++;
                continue;
            }
            if(i > 100)
            {
                if((i - 100) / 10 == 3)
                {
                    offset++;
                }
            }
        }     
        answer = n + offset;
        return answer;
    }
}