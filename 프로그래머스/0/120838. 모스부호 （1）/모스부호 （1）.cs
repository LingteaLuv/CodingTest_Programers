using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string letter) {
        string answer = "";
        Dictionary<string, char> morse = new Dictionary<string, char>();
        morse.Add(".-", 'a');
        morse.Add("-...", 'b');
        morse.Add("-.-.", 'c');
        morse.Add("-..", 'd');
        morse.Add(".", 'e');
        morse.Add("..-.", 'f');
        morse.Add("--.", 'g');
        morse.Add("....", 'h');
        morse.Add("..", 'i');
        morse.Add(".---", 'j');
        morse.Add("-.-", 'k');
        morse.Add(".-..", 'l');
        morse.Add("--", 'm');
        morse.Add("-.", 'n');
        morse.Add("---", 'o');
        morse.Add(".--.", 'p');
        morse.Add("--.-", 'q');
        morse.Add(".-.", 'r');
        morse.Add("...", 's');
        morse.Add("-", 't');
        morse.Add("..-", 'u');
        morse.Add("...-", 'v');
        morse.Add(".--", 'w');
        morse.Add("-..-", 'x');
        morse.Add("-.--", 'y');
        morse.Add("--..", 'z');

        string[] letters = letter.Split(" ");
        for (int i = 0; i < letters.Length; i++)
        {
            answer += morse[letters[i]];
        }
        return answer;
    }
}