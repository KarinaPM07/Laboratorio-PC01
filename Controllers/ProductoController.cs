using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Laboratorio_PC01.Models;
using Laboratorio_PC01.Data;


namespace Laboratorio_PC01.Controllers
{
    public class Producto : Controller
    
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public ProductoController(ILogger<HomeController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producto objproducto)
        {
        _context.Add(objproducto);
        _context.SaveChanges();
        ViewData["Message"] = "El Producto ya esta registrado";
            return View();
        }

        public IActionResult Edit(int id){
            Producto objproducto= _context.Productos.Find(id);
            if(objproducto == null){
                return NotFound();
            }
            return View(objproducto);
            }
        [HttpPost]
         public IActionResult Edit(int id,[Bind("id,Nombre,Categoria,Precio,Descuento")] Producto objproducto)
        {
        _context.Add(objproducto);
        _context.SaveChanges();
        ViewData["Message"] = "El Producto ya esta registrado";
            return View(objproducto);
        }
         /*public IActionResult Delete(int id)
        {
        _context.Add(objproducto);
        _context.SaveChanges();
        ViewData["Message"] = "El Producto ya esta registrado";
            return View(objproducto);
        }*/


    }
}