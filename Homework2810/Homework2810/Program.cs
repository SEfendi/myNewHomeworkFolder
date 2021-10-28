using System;

namespace Homework2810
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student("Sarkhan", "Afandizada");
            student.Mark = 11;
            Console.WriteLine($"Sarkhan's mark is { student.Mark}");
            Console.WriteLine(student.ToString());

            string[] menimArrayim = { "Sdsfasda3","Sdsfs", "Saaaas", "Sfasdasffgaagasdgasdfs1", "Sfs", "Sfasdasffgaagasdgasdfs2", "Sfasdasffgaagasdgasdfs3", "Sdsfasda1", "Sdsfasda2", "Sfasdasffgaagasdgasdfs9", };

            Console.WriteLine(Helper.ReturnLongestWord(menimArrayim));
        }
    }
}
