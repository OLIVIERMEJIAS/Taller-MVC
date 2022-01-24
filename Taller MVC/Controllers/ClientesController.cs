using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller_MVC.Data;
using Taller_MVC.Models;

namespace Taller_MVC.Controllers
{
    public class ClientesController : Controller
    {
        private readonly Context _context;

        public ClientesController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Cliente> listaClientes = _context.Cliente;

            return View(listaClientes);
        }


    }
}
