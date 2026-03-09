using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        string caminhoArquivo = "carros.json";

        List<Carro> carros = new List<Carro>
        {
            new Carro { Marca = "Toyota", Modelo = "Corolla", Ano = 2020 },
            new Carro { Marca = "Honda", Modelo = "Civic", Ano = 2022 },
            new Carro { Marca = "Ford", Modelo = "Ka", Ano = 2019 }
        };

        string json = JsonConvert.SerializeObject(carros, Formatting.Indented);
        File.WriteAllText(caminhoArquivo, json);

        Console.WriteLine("Lista de carros salva no arquivo.");
        Console.WriteLine();

        string jsonLido = File.ReadAllText(caminhoArquivo);
        List<Carro> carrosLidos = JsonConvert.DeserializeObject<List<Carro>>(jsonLido);

        Console.WriteLine("Carros lidos do arquivo:");
        foreach (Carro carro in carrosLidos)
        {
            Console.WriteLine($"Marca: {carro.Marca}");
            Console.WriteLine($"Modelo: {carro.Modelo}");
            Console.WriteLine($"Ano: {carro.Ano}");
            Console.WriteLine();
        }
    }
}