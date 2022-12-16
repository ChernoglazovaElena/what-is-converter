using System.Reflection.Metadata;

namespace что_такое_конвертер
{
    internal class Program
    {
        public static string FilePath;
        static void Main(string[] args)
        {
            Class1.Init();
            Console.ForegroundColor = ConsoleColor.Red;
            while (true)
            {
                Console.WriteLine("нажмите F1 для записи, F3 для открытия");
                ConsoleKey consoleKey = Console.ReadKey().Key;
                switch (consoleKey)
                {
                    case ConsoleKey.F1:
                        Console.WriteLine("В какой фомат сохранить? 1 txt. 2 json. 3 xml. Ескейп для выхода");
                        ConsoleKey consoleKey1 = Console.ReadKey().Key;
                        switch (consoleKey1)
                        {
                            case ConsoleKey.D1:
                                convert.InTXT(convert.class1s);
                                Console.WriteLine("Готово в TXT");
                                break;
                            case ConsoleKey.D2:
                                convert.InJson();
                                Console.WriteLine("Готово в JSON");
                                break;
                            case ConsoleKey.D3:
                                convert.InXML();
                                Console.WriteLine("Готово в XML");

                                break;
                            case ConsoleKey.Escape:
                                Environment.Exit(0);
                                break;
                        }
                        break;
                    case ConsoleKey.F3:
                        Console.WriteLine("Введи тепуть до файла:");
                        FilePath = Console.ReadLine();
                        if (File.Exists(FilePath))
                        {
                            if (FilePath.Contains(".txt"))
                            {
                                var arr = convert.FromTXT();
                                foreach (var item in arr)
                                {
                                    Console.WriteLine($"{item.option}\n{item.dlina}\n{item.dlina2}");
                                }
                            }
                            if (FilePath.Contains(".json"))
                            {
                                var arr = convert.FromJson();
                                foreach (var item in arr)
                                {
                                    Console.WriteLine($"{item.option}\n{item.dlina}\n{item.dlina2}");
                                }
                            }
                            if (FilePath.Contains(".xml"))
                            {
                                var arr = convert.FromXML();
                                convert.class1s = convert.FromXML();
                                foreach (var item in arr)
                                {
                                    Console.WriteLine($"{item.option}\n{item.dlina}\n{item.dlina2}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Файл не существует! Попробуй снова! ");
                        }
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;

                }
            }
        }
    }
}