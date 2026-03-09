using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Produto
{
    [JsonProperty(Order = 1)]
    public int Id { get; set; }

    [JsonProperty("product_name", Order = 2, Required = Required.Always)]
    public string Nome { get; set; }

    [JsonProperty("product_price", Order = 3, Required = Required.Always)]
    public double Preco { get; set; }

    [JsonProperty(Order = 4)]
    public int Estoque { get; set; }

    [JsonProperty(Order = 5, NullValueHandling = NullValueHandling.Ignore)]
    public string Fornecedor { get; set; }

    [JsonIgnore]
    public string CodigoInterno { get; set; }
}


class Program
{
    static void Main(string[] args)
    {
        string caminhoArquivo = "produtos.json";

        List<Produto> produtos = new List<Produto>
        {
            new Produto
            {
                Id = 1,
                Nome = "Notebook",
                Preco = 3500,
                Estoque = 10,
                Fornecedor = "Dell",
                CodigoInterno = "NB001"
            },
            new Produto
            {
                Id = 2,
                Nome = "Mouse",
                Preco = 80,
                Estoque = 25,
                Fornecedor = null,
                CodigoInterno = "MS002"
            },
            new Produto
            {
                Id = 3,
                Nome = "Teclado",
                Preco = 150,
                Estoque = 50,
                Fornecedor = "Logitech",
                CodigoInterno = "TC003"
            }
        };

        string json = JsonConvert.SerializeObject(produtos, Formatting.Indented);

        File.WriteAllText(caminhoArquivo, json);

        Console.WriteLine("JSON gravado com sucesso em produtos.json");
        Console.WriteLine();
        Console.WriteLine("Conteúdo do JSON:");
        Console.WriteLine(json);
        Console.WriteLine();

        string jsonLido = File.ReadAllText(caminhoArquivo);

        List<Produto> produtosLidos = JsonConvert.DeserializeObject<List<Produto>>(jsonLido);

        Console.WriteLine("Produtos desserializados:");
        Console.WriteLine();

        foreach (Produto produto in produtosLidos)
        {
            Console.WriteLine($"Id: {produto.Id}");
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Preço: {produto.Preco}");
            Console.WriteLine($"Estoque: {produto.Estoque}");
            Console.WriteLine($"Fornecedor: {produto.Fornecedor}");
            Console.WriteLine();
        }
    }
}