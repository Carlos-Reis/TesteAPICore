using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAgil.API.Model;
using ProAgil.API.Data;

namespace ProAgil.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public DataContext _context { get; }
        public WeatherForecastController(DataContext context)
        {
            _context = context;
            
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return _context.Eventos.ToList();
            
            /*new Evento[] {
                new Evento(){
                    EventoId = 1,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    Tema = "Festa",
                    QtdPessoas = 100,
                    Local = "RJ",
                    Lote = "1º Lote"
                },
                new Evento(){
                    EventoId = 2,
                    DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                    Tema = "Meeting",
                    QtdPessoas = 50,
                    Local = "RJ",
                    Lote = "2º Lote"
                }
            };*/
        }

        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return _context.Eventos.FirstOrDefault(x => x.EventoId == id);
            
            /*new Evento[] {
                new Evento(){
                    EventoId = 1,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    Tema = "Festa",
                    QtdPessoas = 100,
                    Local = "RJ",
                    Lote = "1º Lote"
                },
                new Evento(){
                    EventoId = 2,
                    DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                    Tema = "Meeting",
                    QtdPessoas = 50,
                    Local = "RJ",
                    Lote = "2º Lote"
                }
            }.FirstOrDefault(x => x.EventoId == id);*/
        }
    }
}
