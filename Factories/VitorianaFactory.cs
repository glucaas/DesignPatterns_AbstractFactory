using DesignPatterns_AbstractFactory.Produtos;
using DesignPatterns_AbstractFactory.Produtos.Vitoriana;

namespace DesignPatterns_AbstractFactory.Factories
{
    public class VitorianaFactory : LojaMobiliaAbstractFactory
    {
        public override Cadeira CriarCadeiras()
        {
            return new CadeiraVitoriana();
        }

        public override Mesa CriarMesas()
        {
            return new MesaVitoriana();
        }

        public override Sofa CriarSofas()
        {
            return new SofaVitoriana();
        }
    }
}