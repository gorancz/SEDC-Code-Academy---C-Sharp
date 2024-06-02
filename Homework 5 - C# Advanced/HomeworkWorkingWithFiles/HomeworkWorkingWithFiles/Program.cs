namespace HomeworkWorkingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string newFolderPath = Directory.GetCurrentDirectory() + "\\Files";

            if (Directory.Exists(newFolderPath) == false)
            {
                DirectoryInfo directoryInfo = Directory.CreateDirectory(newFolderPath);
            }

            string newFilePath = newFolderPath + "\\names.txt";

            if (File.Exists(newFilePath) == false)
            {
                FileStream newFile = File.Create(newFilePath);
                newFile.Close();
            }

            StreamWriter streamWriter = new StreamWriter(newFilePath);

            using (streamWriter)
            {
                streamWriter.WriteLine("Petar");
                streamWriter.WriteLine("Zarko");
                streamWriter.WriteLine("Stefan");
                streamWriter.WriteLine("Marko");
                streamWriter.WriteLine("Ivan");
            }

            StreamReader streamReader = new StreamReader(newFilePath);

            using (streamReader)
            {
                string line;
                Console.WriteLine("Names in the file:");
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            StreamWriter streamWriterAppend = new StreamWriter(newFilePath, true);

            Console.WriteLine("Please input some names (enter 'x' when you're done):");
            using (streamWriterAppend)
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input.ToLower() == "x")
                    {
                        break;
                    }
                    streamWriterAppend.WriteLine(input);
                }
            }

            for (char i = 'A'; i <= 'Z'; i++)
            {
                List<string> namesStartingWithLetter = new List<string>();

                using (StreamReader reader = new StreamReader(newFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.StartsWith(i.ToString()))
                        {
                            namesStartingWithLetter.Add(line);
                        }
                    }
                }

                if (namesStartingWithLetter.Count > 0)
                {
                    string newFileLetterPath = newFolderPath + "\\namesStartingWith_" + i + ".txt";

                    if (File.Exists(newFileLetterPath))
                    {
                        using (StreamReader reader = new StreamReader(newFileLetterPath))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (namesStartingWithLetter.Contains(line) == false)
                                {
                                    namesStartingWithLetter.Add(line);
                                }
                            }
                        }
                    }

                    using (StreamWriter writer = new StreamWriter(newFileLetterPath))
                    {
                        foreach (string name in namesStartingWithLetter)
                        {
                            writer.WriteLine(name);
                        }
                    }
                }
            }

            Console.WriteLine("Names saved and filtered successfully!");
        }
    }
}
