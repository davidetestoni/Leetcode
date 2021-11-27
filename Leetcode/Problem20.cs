namespace Leetcode;

public static class Problem20
{
    public static bool ValidateParenthesis(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                var peeked = stack.Peek();

                if (peeked == '(')
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else if (c == ']')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                var peeked = stack.Peek();

                if (peeked == '[')
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else if (c == '}')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                var peeked = stack.Peek();

                if (peeked == '{')
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
