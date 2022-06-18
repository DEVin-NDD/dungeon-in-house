namespace JogoInHouse.Models;

class Monstro : Personagem
{
  public Monstro(string nome, string classe)
  {
    Nome = nome;
    Classe = classe;

    PontosVida = 300;
    PontosAtaque = 12;
    PontosDefesa = new Random().Next(1, 8);
    Nivel = 1;
  }
}