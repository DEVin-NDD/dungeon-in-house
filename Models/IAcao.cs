using JogoInHouse.Models;
namespace JogoInHouse.Models;
interface IAcao
{
  void Atacar(Personagem alvo);
  void Defender(double pontosAtaque);
}