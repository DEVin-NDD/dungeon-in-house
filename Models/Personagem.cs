namespace JogoInHouse.Models;

abstract class Personagem : IAcao
{
  public double PontosVida;
  public double PontosAtaque;
  public double PontosDefesa;
  public string? Nome;
  public string? Classe;
  public int Nivel;

  public void Atacar(Personagem alvo)
  {
    alvo.Defender(PontosAtaque);
  }

  public void Defender(double pontosAtaque)
  {
    double dano = pontosAtaque > PontosDefesa ? pontosAtaque - PontosDefesa : 0;
    PontosVida -= dano;
  }
}