using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace FluntValidators.Entidades
{
    public class Produto : Notifiable
    {
        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;

            AddNotifications(new Contract()
               .Requires()
               .HasMinLen(Nome, 3, "Nome", "Nome tem que ter pelo menos 3 caracteres")
               .IsGreaterOrEqualsThan(Preco, 1, "Preço", "Informe um preço válido")
            );

        }
        public string Nome { get; set; }
        public decimal Preco { get; set; }


        public void MostrarProduto()
        {
            if (Invalid)
            {
                foreach (var item in Notifications)
                {
                    Console.WriteLine(item.Message);
                }

            }
            if (Valid)
            {
                Console.WriteLine("Nome :" + Nome);
                Console.WriteLine("Preco: " + Preco);
            }

        }
    }
}