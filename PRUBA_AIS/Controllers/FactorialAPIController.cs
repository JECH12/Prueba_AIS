using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace PRUBA_AIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactorialAPIController : ControllerBase
    {
        private readonly IFactorial _factorial;
        private readonly IOrder _order;

        public FactorialAPIController(IFactorial factorial, IOrder order)
        {
            _factorial = factorial;
            _order = order;
        }

        [HttpGet("{number:int}")]
        public IActionResult GetFactorial(int number)
        {
            if (number == 0)
            {
                return BadRequest("El numero ingresado debe ser un numero positivo.");
            }

            long factorial = _factorial.GetFactorial(number);
            return Ok(new
            {
                Number = number,
                Factorial = factorial
            });
        }

        [HttpPost("OrderNumbers")]
        public IActionResult GetOrder([FromBody] int[] numeros)
        {
            if (numeros == null || numeros.Length != 5)
            {
                return BadRequest("Debes proporcionar exactamente 5 números.");
            }

            // Ordenar los números usando el algoritmo de burbuja
            int[] numerosOrdenados = _order.GetOrdererNumbers(numeros);

            return Ok(new
            {
                Original = numeros,
                Ordenado = numerosOrdenados
            });
        }
    }
}
