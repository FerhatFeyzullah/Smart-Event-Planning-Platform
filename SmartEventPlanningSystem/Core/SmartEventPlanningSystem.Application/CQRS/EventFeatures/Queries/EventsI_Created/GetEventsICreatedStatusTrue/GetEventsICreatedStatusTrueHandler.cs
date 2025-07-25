﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmartEventPlanningSystem.Application.Services;

namespace SmartEventPlanningSystem.Application.CQRS.EventFeatures.Queries.EventsI_Created.GetEventsICreatedStatusTrue
{
    public class GetEventsICreatedStatusTrueHandler(IEventService eventService) : IRequestHandler<GetEventsICreatedStatusTrueRequest, GetEventsICreatedStatusTrueResponse>
    {
        public async Task<GetEventsICreatedStatusTrueResponse> Handle(GetEventsICreatedStatusTrueRequest request, CancellationToken cancellationToken)
        {
            return await eventService.GetEventsI_CreatedStatusTrue(request.AppUserId, cancellationToken);
        }
    }
}
