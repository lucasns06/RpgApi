using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RpgApi.Models;
using RpgApi.Models.Enuns;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonagensExercicioController : ControllerBase
    {
         private static List<Personagem> personagens = new List<Personagem>()
        {
            new Personagem(){ Id = 1, Nome="Frodo", PontosVida = 100, Forca = 17, Defesa = 23, Inteligencia = 33, Classe = Models.Enuns.ClasseEnum.Cavaleiro},
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago },
        };

       [HttpGet("GetByNome/{nome}")]
        public ActionResult<Personagem> GetByNome(string nome)
        {
            var personagem = personagens.FirstOrDefault(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (personagem == null)
            {
                return NotFound(new { Mensagem = "Personagem não encontrado." });
            }
            return Ok(personagem);
        }
        [HttpGet("GetClerigoMago")]
        public IActionResult GetClerigoMago()
        {
            /*
            Método do tipo Get com rota GetClerigoMago que remova os personagens que são cavaleiros, exiba a 
            lista decrescente por PontosVida 
            */
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Personagem pRemove = personagens.Find(p => p.Classe == ClasseEnum.Cavaleiro);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            personagens.Remove(pRemove);

            List<Personagem> listaFinal = personagens.OrderByDescending(p => p.PontosVida).ToList();
            return Ok(listaFinal);
        }
         
         [HttpGet("GetEstatisticas")]
        public IActionResult GetEstatisticas()
        {

            int quantidadePersonagens = personagens.Count;
        
            int somaInteligencia = personagens.Sum(p => p.Inteligencia);

            var estatisticas = new //Objeto anônimo que retorna as duas variaveis
                {
                    QuantidadePersonagens = quantidadePersonagens,
                    SomaInteligencia = somaInteligencia
                };
            return Ok(estatisticas);
        }

        [HttpPost("PostValidacao")]
        public IActionResult PostValidacao(Personagem novoPersonagem)
        {
            if (novoPersonagem.Defesa < 10 || novoPersonagem.Inteligencia > 30  )
                return BadRequest("Personagem fraco demais, ou Personagem inteligente demais, da para tentar uma USP");

            personagens.Add(novoPersonagem);
            return Ok(personagens);
        }
        
        [HttpPost("PostValidacaoMago")]
        public IActionResult PostValidacaoMago(Personagem novoPersonagem)
        {
            if (novoPersonagem.Classe == ClasseEnum.Mago && novoPersonagem.Inteligencia < 35)
                return BadRequest("Este mago é meio burro");
           
            personagens.Add(novoPersonagem);
            return Ok(personagens);
        }
        [HttpGet("GetByClasse/{classeId}")]
        public IActionResult GetByEnum(int classeId)
        {
                ClasseEnum enumDigitado = (ClasseEnum)classeId;

                List<Personagem> listaBusca = personagens.FindAll(p => p.Classe == enumDigitado );

                return Ok(listaBusca);
        }
    }
}