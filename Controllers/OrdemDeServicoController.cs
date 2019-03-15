using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SelectListEmCascata.Models;

namespace SelectListEmCascata.Controllers
{
    public class OrdemDeServicoController : Controller
    {
        private IList<Cliente> clientes = new List<Cliente> 
        {
            new Cliente
            {
                Id = 1,
                Nome = "Leonard"
            },
            new Cliente
            {
                Id = 2,
                Nome = "Peny"
            },
            new Cliente
            {
                Id = 3,
                Nome = "Sheldon"
            }
        };
        private IList<Orcamento> orcamentos = new List<Orcamento>
        {
            new Orcamento
            {
                Id = 1,
                ClienteId = 1,
                Total = 100,
            },
            new Orcamento
            {
                Id = 2,
                ClienteId = 1,
                Total = 90,
            },
            new Orcamento
            {
                Id = 3,
                ClienteId = 2,
                Total = 110,
            },
            new Orcamento
            {
                Id = 4,
                ClienteId = 2,
                Total = 100,
            },
            new Orcamento
            {
                Id = 5,
                ClienteId = 3,
                Total = 100,
            },

        };

        public IActionResult Create() 
        {
            clientes.Insert(0, new Cliente {Id = 0, Nome = "Selecione o Cliente"});
            ViewBag.Clientes = clientes;

            return View();
        }

        [Route("ordemdeservico/{id}")]
        public IActionResult ListarOrcamentosPorCliente(int id)
        {
            var orcamentosPorId = orcamentos.Where(o => o.ClienteId == id).ToList();
            return Json(orcamentosPorId);
        }
    }
}