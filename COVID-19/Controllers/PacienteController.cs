using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID_19.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace COVID_19.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            return Ok("Listagem de todos os Pacientes");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok("Detalhes do paciente");
        }

  

        [HttpPost]
        public async Task<IActionResult> Post(Paciente paciente)
        {
            if (string.IsNullOrEmpty(paciente.nome)) {
                return BadRequest("Nome do paciente está vazio, tente novamente!");
            }
            return Ok("Paciente Cadastrado com sucesso");
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, Paciente paciente)
        {

            if (string.IsNullOrEmpty(paciente.nome))
            {
                return BadRequest("Verifique novamente os dados do Paciente!");
            }
            return Ok("Dados atualizados do paciente:<br> Nome do paciente:" + paciente.nome + " Cidade: " + paciente.cidade + "Estado: " + paciente.estado + "Sexo: " + paciente.sexo + "Estado Civil:" + paciente.estado_civil);

        }
            [HttpDelete]
            public async Task<IActionResult> Delete(int id)
            {
                if (id > 0)
                {
                    return Ok("Paciente deletado com sucesso!");
                }
                return BadRequest("HAHA, o que já foi cadastrado nunca será deletado");
            }
        
    }
}
