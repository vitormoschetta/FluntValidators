using Flunt.Notifications;
using Flunt.Validations;

namespace FluntValidators.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string email)
        {
            EnderecoEmail = email;

            AddNotifications(new Contract()
               .Requires()
               .IsEmail(EnderecoEmail, "Email", "E-mail inválido")
            );
        }

        public string EnderecoEmail { get; set; }

    }
}