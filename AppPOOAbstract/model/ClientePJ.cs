namespace AppPOOAbstract.model
{
    public class ClientePJ : Cliente
    {
        private string _cnpj;

        public string CNPJ
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        // Implementação obrigatória da regra para Pessoa Jurídica
        public override bool ValidarCadastro()
        {
            // Regra didática: CNPJ deve ter 14 dígitos
            return !string.IsNullOrEmpty(CNPJ) && CNPJ.Length == 14;
        }

        // Especialização do método de exibição
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"CNPJ: {CNPJ}");
        }
    }
}
