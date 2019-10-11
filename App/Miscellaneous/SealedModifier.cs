using System;

namespace App
{
    /*  
        The sealed modifier prevents other classes from inheritting from it. It can also be used to prevent a class 
        from overriding specific virtual/abstract methods or properties that have already been overridden.

        Below you can see this class inherits from Y but no class can inherit SealedModifier.
        In the SealedModifier class we are unable to override the sealed property Id and sealed method MethodOne.
    */
    public sealed class SealedModifier : Y
    {
        public override void MethodTwo() {
            Console.WriteLine("Changed by class SealedModifier");
        }
    }

    public abstract class X
    {
        public virtual int Id { get; set; }
        public virtual void MethodOne() => Console.WriteLine();
        public abstract void MethodTwo();
    }

    public class Y : X
    {
        public override sealed int Id 
        { 
            get => 5;
        }
        
        public sealed override void MethodOne() {
            Console.WriteLine("Changed by class Y.");
        } 

        public override void MethodTwo() {
            Console.WriteLine("Changed by class Y");
        }
    }
}
