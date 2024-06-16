using System;
using System.IO;

class Preprocessor
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: Preprocessor <input file> <output file>");
            return;
        }

        string inputFile = args[0];
        string outputFile = args[1];

        string[] lines = File.ReadAllLines(inputFile);
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            foreach (string line in lines)
            {
                string translatedLine = TranslateLine(line);
                writer.WriteLine(translatedLine);
            }
        }
    }

    static string TranslateLine(string line)
    {
        line = line.Replace("banao", "var");
        line = line.Replace("agar", "if");
        line = line.Replace("warna", "else");
        line = line.Replace("likho", "Console.WriteLine");

        return line;
    }
}
