using Application.UseCases.CommonToDoList.Queries;
using Application.UseCases.CommonToDoList.Queries.EnumerationQueries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [AllowAnonymous]
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

        [AllowAnonymous]
        [HttpGet("enum/all")]
        public async Task<IActionResult> GetEnums()
        {
            try
            {
                return Ok(await _mediator.Send(new GetAllEnumsQuery()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [AllowAnonymous]
        [HttpGet("enum/genders")]
        public async Task<IActionResult> GetGenderEnums()
        {
            try
            {
                return Ok(await _mediator.Send(new GetGenderEnumsQuery()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [AllowAnonymous]
        [HttpGet("enum/user-roles")]
        public async Task<IActionResult> GetUserRoleEnums()
        {
            try
            {
                return Ok(await _mediator.Send(new GetUserRoleEnumsQuery()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [AllowAnonymous]
        [HttpGet("enum/employee-categories")]
        public async Task<IActionResult> GetEmployeecategoryEnums()
        {
            try
            {
                return Ok(await _mediator.Send(new GetEmployeeCategoryEnumsQuery()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [AllowAnonymous]
        [HttpGet("enum/contact-types")]
        public async Task<IActionResult> GetContactTypeEnums()
        {
            try
            {
                return Ok(await _mediator.Send(new GetContactTypeEnumsQuery()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [AllowAnonymous]
        [HttpGet("enum/post-categories")]
        public async Task<IActionResult> GetPostCategoryEnums()
        {
            try
            {
                return Ok(await _mediator.Send(new GetPostCategoryQuery()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [AllowAnonymous]
        [HttpGet("enum/week-days")]
        public async Task<IActionResult> GetWeekDaysEnums()
        {
            try
            {
                return Ok(await _mediator.Send(new GetWeekDaysEnumsQuery()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
