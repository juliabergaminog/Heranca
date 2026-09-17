namespace Heranca
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int PontosDeVida { get; set; }
        public int ForcaDeAtaque { get; set; }

        public Personagem(string nome, int pontosDeVida, int forcaDeAtaque)
        {
            Nome = nome;
            PontosDeVida = pontosDeVida;
            ForcaDeAtaque = forcaDeAtaque;
        }

        public virtual void Atacar(Personagem alvo)
        {
            int dano = ForcaDeAtaque;
            alvo.PontosDeVida = Math.Max(0, alvo.PontosDeVida - dano);
        }

        public bool EstaVivo()
        {
            return PontosDeVida > 0;
        }
    }
}