using System;
using System.IO;

namespace semana2_aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo("Arquivo.csv");
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            string idade = Console.ReadLine();     
            StreamWriter sw = new StreamWriter("Arquivo.csv",true);
            sw.WriteLine(nome + ";" + idade);
            sw.Close();            
        }
    }
}
