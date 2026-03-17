namespace AppPOOAbstract.model
{
    public abstract class Cliente
    {
        private string _nome;
        private string _email;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        // Método abstrato que força subclasses a implementar sua validação específica
        public abstract bool ValidarCadastro();

        // Método concreto compartilhado entre todos os clientes
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
