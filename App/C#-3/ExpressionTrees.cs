using System;
using System.Linq.Expressions;

namespace App
{
    // Expression trees are representations of code as data.
    public static class ExpressionTrees
    {
        public static void SimpleExample()
        {
            Expression<Func<int, int, int>> adder = (x, y) => x + y;
            Console.WriteLine(adder);
        }

        public static void CompilingExpressionToDelegate()
        {
            Expression<Func<int, int, int>> adder = (x, y) => x + y;
            Func<int, int, int> executableAdder = adder.Compile();
            Console.WriteLine(executableAdder(5, 3));
        }
    }
}
