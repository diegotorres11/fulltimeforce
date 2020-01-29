using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fulltimeforce.API.Abstract;
using Fulltimeforce.API.Infrastructure;
using Fulltimeforce.API.Mapping;
using Fulltimeforce.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fulltimeforce.API.Controllers
{
    [Produces("application/json")]
    [Route("api/grades")]
    public class GradeController : Controller
    {
        IGradeRepository _repository;

        public GradeController(IGradeRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult CalculateStatistics(int[] grades)
        {
            var calculator = new StudentGradeCalculator();
            GradeResult result = calculator.Calculate(grades);
            Grade grade = GradeMapper.Map(result, grades);

            _repository.Add(grade);

            return Ok(result);
        }
    }
}