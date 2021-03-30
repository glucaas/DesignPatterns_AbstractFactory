using DesignPatterns_AbstractFactory.Produtos;

namespace DesignPatterns_AbstractFactory
{
    public class Cliente
    {
        private LojaMobiliaAbstractFactory _abstractFactory;
        private Cadeira _cadeira;
        private Mesa _mesa;
        private Sofa _sofa;
        public Cliente(LojaMobiliaAbstractFactory abstractFacotry)
        {
            _abstractFactory = abstractFacotry;
            _cadeira = _abstractFactory.CriarCadeiras();
            _mesa = _abstractFactory.CriarMesas();
            _sofa = _abstractFactory.CriarSofas();
        }

        public void ObterDescricaoMateriais(){
            _cadeira.Descricao();
            _mesa.Descricao();
            _sofa.Descricao();
        }



        
    }
        
}