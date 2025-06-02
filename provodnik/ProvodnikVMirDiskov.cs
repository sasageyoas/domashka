using System;
using System.IO;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Доступные диски:");
            DriveInfo[] drives = DriveInfo.GetDrives();
            for (int i = 0; i < drives.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {drives[i].Name}");
            }
            Console.Write("Выберите диск (номер) или нажмите 0 для выхода: ");
            string input = Console.ReadLine();
            if (input == "0") break;

            if (int.TryParse(input, out int diskIndex) && diskIndex > 0 && diskIndex <= drives.Length)
            {
                string currentPath = drives[diskIndex - 1].Name;
                RunFileManager(currentPath);
            }
            else
            {
                Console.WriteLine("Неверный выбор, блин((. Нажми Enter.");
                Console.ReadLine();
            }
        }
    }

    static void RunFileManager(string path)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Текущий путь: {path}");
            Console.WriteLine("Каталоги:");
            string[] dirs = Directory.GetDirectories(path);
            for (int i = 0; i < dirs.Length; i++)
            {
                Console.WriteLine($"[D] {i + 1}. {Path.GetFileName(dirs[i])}");
            }

            string[] files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine($"[F] {i + 1 + dirs.Length}. {Path.GetFileName(files[i])}");
            }

            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Перейти в каталог");
            Console.WriteLine("2. Вернуться назад");
            Console.WriteLine("3. Открыть файл");
            Console.WriteLine("4. Создать каталог");
            Console.WriteLine("5. Создать текстовый файл");
            Console.WriteLine("6. Удалить файл/каталог");
            Console.WriteLine("0. Назад к выбору диска");

            Console.Write("\nВыбор: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите номер каталога: ");
                    if (int.TryParse(Console.ReadLine(), out int dirNum) && dirNum >= 1 && dirNum <= dirs.Length)
                    {
                        path = dirs[dirNum - 1];
                    }
                    break;

                case "2":
                    if (Directory.GetParent(path) != null)
                        path = Directory.GetParent(path).FullName;
                    break;

                case "3":
                    Console.Write("Введите номер файла: ");
                    if (int.TryParse(Console.ReadLine(), out int fileNum))
                    {
                        fileNum -= dirs.Length;
                        if (fileNum >= 1 && fileNum <= files.Length)
                        {
                            Console.Clear();
                            string content = File.ReadAllText(files[fileNum - 1]);
                            Console.WriteLine($"Содержимое файла:\n\n{content}");
                            Console.WriteLine("\nНажмите Enter для продолжения...");
                            Console.ReadLine();
                        }
                    }
                    break;

                case "4":
                    Console.Write("Введите имя нового каталога: ");
                    string newDirName = Console.ReadLine();
                    string newDirPath = Path.Combine(path, newDirName);
                    Directory.CreateDirectory(newDirPath);
                    break;

                case "5":
                    Console.Write("Введите имя нового файла: ");
                    string fileName = Console.ReadLine();
                    string filePath = Path.Combine(path, fileName);
                    Console.WriteLine("Введите текст для записи:");
                    string fileContent = Console.ReadLine();
                    File.WriteAllText(filePath, fileContent);
                    break;

                case "6":
                    Console.Write("Введите номер элемента (файл/каталог): ");
                    if (int.TryParse(Console.ReadLine(), out int delNum))
                    {
                        if (delNum >= 1 && delNum <= dirs.Length)
                        {
                            Console.Write("Вы уверены, что хотите удалить каталог? (y/n): ");
                            if (Console.ReadLine().ToLower() == "y")
                                Directory.Delete(dirs[delNum - 1], true);
                        }
                        else if (delNum > dirs.Length && delNum <= dirs.Length + files.Length)
                        {
                            Console.Write("Вы уверены, что хотите удалить файл? (y/n): ");
                            if (Console.ReadLine().ToLower() == "y")
                                File.Delete(files[delNum - dirs.Length - 1]);
                        }
                    }
                    break;

                case "0":
                    return;
            }
        }
    }
}
