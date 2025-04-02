using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int num, int k) {        
        int count = 1;
            List<int> list = new List<int>();
            while (num != 0)
            {
                list.Add(num%10);
                num /= 10;
            }
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] == k)
                {
                    return count;
                }
                count++;
            }

            return -1;
    }
}