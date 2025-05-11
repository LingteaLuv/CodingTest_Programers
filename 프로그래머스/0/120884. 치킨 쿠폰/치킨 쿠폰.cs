using System;

public class Solution {
    public int solution(int chicken) {
        int answer = 0;
        int coupon = chicken;  
        int service;

        while (coupon >= 10)
        {
                    service = coupon / 10;
                    coupon = service + coupon % 10;
                    answer += service;
        }
        return answer;
    }
}