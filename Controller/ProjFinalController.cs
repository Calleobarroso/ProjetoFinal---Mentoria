using MentoriaProjFinal.Models;
using MentoriaProjFinal.Service.Interface;
using MentoriaProjFinal.Service;
using Microsoft.AspNetCore.Mvc;

namespace MentoriaProjFinal.Controllers;


[Route("/[controller]")]
public class ProjFinalController : ControllerBase
{
    
    private readonly IServicePessoa _servicePessoa;

    public ProjFinalController(IServicePessoa servicePessoa)
    {
        _servicePessoa = servicePessoa;
    }

    [HttpGet("Listar usuários")]
    public async Task<ActionResult> GetUsers()
    {
        return Ok(await _servicePessoa.GetUsers());
    }

    [HttpPost("Novo usuário")]
    public async Task<ActionResult> AddUser(Pessoa pessoa)
    {
        return Ok(await _servicePessoa.AddUser(pessoa));
    }

    [HttpPut("Editar usuário")]
    public async Task<ActionResult> UpdateUser(Pessoa pessoa)
    {
        return Ok(await _servicePessoa.UpdateUser(pessoa));
    }

    [HttpDelete("Deletar usuário")]
    public async Task<ActionResult> DeleteUser(int id)
    {
        return Ok(await _servicePessoa.DeleteUser(id));
    }
}
