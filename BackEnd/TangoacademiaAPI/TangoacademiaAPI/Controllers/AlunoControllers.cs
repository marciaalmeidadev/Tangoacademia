using Microsoft.AspNetCore.Mvc;
using TangoacademiaAPI.enties;

namespace TangoacademiaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
       // [HttpPost(Name = "CreateAluno")]
       // {
            //if (VariavelAluno.Idade >= 18)
            // {
            //  string mensagemretorno = "aluno menor";

            // return Ok(mensagemretorno);
            // }
            //  else
            // {
            // return Ok("Necessitaresponsavel");
            // }
            // if (VariavelAluno.peso >= 150)
            //           {
            //             string mensagemretorno = "perigo de obesidade";
            //           return Ok(mensagemretorno);
            //     }
            //   else if (VariavelAluno.peso >= 120)
            // {
            //   string mensagemretorno = "cuidado acima do peso";
            // return Ok(mensagemretorno);
            //}//
            //else
            //{
            //   string mensagemretorno = "Ok";
            // return Ok(mensagemretorno);
            //}

            //}
            //}
      //  }

        [HttpPost(Name = "CreateAluno")]
       public ActionResult CreateplanoAluno (Aluno VariavelAluno)
        {
            string mensagemvalidaretorno;
            //if (VariavelAluno.Idade >= 18)
            // {
            //  string mensagemretorno = "aluno menor";

            // return Ok(mensagemretorno);
            // }
            //  else
            // {
            // return Ok("Necessitaresponsavel");
            // }
            if (VariavelAluno.plus == "verdedeiro")
            {
                mensagemvalidaretorno = "voce é um aluno que me traz alegria";
            }
            else if (VariavelAluno.premiumplus == "verdadeiro")
            {
                mensagemvalidaretorno = "voce é um aluno que me traz muita alegria";
            }
            else
            {
                mensagemvalidaretorno = "voce é alegria em pessoa";
            }

            return Ok(mensagemvalidaretorno);
        }
    }
}
