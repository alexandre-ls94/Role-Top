using System;
using McBonaldsMVC.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class EventoController : AbstractController
    {
        EventoRepository eventoRepository = new EventoRepository();
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {
            EventoViewModel evento = new EventoViewModel();

            var usuarioLogado = ObterUsuarioSession();
            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);

            if(clienteLogado != null)
            {
                evento.Cliente = clienteLogado;
            }

            evento.NomeView = "Evento";
            evento.UsuarioEmail = ObterUsuarioSession();
            evento.UsuarioNome = ObterUsuarioNomeSession();

            return View(evento);
        }

        public IActionResult Registrar(IFormCollection form)
        {
            ViewData["Action"] = "Evento";

            Evento evento = new Evento();

            Cliente cliente = new Cliente()
            {
                Nome = form["nome"],
                Cpf = form["cpf"],
                Telefone = form["telefone"],
                Email = form["email"],
                Empresa = form["empresa"]
            };

            evento.Publico = int.Parse(form["publico"]);
            evento.TipoEvento = form["evento"];
            evento.DataInicio = DateTime.Parse(form["inicio"]);
            evento.DataTermino = DateTime.Parse(form["termino"]);
            evento.Iluminacao = form["iluminacao"];
            evento.Som = form["som"];
            evento.Limpeza = form["limpeza"];

            Pagamento pagamento = new Pagamento()
            {
                FormaPagamento = form["pagamento"],
                NumCartao = ulong.Parse(form["ncartao"]),
                NomeImpresso = form["nome-impresso"],
                Vencimento = form["vencimento"],
                CVV = int.Parse(form["cvv"])
            };

            evento.Cliente = cliente;
            evento.Pagamento = pagamento;

            if(eventoRepository.Inserir(evento))
            {
                return View("Sucesso", new RespostaViewModel()
                {
                    Mensagem = "Aguardando aprovação",
                    NomeView = "Sucesso",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
            else
            {
                return View("Erro", new RespostaViewModel()
                {
                    Mensagem = "Algo de errado não esta certo !",
                    NomeView = "Erro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult Aprovar(ulong id)
        {
            Evento evento = eventoRepository.ObterPor(id);
            evento.Status = (uint) StatusEvento.APROVADO;
            evento.StatusString = "Aprovado";
            
            if(eventoRepository.Atualizar(evento))
            {
                return RedirectToAction("Dashboard","Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel()
                {
                    Mensagem = "Houve um erro ao aprovar o evento.",
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession(),
                    UsuarioTipo = ObterUsuarioTipoSession()
                });
            }
        }

        public IActionResult Reprovar(ulong id)
        {
            Evento evento = eventoRepository.ObterPor(id);
            evento.Status = (uint) StatusEvento.REPROVADO;
            evento.StatusString = "Reprovado";  
            
            if(eventoRepository.Atualizar(evento))
            {
                return RedirectToAction("Dashboard","Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel()
                {
                    Mensagem = "Houve um erro ao aprovar o evento.",
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}