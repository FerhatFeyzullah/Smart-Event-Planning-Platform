﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartEventPlanningSystem.Application.CQRS.MessageFeatures.Commands.CreateMessage;
using SmartEventPlanningSystem.Application.CQRS.MessageFeatures.Queries.GetMessagesForEvent;


namespace SmartEventPlanningSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController(IMediator mediator) : ControllerBase
    {
        [HttpPost("CreateMessage")]
        public async Task<IActionResult> CreateMessage([FromBody] CreateMessageRequest request)
        {
            return Ok(await mediator.Send(request));
        }

        [HttpGet("GetMessages")]
        public async Task<IActionResult> GetMessages([FromQuery] GetMessagesForEventRequest request)
        {
            return Ok(await mediator.Send(request));
        }
    }
}
