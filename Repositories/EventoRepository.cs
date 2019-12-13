using System;
using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Repositories;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class EventoRepository : RepositoryBase
    {
        private const string PATH = "Database/Evento.csv";

        public EventoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Evento evento)
        {
            var quantidadesLinhas = File.ReadAllLines(PATH).Length;
            evento.Id = (ulong) quantidadesLinhas++;
            var linha = new string[] { PrepararRegistroCSV(evento) };
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public List<Evento> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);

            List<Evento> eventos = new List<Evento>();

            foreach (var linha in linhas)
            {
                Evento evento = new Evento();

                evento.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                evento.Status = uint.Parse(ExtrairValorDoCampo("status_evento", linha));
                evento.StatusString = ExtrairValorDoCampo("status_string", linha);
                evento.Cliente.Nome = ExtrairValorDoCampo("nome", linha);
                evento.Cliente.Cpf = ExtrairValorDoCampo("cpf", linha);
                evento.Cliente.Telefone = ExtrairValorDoCampo("telefone", linha);
                evento.Cliente.Email = ExtrairValorDoCampo("email", linha);
                evento.Cliente.Empresa = ExtrairValorDoCampo("empresa", linha);
                evento.Publico = int.Parse(ExtrairValorDoCampo("publico", linha));
                evento.TipoEvento = ExtrairValorDoCampo("tipo_evento", linha);
                evento.DataInicio = DateTime.Parse(ExtrairValorDoCampo("data_inicio", linha));
                evento.DataTermino = DateTime.Parse(ExtrairValorDoCampo("data_termino", linha));
                evento.Iluminacao = ExtrairValorDoCampo("iluminacao", linha);
                evento.Som = ExtrairValorDoCampo("som", linha);
                evento.Limpeza = ExtrairValorDoCampo("limpeza", linha);
                evento.Pagamento.FormaPagamento = ExtrairValorDoCampo("forma_pagamento", linha);
                evento.Pagamento.NumCartao = ulong.Parse(ExtrairValorDoCampo("num_cartao", linha));
                evento.Pagamento.NomeImpresso = ExtrairValorDoCampo("nome_impresso", linha);
                evento.Pagamento.Vencimento = ExtrairValorDoCampo("vencimento", linha);
                evento.Pagamento.CVV = int.Parse(ExtrairValorDoCampo("cvv", linha));
                
                eventos.Add(evento);
            }

            return eventos;
        }

        public List<Evento> ObterTodosPorCliente(string email)
        {
            var eventosTotais = ObterTodos();
            List<Evento> eventosCliente = new List<Evento>();
            foreach (var evento in eventosTotais)
            {
                if(evento.Cliente.Email.Equals(email))
                {
                    eventosCliente.Add(evento);
                }
            }
            return eventosCliente;
        }


        public Evento ObterPor (ulong id)
        {
            var eventosTotais = ObterTodos();
            foreach (var evento in eventosTotais)
            {
                if (evento.Id == id)
                {
                    return evento;
                }
            }
            return null;
        }

        public bool Atualizar (Evento evento)
        {
            var eventosTotais = File.ReadAllLines(PATH);
            var eventoCSV = PrepararRegistroCSV(evento);
            var linhaEvento = -1;
            var resultado = false;

            for (int i = 0; i < eventosTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", eventosTotais[i]));
                if (evento.Id.Equals(idConvertido))
                {
                    linhaEvento = i;
                    resultado = true;
                    break;
                }
            }

            if (resultado)
            {
                eventosTotais[linhaEvento] = eventoCSV;
                File.WriteAllLines(PATH, eventosTotais);
            }

            return resultado;

        }

        private string PrepararRegistroCSV(Evento evento)
        {
            return $"id={evento.Id};status_evento={evento.Status};status_string={evento.StatusString};nome={evento.Cliente.Nome};cpf={evento.Cliente.Cpf};telefone={evento.Cliente.Telefone};email={evento.Cliente.Email};empresa={evento.Cliente.Empresa};publico={evento.Publico};tipo_evento={evento.TipoEvento};data_inicio={evento.DataInicio};data_termino={evento.DataTermino};iluminacao={evento.Iluminacao};som={evento.Som};limpeza={evento.Limpeza};forma_pagamento={evento.Pagamento.FormaPagamento};num_cartao={evento.Pagamento.NumCartao};nome_impresso={evento.Pagamento.NomeImpresso};vencimento={evento.Pagamento.Vencimento};cvv={evento.Pagamento.CVV}";
        }
    }
}