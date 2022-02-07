using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            string str;
            Console.WriteLine($"Введите строку: ");
            str = Console.ReadLine();
            ACoder encoder = new ACoder();
            encoder.Encode(str);
            BCoder encoderb = new BCoder();

            Console.WriteLine($"\nСдвиг на одну позицую        {encoder.Encode(str)}");
            Console.WriteLine($"Декодер                      {encoder.Decode(encoder.Encode(str))}");
            Console.WriteLine($"Зеркальное отражение         {encoderb.Encode(str)}");
            Console.WriteLine($"Декодер                      {encoderb.Decode(encoderb.Encode(str))}");
        }
    }
}
