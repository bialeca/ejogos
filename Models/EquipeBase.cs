using System.IO;

namespace jogo.Models
{
    public class EquipeBase
    {
        public void CriarPastaOuArquivo (string caminho)

        {
            //nome da pasta / nomedoarquivo.csv
            string pasta = caminho.Split ('/')[0];

           if(!Directory.Exists (pasta))
            {
            Directory.CreateDirectory(pasta);
            }
           
           if(!File.Exists (caminho))
            {
            File.Create(caminho);
            }
                

        }


    }
}
