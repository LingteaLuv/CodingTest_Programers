using System;

public class Solution {
    public int[] solution(string my_string) 
    {
        int[] answer = new int[my_string.Length];
        int int_string;
        for(int i =0; i< my_string.Length; i++)
        {
            if (int.TryParse(my_string[i].ToString(), out int_string))
            {
                answer[i] = int_string;
            }
            else
            {
                answer[i] = -1;
            }
        }
        int[] intArr = Array.FindAll(answer, num => num != -1);

        Array.Sort(intArr);
        
        return intArr;
    }
}