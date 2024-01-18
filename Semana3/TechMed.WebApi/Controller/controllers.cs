using Microsoft.AspNetCore.Mvc;
using TechMed.Medico;

namespace TechMed.Controllers;

[Route("[controller]")]
public class Controle : ControllerBase
{

    private static readonly Medicoz[] Medicos = new[]{
        new Medicoz
        {

            Nome = "Dr. House",
            Especialidade = "Clínico Geral",
            Salario = 10000.00
        },
        new Medicoz
        {
            Nome = "Dr. Drauzio Varella",
            Especialidade = "Clínico Geral",
            Salario = 10000.00
        },

    };

    [HttpGet("medicos")]
    public IEnumerable<Medicoz> GetMedicos()
    {
        return Medicos;
    }

    [HttpDelete("medicos/{id}")]
    public IActionResult DeleteMedico(Guid id)
    {
        var medico = Medicos.FirstOrDefault(m => m.Id == id);
        if (medico == null)
        {
            return NotFound();
        }
        
        return NoContent(); 
    }

    [HttpPost("medicos")]
    public IActionResult PostMedico(Medicoz medico){

        return CreatedAtAction(nameof(GetMedicos), new {id = medico.Id}, medico);
    }

    [HttpPut("medicos/{id}")]
    public IActionResult PutMedico(Guid id, Medicoz medico){
        if(id != medico.Id){
            return BadRequest();
        }
        return NoContent();
    }

    [HttpGet("medicos/{id}")]
    public IActionResult GetMedico(Guid id){
        var medico = Medicos.FirstOrDefault(m => m.Id == id);
        if(medico == null){
            return NotFound();
        }
        return Ok(medico);
    }

    // Controle()
    // {
    //     Medicoz medico = new Medicoz();
    //     medico.Nome = "Dr. House";
    //     medico.Especialidade = "Clínico Geral";
    //     medico.Salario = 10000.00;
    // }


}
