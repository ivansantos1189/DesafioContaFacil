using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ContaFacil.API.Controllers
{
    [ApiController]
    public abstract class MainController : Controller
    {
        protected ICollection<string> Errors = new List<string>();

        protected ActionResult CustomResponse(object result = null)
        {
            if (Validate())
            {
                return Ok(result);
            }

            return BadRequest(new ValidationProblemDetails(new Dictionary<string, string[]>
            {
                { "Messages", Errors.ToArray() }
            }));
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);
            foreach (var erro in erros)
            {
                AddError(erro.ErrorMessage);
            }

            return CustomResponse();
        }

        protected bool Validate()
        {
            return !Errors.Any();
        }

        protected void AddError(string erro)
        {
            Errors.Add(erro);
        }

        protected void ClearErrors()
        {
            Errors.Clear();
        }
    }
}