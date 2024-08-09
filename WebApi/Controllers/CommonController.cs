using Application.UseCases.CommonToDoList.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> GetCommonData()
        {
            try
            {
                return Ok(await _mediator.Send(new GetCommonDataQuery()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("enum/all")]
        public async Task<IActionResult> GetEnums()
        {
            try
            {
                return Ok(await _mediator.Send(new GetAllEnumsQuery()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex);
            }
        }

        [HttpGet("enum/genders")]
        public async Task<IActionResult> GetGenderEnums()
        {
            try
            {
                return Ok(await _mediator.Send(new GetGenderEnumsQuery()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex);
            }
        }

        [HttpGet("enum/user-roles")]
        public async Task<IActionResult> GetUserRoleEnums()
        {
            try
            {
                return Ok(await _mediator.Send(new GetUserRoleEnumsQuery()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex);
            }
        }
    }
}
