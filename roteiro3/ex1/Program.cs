using System;
using Newtonsoft.Json;

class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Livro livro = new Livro
        {
            Titulo = "Game of Thrones",
            Autor = "George R.R. Martin",
            Ano = 1996
        };

        string json = JsonConvert.SerializeObject(livro);

        Console.WriteLine("Objeto convertido para JSON:");
        Console.WriteLine(json);
    }
}