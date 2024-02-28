namespace Problem04.BalancedParentheses
{
    using System;
    using System.Collections.Generic;

    public class BalancedParenthesesSolve : ISolvable
    {
        public bool AreBalanced(string parentheses)
        {
            //My solution
            Queue<char> roundBracketsQueue = new Queue<char>();
            Queue<char> curlyBracketsQueue = new Queue<char>();
            Queue<char> squareBracketsQueue = new Queue<char>();
            if (string.IsNullOrEmpty(parentheses) || parentheses.Length % 2 != 0)
            {
                return false;
            }

            for (int i = 0; i < parentheses.Length; i++)
            {
                switch (parentheses[i])
                {
                    case '(':
                        roundBracketsQueue.Enqueue('(');
                        break;
                    case '{':
                        curlyBracketsQueue.Enqueue('(');
                        break;
                    case '[':
                        squareBracketsQueue.Enqueue('(');
                        break;
                    case ')':
                        try
                        {
                            roundBracketsQueue.Dequeue();
                        }
                        catch (Exception)
                        {
                            //throw;
                        }
                        break;
                    case '}':
                        try
                        {
                            curlyBracketsQueue.Dequeue();
                        }
                        catch (Exception)
                        {
                            //throw;
                        }
                        break;
                    case ']':
                        try
                        {
                            squareBracketsQueue.Dequeue();
                        }
                        catch (Exception)
                        {
                            //throw;
                        }
                        break;
                    default:
                        break;
                }
            }

            if (roundBracketsQueue.Count == 0 && curlyBracketsQueue.Count == 0 && squareBracketsQueue.Count == 0)
            {
                return true;
            }
            return false;

            //Kiro solution - 1
            //if (string.IsNullOrEmpty(parentheses)
            //    || parentheses.Length % 2 == 1)
            //{
            //    return false;
            //}

            //Stack<char> openBrackets = new Stack<char>();
            //foreach (char bracket in parentheses)
            //{
            //    char expectedBracket = default;

            //    switch (bracket)
            //    {
            //        case ')':
            //            expectedBracket = '(';
            //            break;
            //        case ']':
            //            expectedBracket = '[';
            //            break;
            //        case '}':
            //            expectedBracket = '{';
            //            break;
            //        default:
            //            openBrackets.Push(bracket);
            //            break;
            //    }

            //    if (expectedBracket == default
            //        && openBrackets.Pop() != expectedBracket)
            //    {
            //        return false;
            //    }
            //}
            //return openBrackets.Count == 0;

            //Kiro solution - 2
            //It is just string manipulations
        }
    }
}
