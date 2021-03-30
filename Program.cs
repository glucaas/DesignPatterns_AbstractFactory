using System;
using DesignPatterns_AbstractFactory.Factories;

namespace DesignPatterns_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente(new ArtDecoFactory());
           cliente.ObterDescricaoMateriais();

        }
    }
}
