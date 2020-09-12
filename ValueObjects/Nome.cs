using Flunt.Notifications;
using Flunt.Validations;

namespace FluntValidators.ValueObjects
{
    public class Nome : Notifiable
    {
        public Nome(string nome)
        {
            NomeUsuario = nome;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(NomeUsuario, 3, "Nome", "Nome deve conter pelo menos 3 caracteres")
            );
        }

        public string NomeUsuario { get; set; }
    }
}