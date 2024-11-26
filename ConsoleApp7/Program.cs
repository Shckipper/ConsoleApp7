using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp7
{
    class DateTimeParsing
    {
        static void Main()
        {
            Console.WriteLine("Введите строку для метода Parse (например, 26-11-2024):");
            string parseString = Console.ReadLine();

            Console.WriteLine("Введите строку для метода ParseExact (например, 26-11-2024):");
            string parseExactString = Console.ReadLine();

            Console.WriteLine("Введите строку для метода TryParse (например, некорректная строка или 2024-11-26):");
            string tryParseString = Console.ReadLine();

            Console.WriteLine("Введите строку для метода TryParseExact (например, 14:30):");
            string tryParseExactString = Console.ReadLine();

            // 1. Метод Parse
            try
            {
                DateTime parsedDate = DateTime.Parse(parseString);
                Console.WriteLine($"Parse: Строка '{parseString}' преобразована в дату: {parsedDate}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Parse: Не удалось преобразовать строку '{parseString}'");
            }

            // 2. Метод ParseExact
            try
            {
                DateTime parsedExactDate = DateTime.ParseExact(parseExactString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine($"ParseExact: Строка '{parseExactString}' преобразована в дату: {parsedExactDate}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"ParseExact: Не удалось преобразовать строку '{parseExactString}'");
            }

            // 3. Метод TryParse
            if (DateTime.TryParse(tryParseString, out DateTime tryParsedDate))
            {
                Console.WriteLine($"TryParse: Строка '{tryParseString}' преобразована в дату: {tryParsedDate}");
            }
            else
            {
                Console.WriteLine($"TryParse: Не удалось преобразовать строку '{tryParseString}'");
            }

            // 4. Метод TryParseExact
            if (DateTime.TryParseExact(tryParseExactString, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime tryParsedExactTime))
            {
                Console.WriteLine($"TryParseExact: Строка '{tryParseExactString}' преобразована в дату/время: {tryParsedExactTime}");
            }
            else
            {
                Console.WriteLine($"TryParseExact: Не удалось преобразовать строку '{tryParseExactString}'");
            }
            Console.ReadKey();
        }
    }
}
