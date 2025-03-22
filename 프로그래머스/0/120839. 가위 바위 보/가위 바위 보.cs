using System;

public class Solution {
    public string solution(string rsp) {
        char[] chararr = new char[rsp.Length];
for (int i = 0; i < rsp.Length; i++)
{
    switch (rsp[i])
    {
        case '2':
            chararr[i] = '0';
            break;
        case '0':
            chararr[i] = '5';
            break;
        case '5':
            chararr[i] = '2';
            break;
    }
}
string answer = new string(chararr);
        
        return answer;
    }
}