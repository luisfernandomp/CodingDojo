using System;

namespace projetoExtensao
{
    public class Jogador
    {
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nacionalidade { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
        public int Idade{ get; set; }
        
        public int CalcularIdade(){
            int AnoAtual = Int32.Parse( DateTime.Now.ToString().Split("/")[2].Split(" ")[0] );
            int AnoNascimento = Int32.Parse( DataNascimento.ToString().Split("/")[2].Split(" ")[0] );
            Idade = AnoAtual-AnoNascimento;
            return Idade; 
        }
        public string VerificarAposentadoria(){ 
            string msg = "";
            if(Idade >= 35 && Posicao == "Atacante"){
                msg = "O jogador pode se aposentar";
            }else if(Idade >= 38 && Posicao == "Meio Campo"){
                msg = "O jogador pode se aposentar";
            }else if(Idade >= 40 && Posicao == "Defesa"){
                    msg = "O jogador pode se aposentar";
            }
            return msg;
        }
        public void MostrarDados(){
            System.Console.WriteLine($"Nome: {Nome}, Posição: {Posicao}, Nascimento: {DataNascimento}");
        }
    }
}