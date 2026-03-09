using System;
using System.IO;
using Newtonsoft.Json;

class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Curso { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        string caminhoArquivo = "aluno.json";

        string json = File.ReadAllText(caminhoArquivo);

        Aluno aluno = JsonConvert.DeserializeObject<Aluno>(json);

        Console.WriteLine("Dados do aluno:");
        Console.WriteLine($"Nome: {aluno.Nome}");
        Console.WriteLine($"Idade: {aluno.Idade}");
        Console.WriteLine($"Curso: {aluno.Curso}");
    }
}