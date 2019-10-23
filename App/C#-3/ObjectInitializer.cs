using System.Collections.Generic;
using System.Text;

namespace App
{
    public static class ObjectInitializer
    {
        public struct Fight {
            public int Id;
            public string MemberOne;
            public string MemberTwo;
            public List<string> Rules;

            public override string ToString()
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($"Id = {Id}\n");
                stringBuilder.Append($"MemberOne = {MemberOne}\n");
                stringBuilder.Append($"Id = {MemberTwo}\n");
                stringBuilder.Append("[");
                foreach(string s in Rules)
                {
                    stringBuilder.Append($"{s}");
                }
                stringBuilder.Append("]\n");
                return stringBuilder.ToString();
            }
        }

        public static void Usage()
        {
            Fight fight = new Fight();
            fight.Id = 1;
            fight.MemberOne = "Big Bob";
            fight.MemberOne = "Angel Face";
            List<string> rules = new List<string>();
            rules.Add("The first rule about...");
            fight.Rules = rules;

            Fight fight2 = new Fight 
            {
                Id = 1,
                MemberOne = "Big Bob",
                MemberTwo = "Angel Face",
                Rules = rules
            };

            Fight fightTwo = new Fight 
            {
                Id = 1,
                MemberOne = "Big Bob",
                MemberTwo = "Angel Face",
                Rules = new List<string> { "The first rule about..." }
            };
        }
    }
}
