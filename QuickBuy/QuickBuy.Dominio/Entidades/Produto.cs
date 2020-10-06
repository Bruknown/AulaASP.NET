namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Id { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Nome do produto não foi encontrado");
            }
            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarCritica("descrição não foi encontrada");
            }
        }
    }
}
