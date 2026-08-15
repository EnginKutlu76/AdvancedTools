using UnityEngine;

public class ColumnNumber : MonoBehaviour
{
    public class Solution
    {
        public int TitleToNumber(string columnTitle)
        {
            int output = 0;
            foreach (char c in columnTitle)
            {
                output = output * 26 + (c - 'A' + 1);
            }

            return output;
        }
    }
}
