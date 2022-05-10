using jogo.Models;
using System.Collections.Generic;

namespace jogo.Interface
{
    public interface IEquipe
    {
        //Contrato
        //Representa os métodos que são obrigatorios em uma classe

        void Criar(Equipe novaequipe);

        List<Equipe> LerEquipes();


    }
}
