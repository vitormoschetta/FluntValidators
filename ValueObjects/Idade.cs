using Flunt.Notifications;
using Flunt.Validations;

namespace FluntValidators.ValueObjects
{
    public class Idade : Notifiable
    {
        public Idade(int idade)
        {
            IdadeUsuario = idade;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(MaiorDeIdade(IdadeUsuario), "Idade", "Não permitido menor de idade")
            );
        }
        public int IdadeUsuario { get; set; }



        public bool MaiorDeIdade(int idade)
        {
            if (idade < 18)
                return false;

            return true;
        }
    }
}