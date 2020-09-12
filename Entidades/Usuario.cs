using System;
using Flunt.Notifications;
using FluntValidators.ValueObjects;

namespace FluntValidators.Entidades
{
    public class Usuario : Notifiable
    {
        public Usuario(string nome, int idade, string email)
        {
            Nome = new Nome(nome);
            Idade = new Idade(idade);
            Email = new Email(email);

            AddNotifications(Nome, Idade, Email);
        }
        public Nome Nome { get; set; }
        public Idade Idade { get; set; }
        public Email Email { get; set; }


        public void MostraUsuario()
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
                Console.WriteLine("Nome :" + Nome.NomeUsuario);
                Console.WriteLine("Idade: " + Idade.IdadeUsuario);
                Console.WriteLine("E-mail: " + Email.EnderecoEmail);
            }

        }

    }
}