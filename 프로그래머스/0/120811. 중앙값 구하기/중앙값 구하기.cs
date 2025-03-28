using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int temp;
        for(int i = 0; i< array.Length; i++)
        {
            for(int j = i; j< array.Length; j++)
            {
                if(array[i]>array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;                  
                }
            }
        }
        
        answer = array[array.Length/2];
        return answer;
    }
}