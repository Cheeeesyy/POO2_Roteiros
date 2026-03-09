using System;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        XDocument doc = XDocument.Load("alunos.xml");

        foreach (var aluno in doc.Descendants("aluno"))
        {
            string nome = aluno.Element("nome")?.Value ?? "";
            string curso = aluno.Element("curso")?.Value ?? "";
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Curso: {curso}");
            Console.WriteLine();
        }
    }
}