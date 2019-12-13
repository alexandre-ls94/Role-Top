using McBonaldsMVC.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers {
    public class ClienteController : AbstractController {
        private ClienteRepository clienteRepository = new ClienteRepository ();
        private EventoRepository eventoRepository = new EventoRepository();

        [HttpGet]
        public IActionResult Login () {
            return View (new BaseViewModel () {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession (),
                UsuarioNome = ObterUsuarioNomeSession (),
                UsuarioTipo = ObterUsuarioTipoSession()
            });
        }

        [HttpPost]

        public IActionResult Login (IFormCollection form) {
            ViewData["Action"] = "Login";

            System.Console.WriteLine ("======================");
            System.Console.WriteLine (form["email"]);
            System.Console.WriteLine (form["senha"]);
            System.Console.WriteLine ("======================");

            var usuario = form["email"];
            var senha = form["senha"];

            var cliente = clienteRepository.ObterPor (usuario);

            if (cliente != null)
            {
                if (cliente.Senha.Equals (senha)) 
                {
                    switch (cliente.TipoUsuario)
                    {
                        case (uint) TiposUsuario.CLIENTE:
                        HttpContext.Session.SetString (SESSION_CLIENTE_EMAIL, usuario);
                        HttpContext.Session.SetString (SESSION_CLIENTE_NOME, cliente.Nome);
                        HttpContext.Session.SetString (SESSION_TIPO_USUARIO, cliente.TipoUsuario.ToString());

                        return RedirectToAction ("Index", "Evento");

                        default:
                        HttpContext.Session.SetString (SESSION_CLIENTE_EMAIL, usuario);
                        HttpContext.Session.SetString (SESSION_CLIENTE_NOME, cliente.Nome);
                        HttpContext.Session.SetString (SESSION_TIPO_USUARIO, cliente.TipoUsuario.ToString());

                        return RedirectToAction ("Dashboard", "Administrador");
                    }
                } 
                else 
                {
                    return View ("Erro", new RespostaViewModel ("Senha incorreta !"));
                }
            } 
            else 
            {
                return View ("Erro", new RespostaViewModel ("Usuario não encontrado !"));
            }
        }

        public IActionResult Historico()
        {
            var emailCliente = ObterUsuarioSession();
            var eventos = eventoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                Eventos = eventos,
                NomeView = "Historico",
                UsuarioNome = ObterUsuarioNomeSession(),
                UsuarioEmail = ObterUsuarioSession()
            });
        }

        public IActionResult Logoff () 
        {
            HttpContext.Session.Remove (SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove (SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear ();
            return RedirectToAction ("Index", "Home");
        }
    }
}