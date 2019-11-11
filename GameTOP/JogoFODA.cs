using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        public readonly iJogador _jogadorA;
        public readonly iJogador _jogadorB;

        public JogoFODA(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }

        public void IniciarJogo()
        {
            Console.WriteLine(_jogadorA.Correr());
            Console.WriteLine(_jogadorA.Passar());
            Console.WriteLine(_jogadorA.Chutar());

            Console.WriteLine("Próximo jogador...");

            Console.WriteLine(_jogadorB.Correr());
            Console.WriteLine(_jogadorB.Passar());
            Console.WriteLine(_jogadorB.Chutar());
        }
    }
}