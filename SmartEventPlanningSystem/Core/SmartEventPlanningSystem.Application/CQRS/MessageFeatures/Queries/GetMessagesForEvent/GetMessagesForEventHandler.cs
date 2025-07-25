﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmartEventPlanningSystem.Application.Services;

namespace SmartEventPlanningSystem.Application.CQRS.MessageFeatures.Queries.GetMessagesForEvent
{
    public class GetMessagesForEventHandler(IMessageService messageService) : IRequestHandler<GetMessagesForEventRequest, GetMessagesForEventResponse>
    {
        public async Task<GetMessagesForEventResponse> Handle(GetMessagesForEventRequest request, CancellationToken cancellationToken)
        {
            return await messageService.GetMessagesForEvent(request.EventId, cancellationToken);
        }
    }
}
