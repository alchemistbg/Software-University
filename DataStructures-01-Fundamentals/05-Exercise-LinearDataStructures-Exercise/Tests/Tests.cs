namespace Tests
{
    using Problem04.BalancedParentheses;
    class Tests
    {
        static void Main(string[] args)
        {
            BalancedParenthesesSolve tester = new BalancedParenthesesSolve();
            System.Console.WriteLine(tester.AreBalanced("()[{[{{[{}{}}{}}{}}{}}{{}())()))()))(]}}]}]")); ;
        }
    }
}
