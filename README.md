# FluntValidators

Implementação da biblioteca [Flunt](https://github.com/andrebaltieri/flunt)

Você pode seguir as orientações do repositório oficial para a instalação da dll.

Pode ainda baixar o código fonte e utilizar junto ao seu projeto, seja no mesmo domínio ou em domínio separado.

### Entidade Produto
Valida e Adiciona as Notificações no próprio Construtor. 
Nessa entidade usamos apenas tipos primitivos como parâmetros:

```
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
}
```


### Entidade Usuario
Faz as validações no construtor dos ValueObjects:

```
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
}

```

Exemplo ValueObject Email:
```
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
```



        
