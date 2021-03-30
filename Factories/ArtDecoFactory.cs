using DesignPatterns_AbstractFactory.Produtos;
using DesignPatterns_AbstractFactory.Produtos.ArtDeco;

namespace DesignPatterns_AbstractFactory.Factories
{
    public class ArtDecoFactory : LojaMobiliaAbstractFactory
    {
        public override Cadeira CriarCadeiras()
        {
            return new CadeiraArtDeco();
        }

        public override Mesa CriarMesas()
        {
            return new MesaArtDeco();
        }

        public override Sofa CriarSofas()
        {
             return new SofaArtDeco();
        }
        
    }
}