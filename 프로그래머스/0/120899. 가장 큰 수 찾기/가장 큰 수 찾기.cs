using System;

public class Solution {
    public int[] solution(int[] array) {
        int[] answer = new int[2];
        int[] arr = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            arr[i] = array[i];
        }
        Array.Sort(array);
        answer[0] = array[array.Length-1];
        answer[1] = Array.IndexOf(arr,answer[0]);

                      
        return answer;
    }
}