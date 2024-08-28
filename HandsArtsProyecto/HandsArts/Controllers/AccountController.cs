using HandsArts.Data;
using HandsArts.Models;
using HandsArts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HandsArts.Controllers

{

    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Acción para mostrar el formulario de registro
        [HttpGet]
        public IActionResult RegistroEmpresa()
        {
            return View();
        }

        [HttpPost]
        // Acción para procesar el formulario de registro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegistroEmpresa(EmpresaVM model)
        {
            if (ModelState.IsValid)
            {
                // Verifica si el RUT ya está registrado
                if (await _context.Empresas.AnyAsync(e => e.RutEmpresa == model.RutEmpresa))
                {
                    ModelState.AddModelError("RutEmpresa", "El RUT ya está registrado.");
                    return View(model);
                }

                // Crea un nuevo objeto Empresa
                var empresa = new Empresa
                {
                    RutEmpresa = model.RutEmpresa,
                    NombreEmpresa = model.NombreEmpresa,
                    RazonSocial = model.RazonSocial,
                    GiroComercial = model.GiroComercial,
                    Rubro = model.Rubro,
                    PoliticaDevoluciones = model.PoliticaDevoluciones,
                    SectorGeografico = model.SectorGeografico,
                    NumeroRegistroTributario = model.NumeroRegistroTributario,
                    ModoEnvioPreferido = model.ModoEnvioPreferido,
                    Nombre = model.Nombre,
                    //ApellidoPaterno=model.ApellidoPaterno,
                    //ApellidoMaterno = model.ApellidoMaterno,
                    Correo = model.Correo,
                    Contraseña = model.Contraseña, // En producción, asegúrate de encriptar la contraseña
                    Telefono = model.Telefono,
                    Direccion = model.Direccion,
                    EstadoVerificacion = false // Por defecto, el estado de verificación está en falso
                };

                // Agrega la empresa al contexto y guarda los cambios
                _context.Empresas.Add(empresa);
                await _context.SaveChangesAsync();

                return RedirectToAction("tienda"); // Redirige a una página de éxito o al listado de empresas
            }

            // Si el modelo no es válido, vuelve a mostrar el formulario con los errores
            return View(model);
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult TipoRegistro()
        {
            return View();
        }
        public IActionResult RegistroComprador()
        {
            return View();
        }
    }
}

