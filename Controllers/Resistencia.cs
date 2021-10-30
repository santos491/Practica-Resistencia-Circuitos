using Microsoft.AspNetCore.Mvc;
using ResistenciaBasica.Domain;

namespace ResistenciaBasica.Controllers
{
    [Route("api/[controller]")]
    public class ResistenciaController : ControllerBase
    {
        [HttpGet]
        [Route("{operacion}/{Color1}/{valor1}/{Color2}/{valor2}/{Color3}/{valor3}")]
        public IActionResult EjecutarCalculo(string operacion, string Color1, string Color2, string Color3,double valor1,double valor2,double valor3)
        {
        ICalcularColor  calcularColor = CreateOperation(operacion);
            
            
            calcularColor.Calcular(Color1, Color2, Color3,valor1, valor2, valor3);
            var resultado = calcularColor.RetornarResultado();
            return Ok(resultado);
        }
        private ICalcularColor CreateOperation(string operacion)
        {
            ICalcularColor calcularColor = null;
             switch(operacion)
            {
                case "CircuitoBasico":
                return calcularColor = new CircuitoBasico();        
            }
            return null;
        }
    }
}