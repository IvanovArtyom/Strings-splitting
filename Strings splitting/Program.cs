using System;
using System.Text;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        PrintSplitString("Hello world!", ' ');
        PrintSplitString("uf;dg;iu sao;bh ;;isahbdi;bio;;ab isb;oia;sdi;obais;io", ';');
        PrintSplitString("РАЗРАБОТКА ПРОГРАММНОГО ОБЕСПЕЧЕНИЯ И АВТОМАТИЗАЦИЯ БИЗНЕС-ПРОЦЕССОВ", ',');
        PrintSplitString("", 'o');
        PrintSplitString(null, 'n');
        PrintSplitString("null", 'n');
    }

    public static string[]? SplitString(string? str, char separator)
    {
        if (str == null)
            return null;

        string s = str + separator;
        List<string> result = new();
        StringBuilder part = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == separator)
            {
                result.Add(part.ToString());
                part.Clear();
                continue;
            }

            part.Append(s[i]);
        }

        return result.ToArray();
    }

    public static void PrintArray(string[]? strings)
    {
        if (strings == null)
        {
            Console.WriteLine("null");
            return;
        }

        for (int i = 0; i < strings.Length; i++)
            Console.WriteLine($"\"{strings[i]}\"");
    }

    public static void PrintSplitString(string? str, char separator)
    {
        if (str == null)
            Console.WriteLine($"SplitString({"null"}, \'{separator}\')");

        else Console.WriteLine($"SplitString(\"{str}\", \'{separator}\')");

        Console.WriteLine("Результат:");
        PrintArray(SplitString(str, separator));
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
    }
}