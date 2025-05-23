using System;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        int minX = dots[0,0];
        int minY = dots[0,1];
        int maxX = dots[0,0];
        int maxY = dots[0,1];
        
        for(int i = 0; i < 4; i++)
        {
                if(minX > dots[i,0])
                {
                    minX = dots[i,0];                      
                }
                else if(minX < dots[i,0])
                {
                    maxX = dots[i,0];
                }
                if(minY > dots[i,1])
                {
                    minY = dots[i,1];
                }
                else if(minY < dots[i,1])
                {
                    maxY = dots[i,1];
                }
            
        }
        answer = (maxY - minY) * (maxX - minX);
        return answer;
    }
}