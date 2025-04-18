using System;

public class Solution 
{
    public int solution(int[] array, int n) 
    {
        Array.Sort(array);
        int answer = 1000;
        int index = array.Length - 1;
        
        for(int i = 0; i < array.Length; i++)
        {
            int m = n - array[i] >= 0 ? n - array[i] : array[i] - n;
            if(answer > m) 
            {
                answer = m;
                index = i;
            }
        }
        answer = array[index];
        return answer;
    }
}