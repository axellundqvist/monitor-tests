using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

public class Needle
{


    public static int Count(string needle, Stream haystack)
    {
        StreamReader reader = new StreamReader(haystack);
        string text = reader.ReadToEnd();

        return Regex.Matches(text, needle).Count;
    }




    public static void Main(string[] args)
    {

        string message = "Hello, there!\nHow are you today?\nYes, you over there.";

        using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(message)))

        Console.WriteLine(Needle.Count("there", stream));
        Console.ReadLine();

    }
}
