using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea_4.Models;
namespace Tarea_4.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        [HttpPost]
        public ActionResult Persona(Persona perso, HttpPostedFileBase imagen)
        {
            Persona obj = new Persona();
            obj.cedula = Convert.ToInt64(Request.Form["cedula"]);
            obj.nombre = Request.Form["nombre"].ToString();
            obj.apellido = Request.Form["apellido"].ToString();
            obj.edad = Convert.ToInt32(Request.Form["edad"]);
            obj.telefono = Convert.ToInt64(Request.Form["telefono"]);
            obj.correo = Request.Form["correo"].ToString();
            obj.genero = Request.Form["genero"].ToString();
            obj.cargo = Request.Form["cargo"].ToString();
            if (ModelState.IsValid)
            {
                string nombreFoto = imagen.FileName;
                imagen.SaveAs(Server.MapPath("/imagen/" + nombreFoto));

                ViewBag.foto = nombreFoto;
                return View("Index");
            }
            else
            {
                return View("Index");
            }
            
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}