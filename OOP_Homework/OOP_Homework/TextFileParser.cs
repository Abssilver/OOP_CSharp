using System;
using System.IO;

namespace OOP_Homework
{
    internal class TextFileParser
    {
        private string _path;
        private char _dataSeparator;
        private const char EmailAtSymbol = '@';

        public string Path
        {
            get => _path;
            set => _path = value;
        }
        
        public char DataSeparator
        {
            get => _dataSeparator;
            set => _dataSeparator = value;
        }

        public TextFileParser(string filePath, char dataSeparator)
        {
            Path = filePath;
            DataSeparator = dataSeparator;
        }

        public void CreateEmailList(string fileNameToSave)
        {
            if (string.IsNullOrEmpty(fileNameToSave))
                return;
            
            if (File.Exists(Path))
            {
                string line = null;
                using (StreamReader reader = 
                       new StreamReader(File.Open(Path, FileMode.Open, FileAccess.Read)))
                {
                    var path = System.IO.Path.Combine(Directory.GetCurrentDirectory(), fileNameToSave);
                    using (StreamWriter writer = 
                           new StreamWriter(File.Open(path, FileMode.Create, FileAccess.Write)))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            SearchMail(ref line);
                            if (!string.IsNullOrEmpty(line) && line.Contains(EmailAtSymbol))
                            {                            
                                writer.WriteLine(line);
                                Console.WriteLine($"Writing: {line}");
                            }
                            else
                                Console.WriteLine("Warning. Data is invalid! Trying next line");
                        }
                    }
                    Console.WriteLine($"File created at: {path}");
                }
            }
            else
            {
                Console.WriteLine($"Invalid path: {Path}");
            }
        }

        private void SearchMail(ref string line, StringSplitOptions splitOptions = StringSplitOptions.TrimEntries)
        {
            var splitData = line.Split(DataSeparator, splitOptions);
            line = splitData.Length > 1 ? splitData[1] : null;
        }
    }
}