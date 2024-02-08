using DataTemplator.Application.ProcessData;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DataTemplator.Api.Controllers
{
    [ApiController]
    [Route("api/data")]
    public class DataController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DataController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<ProcessDataCommandResponse>> ProcessData([FromBody] ProcessDataCommand processDataCommand, CancellationToken cancellationToken)
        {          
            var response = await _mediator.Send(processDataCommand, cancellationToken);        
            return Ok(response);
        }
    }
}
