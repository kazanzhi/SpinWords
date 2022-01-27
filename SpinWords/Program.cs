using System;
using System.Linq;

namespace SpinWords
{
    class Program
    {
        public static string SpinWordsBetter(string incoming) =>
            string.Join(" ",
                incoming.Split(new char[] { ' ' })
                .Select(s => s.Length >= 5 ? string.Join("", s.Reverse()) : s));

        static void Main(string[] args)
        {
            var w = SpinWordsBetter("emocleW");
            var m = SpinWordsBetter("olleH yadnoM");
            var t = SpinWordsBetter("This is a test");
            var y = SpinWordsBetter("You are tsomla to the last test");
            var j = SpinWordsBetter("Just gniddik ereht is llits one more");
            Console.WriteLine(w);
            Console.WriteLine(m);
            Console.WriteLine(t);
            Console.WriteLine(y);
            Console.WriteLine(j);
        }
    }
}

