using AppPOOAbstract.model;

Console.WriteLine("Escolha o tipo de cliente (1 - PF / 2 - PJ):");
string opcao = Console.ReadLine();

Console.WriteLine("Digite o nome:");
string nome = Console.ReadLine();

Console.WriteLine("Digite o email:");
string email = Console.ReadLine();

// Declaramos a variável do tipo abstrato
// A Variável Polimórfica: Note que declaramos Cliente cliente; (o tipo abstrato). 
// Isso mostra que, embora não possamos dar um new Cliente(), podemos usar esse 
//tipo para armazenar qualquer classe que herde dele.
Cliente cliente;

if (opcao == "1")
{
    Console.WriteLine("Digite o CPF:");
    string cpf = Console.ReadLine();

    // Instanciamos a especialização PF
    cliente = new ClientePF { Nome = nome, Email = email, CPF = cpf };
}
else
{
    Console.WriteLine("Digite o CNPJ:");
    string cnpj = Console.ReadLine();

    // Instanciamos a especialização PJ
    cliente = new ClientePJ { Nome = nome, Email = email, CNPJ = cnpj };
}

// O polimorfismo acontece aqui: 
// Não importa se é PF ou PJ, o compilador confia que 'cliente' sabe se validar e se exibir.
// A "Mágica" do Método Abstrato: O comando cliente.ValidarCadastro() chamará 
//  a lógica de 11 dígitos se for PF, ou de 14 dígitos se for PJ, sem que você 
//  precise de um if para decidir qual método chamar naquele momento.

Console.WriteLine("\n--- Resultado da Validação ---");

if (cliente.ValidarCadastro())
{
    cliente.ExibirInformacoes();
}
else
{
    // Verificação de tipo  para uma mensagem personalizada
    string tipoDoc = cliente is ClientePF ? "CPF" : "CNPJ";

    Console.WriteLine($"{tipoDoc} inválido para o cliente {cliente.Nome}");
}

Console.ReadLine();
