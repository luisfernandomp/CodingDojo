using System;

namespace projetoExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador ney = new Jogador();
            ney.Nome = "Menino Ney";
            ney.Peso = 80.9f;
            ney.Posicao = "Atacante";
            ney.Nacionalidade = "Brasileiro";
            ney.DataNascimento = DateTime.Parse("20/10/1999")
            System.Console.WriteLine(ney.CalcularIdade());
            System.Console.WriteLine(ney.VerificarAposentadoria());
            ney.MostrarDados();
        }
    }
}
