using System;
using McBonaldsMVC.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                UsuarioTipo = ObterUsuarioTipoSession()
            });
        }

        public IActionResult CadastrarCliente (IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";

            try{
                Cliente cliente = new Cliente(
                    form["nome"],
                    form["cpf"],
                    form["telefone"],
                    form["email"],
                    form["empresa"],
                    form["senha"]
                );

                if(form["senha"] == form["confirmaSenha"])
                {
                    clienteRepository.Inserir(cliente);
                } 
                else 
                {
                    return View("Erro", new RespostaViewModel("Senha não foi confirmada !"));
                }

                return View("Sucesso", new RespostaViewModel(""));

            } catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel("Algo de errado não esta certo !"));
            }
        }
    }
}