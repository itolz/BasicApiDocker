using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        
        [HttpGet]
        [Route("filmes")]
        public IEnumerable<string> GetFilmes()
        {
            return new List<string>(4)
            {
                "Matrix",
                "Matrix II",
                "Matrix III"
            };
        }

        [HttpGet]
        [Route("musicas")]
        public IEnumerable<string> GetMusicas()
        {
            return new List<string>(4)
            {
                "Time",
                "Psycho Killer",
                "Take On Me"
            };
        }

        [HttpGet]
        [Route("livros")]
        public IEnumerable<string> GetLivros()
        {
            return new List<string>(4)
            {
                "Mastery - Robert Greene",
                "Clean Architecture - Uncle Bob",
                "DDD - Eric Evans"
            };
        }
    }
}