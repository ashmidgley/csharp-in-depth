using System;

namespace App
{
    // The purpose of delegates is to encapsulate a piece of code so that it can be passed around and executed as necessary.
    // NOTE: C# 2 didn't introduce delegate creation. It was just made easier to use them for purposes other 
    // than event handling and starting threads.
    public static class DelegateCreation
    {
        public delegate void MyDelegate(string message);

        public static void Usage()
        {
            // Old usage.
            EventHandler oldHandler = new EventHandler(HandleButtonClick);

            // New usage.
            EventHandler newHandler = HandleButtonClick;

            EventHandler newHandlerTwo = delegate
            {
                Console.WriteLine("Event raised.");
            };

            // Shorthand of MyDelegate del = new MyDelegate(PrintMessage)
            MyDelegate del = PrintMessage;
            del += PrintMessage;
            string message = "Eat my shorts.";
            del.Invoke(message);
        }

        public static void PrintMessage(string message)  
        { 
            Console.WriteLine(message);  
        } 

        private static void HandleButtonClick(object sender, EventArgs e)
        {
            // Pretend I wrote some fancy function.
        }
    }
}
