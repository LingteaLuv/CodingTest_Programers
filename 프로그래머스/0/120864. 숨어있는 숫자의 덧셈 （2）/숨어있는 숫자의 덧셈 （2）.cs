using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        char[] array = my_string.ToCharArray();
        for (int i = 0; i < array.Length; i++)
        {
            if (!int.TryParse(array[i].ToString(), out int num)) array[i] = ' ';
        }

        string str = String.Concat(array);
        string[] array2 = str.Split(' ');
        for (int i = 0; i < array2.Length; i++)
        {
            int.TryParse(array2[i], out int num);
            answer += num;
        }
        return answer;
    }
}