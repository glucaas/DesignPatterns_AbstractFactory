using DesignPatterns_AbstractFactory.Produtos;

namespace DesignPatterns_AbstractFactory
{
    public abstract class LojaMobiliaAbstractFactory
    {
        public abstract Cadeira CriarCadeiras();
        public abstract Mesa CriarMesas();
        public abstract Sofa CriarSofas();
    }
}