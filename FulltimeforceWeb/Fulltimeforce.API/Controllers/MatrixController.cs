using Fulltimeforce.Core;
using Microsoft.AspNetCore.Mvc;

namespace Fulltimeforce.API.Controllers
{
    [Produces("application/json")]
    [Route("api/matrix")]
    public class MatrixController : Controller
    {
        [HttpPost]
        public IActionResult Sum(int[,] matrixOne, int[,] matrixTwo)
        {
            string result = new MatrixWorker().SumAndPrint(matrixOne, matrixTwo);

            return Ok(result);
        }
    }
}
