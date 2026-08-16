using System.Collections.Generic;
using UnityEngine;

public class IsValidSolution : MonoBehaviour
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0) return false;
                    char top = stack.Peek();
                    if (c == ')' && top != '(')
                        return false;

                    if (c == ']' && top != '[')
                        return false;

                    if (c == '}' && top != '{')
                        return false;

                    stack.Pop();

                }
            }
            return stack.Count == 0;
        }
    }
}
