using System;
using System.Globalization;

namespace App
{
    public static class InterpolatedStrings
    {
        public static void Usage()
        {
            // Composite format string with with format items
            decimal price = 95.25m;
            decimal tip = price * 0.1m;
            Console.WriteLine(string.Format("Price: {0,9:C}", price));
            Console.WriteLine(string.Format("Tip:   {0,9:C}", tip));
            Console.WriteLine(string.Format("Total: {0,9:C}", price + tip));

            string project = "Mayhem";
            string rule = "don't ask any questions";
            string result = string.Format("The first rule of Project {0} is {1}.", project, rule);
            Console.WriteLine(result);
            
            // Interpolated string
            Console.WriteLine($"Price: {price,9:C}");
            Console.WriteLine($"Tip:   {tip,9:C}");
            Console.WriteLine($"Total: {price + tip,9:C}");

            Console.WriteLine($"The first rule of Project {project} is {rule}.");

            // Verbatim means in exactly same words as originally used. Meaning when you use a \ in a string you arent trying to line break etc.
            var file = "Test.cs";
            Console.WriteLine($@"c:\users\ash\{file}");
        }

        public static void Localization()
        {
            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach(var culture in cultures)
            {
                Console.WriteLine($"{culture.DisplayName,50} - {culture.Name}");
            }

            var compositeFormatString = "Ash was born on {0:d}";
            var value = new DateTime(1969, 12, 7);
            var nzCulture = CultureInfo.GetCultureInfo("en-NZ");
            var resultOld = string.Format(nzCulture, compositeFormatString, value);

            var dateOfBirth = new DateTime(1969, 12, 7);
            FormattableString formattableString = $"Ash was born on {dateOfBirth:d}";
            var resultNew = formattableString.ToString(nzCulture);

            Console.WriteLine(resultOld);
            Console.WriteLine(resultNew);

            // Specifying Invariant culture
            DateTime date = DateTime.UtcNow;
            Console.WriteLine(FormattableString.Invariant($"x={date:yyyy-MM-dd}"));

            // Non-variant culture
            FormattableString fs = $"The current date and time is: {date:yyyy-MM-dd}";
            Console.WriteLine(fs.ToString(CultureInfo.GetCultureInfo("en-NZ")));
        }
    }
}
