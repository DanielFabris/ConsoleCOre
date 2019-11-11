using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chutar()
        {
            return "Messi está chutando.";
        }

        public string Correr()
        {
            return "Messi está correndo.";
        }

        public string Passar()
        {
            return "Messi está passando.";
        }
    }
}