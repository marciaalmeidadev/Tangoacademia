using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using TangoacademiaAPI.enties;

namespace TangoacademiaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        [HttpPost(Name = "CreateAluno")]
    public Aluno CreateAluno(Aluno alunoObject)
        {


            return alunoObject; 

        }
    }

    }
