using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Senha { get; set; }
        public DateTime DataPedido {get; set;}
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        //pode haver pelo menos um pedido a vários
        public ICollection<ItemPedido> itemPedido { get; set; }
    }
}
