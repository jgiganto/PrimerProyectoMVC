using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrimerProyectoMVC.Models;

namespace PrimerProyectoMVC.Controllers
{
    public class InformacionController : Controller
    {
        // GET: Informacion
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ControladorVista()
        {
            //view data es antiguo , no case sensitive
            ViewData["APP"] = "Visual Studio 2017";
            //ViewBag es el valor que se usa en la actualidad, envia mas informacion a las vistas, ademas
            //de el modelo. se puede enviar cualquier objeto
            ViewBag.Contenido = "Soy contenido de viewbag";


            //CUANDO SE REALICE UNA PETICION SOBRE LA VISTA controladorVista
            //devolvemos dicha vista
            Persona persona = new Persona();
            persona.Nombre = "Carlos";
            persona.Edad = 44;
            persona.Apellidos = "Casales";
            //PARA ENVIAR EL MODELO A LA VISTA 
            //SE REALIZA AL DEVOLVER LA PETICION
            //UN MODELO NO PUEDE SER STRING 
            return View(persona);
        }
    }
}