using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    public class OperationController
    {
        [ApiController]
        [Route("Calculator/Operation")]
        public void Operate()
    }
}