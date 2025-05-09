using System;

public class Solution {
    public int[] solution(int[,] score) {
        int[] answer = new int[score.GetLength(0)];
        for(int i = 0; i < score.GetLength(0); i++)
        {
            answer[i] = 1;
        }
        
        for(int i = 0; i < score.GetLength(0); i++)
        {
            int sum = score[i,0] + score[i,1];
            for (int j = 0; j < score.GetLength(0); j++)
            {
                if(sum < score[j,0] + score[j,1])
                {
                    answer[i]++;
                }                                 
            }         
        }        
        return answer;
    }
}