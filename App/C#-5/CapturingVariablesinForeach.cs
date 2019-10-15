using System;
using System.Collections.Generic;

namespace App
{
    public static class CapturingVariablesInForeach
    {
        public static void Usage()
        {
            /*  Prior to C# 5 this would print z 3 times rather than x y z. Rather than the name variable being captured as part of 
                the delegate, it would just use the CURRENT value of the variable name when the delgate is called (z).

                This is because anonymous functions were introduced in C# 2. A variable is captured when it is used in an anonymous 
                function but foreach loops were using a single iteration variable. Now, a new variable is introduced at each 
                iteration of the loop.
            */
            List<string> names = new List<string> { "x", "y", "z" };
            var actions = new List<Action>();
            foreach(string name in names)
            {
                actions.Add(() => Console.WriteLine(name));
            }
            foreach(Action action in actions)
            {
                action();
            }
        }
    }
}
