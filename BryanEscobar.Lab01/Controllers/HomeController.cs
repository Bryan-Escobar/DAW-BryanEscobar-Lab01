using BryanEscobar.Lab01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BryanEscobar.Lab01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "Bryan Steven Escobar Preza";
            ViewBag.Carrera = "Ingeniería en Desarrollo de Software";
            ViewBag.Asignatura = "Desarrollo Multiplataforma de Aplicaciones Web";
            ViewBag.SobreMi = "Desarrollador Full Stack especializado en React Native, Node.js y Agentes de IA. Combino mi base técnica con una profunda pasión por la comunicación y socialización de ideas. Creo firmemente que los mejores productos tecnológicos no solo requieren un código impecable, sino la habilidad de saber expresarlos y conectar con las personas.\r\n\r\n";
            ViewBag.MetasProfesionales = new List<string>
            {
                "Graduarme de ingeniería mientras acumulo experiencia inicial.",
                "Convertirme en líder de equipo.",
                "Ser líder de proyecto.",
                "Escalar y poder presentar productos de software en grandes conferencias con pitches profesionales.",
                "Convertirme en CTO de alguna compañía y desarrollar una habilidad en comunicación corporativa con excelencia."
            };
            ViewBag.EtapaActual = 1;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
