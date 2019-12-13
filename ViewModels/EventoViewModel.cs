using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class EventoViewModel : BaseViewModel
    {
        public Cliente Cliente {get;set;}

        public EventoViewModel()
        {
            this.Cliente = new Cliente();
        }
    }
}