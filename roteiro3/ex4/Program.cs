using System;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main(string[] args)
    {
        string json = @"{
            'Servidor': 'localhost',
            'Porta': 3306,
            'Usuario': 'admin'
        }";

        JObject config = JObject.Parse(json);

        config["Porta"] = 5432;

        Console.WriteLine("JSON atualizado:");
        Console.WriteLine(config.ToString());
    }
}