using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string Nome;

        public Jogador1(string nome)
        {
            Nome = nome;
        }

        public string Correr()
        {
            return $"{Nome} está correndo.";
        }
        public string Chutar()
        {
            return $"{Nome} está chutando.";
        }

        public string Passar()
        {
            return $"{Nome} está passando.";
        }
    }
}