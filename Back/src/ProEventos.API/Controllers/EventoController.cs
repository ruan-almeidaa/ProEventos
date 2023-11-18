using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{

                new Evento(){
                    EventoId = 1,
                    Tema = "Angular",
                    Local = "Igrejinha/RS",
                    Lote = "1",
                    QtdPessoas = 100,
                    DataEvento = DateTime.Now.AddDays(3).ToString(),
                    ImagemURL = "foto.jpeg"
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Node",
                    Local = "Igrejinha/RS",
                    Lote = "4",
                    QtdPessoas = 1200,
                    DataEvento = DateTime.Now.AddDays(6).ToString(),
                    ImagemURL = "fotoEv2.jpeg"
                }

        };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }


        [HttpGet("{id}")]
        public IEnumerable<Evento> GetbyId(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }
}
}
