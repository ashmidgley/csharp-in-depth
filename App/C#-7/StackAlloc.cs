using System;

namespace App
{
    public static class StackAlloc
    {
        public static void Usage()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            Console.WriteLine(Generate(alphabet, random, 10));
            Console.WriteLine(SafeGenerate(alphabet, random, 10));
        }

        // Performs 2 heap allocation. One for the string and another for the char array.
        static string Generate(string alphabet, Random random, int length)
        {
            char[] chars = new char[length];
            for(int i = 0; i < length; i++)
            {
                chars[i] = alphabet[random.Next(alphabet.Length)];
            }
            return new string(chars);
        }

        /* 
            Commented out to stop compiler complaining. 
            This performs one heap allocation and the char array is stored on the stack.
            We have to use unsafe keyword because we're playing with pointers.
        *//*
        unsafe static string UnsafeGenerate(string alphabet, Random random, int length)
        {
            char* chars = stackalloc char[length];
            for(int i = 0; i < length; i++)
            {
                chars[i] = alphabet[random.Next(alphabet.Length)];
            }
            return new string(chars);
        }
        */

        // Span<T> allows us to use stackalloc without the unsafe keyword. Hoozaa.
        static string SafeGenerate(string alphabet, Random random, int length)
        {
            Span<char> chars = stackalloc char[length];
            for(int i = 0; i < length; i++)
            {
                chars[i] = alphabet[random.Next(alphabet.Length)];
            }
            return new string(chars);
        }
    }
}
