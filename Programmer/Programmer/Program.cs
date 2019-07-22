using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmer
{
    public class Programmer
    {
        public List<string> Languages = new List<string>();

        public void AddLanguage(string language)
        {
            Languages.Add(language);
        }

    }

    public class ProgrammerTeacher : Programmer
    {
        public bool Teach(Programmer programmer, string language)
        {
            bool exists = Languages.Any(s => s.Contains(language));
            if (exists)
            {
                programmer.AddLanguage(language);

                return true;
            }
            else
            {
                return false;
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ProgrammerTeacher teacher = new ProgrammerTeacher();
            teacher.AddLanguage("C#");

            Programmer programmer = new Programmer();
            teacher.Teach(programmer, "C#");

            foreach (var language in programmer.Languages)
            Console.WriteLine(language);

            Console.ReadLine();
        }
    }
}
