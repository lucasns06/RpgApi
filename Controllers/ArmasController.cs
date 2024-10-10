using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;
using RpgApi.Models;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArmasController : ControllerBase
    { 
         private readonly DataContext _context;
        public ArmasController(DataContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Add(Arma novaArma)
        {
            try
            {
                if(novaArma.Dano == 0)
                    throw new Exception("O dano da arma não pode ser 0.");

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                Personagem p = await _context.TB_PERSONAGENS
                    .FirstOrDefaultAsync(p => p.Id == novaArma.PersonagemId);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                if(p == null)
                    throw new Exception("Não existe personagem com o Id informado");

                await _context.TB_ARMAS.AddAsync(novaArma);
                await _context.SaveChangesAsync();

                return Ok(novaArma.Id);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    
    }
}