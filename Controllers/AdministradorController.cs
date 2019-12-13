using McBonaldsMVC.Controllers;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers {
    public class AdministradorController : AbstractController {
        EventoRepository eventoRepository = new EventoRepository ();

        [HttpGet]
        public IActionResult Dashboard () {

            var eventos = eventoRepository.ObterTodos ();
            DashboardViewModel dashboardViewModel = new DashboardViewModel ();

            foreach (var evento in eventos) {
                switch (evento.Status) {
                    case (uint) StatusEvento.REPROVADO:
                        dashboardViewModel.EventosReprovados++;
                        break;
                    case (uint) StatusEvento.APROVADO:
                        dashboardViewModel.EventosAprovados++;
                        break;
                    default:
                        dashboardViewModel.EventosPendentes++;
                        dashboardViewModel.Eventos.Add (evento);
                        break;
                }
            }

            dashboardViewModel.NomeView = "Dashboard";
            dashboardViewModel.UsuarioEmail = ObterUsuarioSession ();

            return View (dashboardViewModel);
        }
    }
}