namespace RoleTopMVC.Models
{
    public class Pagamento
    {
        public string FormaPagamento {get;set;}
        public ulong NumCartao {get;set;}
        public string NomeImpresso {get;set;}
        public string Vencimento {get;set;}
        public int CVV {get;set;}

        public Pagamento()
        {
            
        }

        public Pagamento(string formaPagamento, ulong numCartao, string nomeImpresso, string vencimento, int cvv)
        {
            this.FormaPagamento = formaPagamento;
            this.NumCartao = numCartao;
            this.NomeImpresso = nomeImpresso;
            this.Vencimento = vencimento;
            this.CVV = cvv;
        }
    }
}