using System;
using FluntValidators.Entidades;

namespace FluntValidators
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario("Vitor", 17, "vitor@gmail.com");
            usuario.MostraUsuario();

            var produto = new Produto("Leite", 0);
            produto.MostrarProduto();
        }
    }
}
