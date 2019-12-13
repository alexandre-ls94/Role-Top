using System;
using RoleTopMVC.Enums;

namespace RoleTopMVC.Models
{
    public class Evento
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public int Publico {get;set;}
        public string TipoEvento {get;set;}
        public DateTime DataInicio {get;set;}
        public DateTime DataTermino {get;set;}
        public string Iluminacao {get;set;}
        public string Som {get;set;}
        public string Limpeza {get;set;}
        public Pagamento Pagamento {get;set;}
        public uint Status {get;set;}
        public string StatusString {get;set;}

        public Evento()
        {
            this.Cliente = new Cliente();
            this.Pagamento = new Pagamento();
            this.Id = 0;
            this.Status = (uint) StatusEvento.PENDENTE;
            this.StatusString = "Pendente";
        }
    }
}