using System;

namespace App
{
    public class BaseKeyword : ParentClass
    {
        public BaseKeyword() :  base()
        {
            Console.WriteLine("Calling BaseKeyword constructor.");
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Extra stuff from BaseKeyword override...");
        }
    }

    public class ParentClass
    {
        private string name = "Tyler Durden";
        private string Company = "Paper Street Soap Company";

        public ParentClass()
        {
            Console.WriteLine("Calling ParentClass constructor.");
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {this.name}, Company: {this.Company}.");
        }
    }
}
