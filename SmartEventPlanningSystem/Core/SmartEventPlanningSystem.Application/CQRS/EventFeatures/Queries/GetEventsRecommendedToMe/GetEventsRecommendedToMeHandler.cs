﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmartEventPlanningSystem.Application.Services;

namespace SmartEventPlanningSystem.Application.CQRS.EventFeatures.Queries.GetEventsRecommendedToMe
{
    public class GetEventsRecommendedToMeHandler(IEventService eventService) : IRequestHandler<GetEventsRecommendedToMeRequest, GetEventsRecommendedToMeResponse>
    {
        public async Task<GetEventsRecommendedToMeResponse> Handle(GetEventsRecommendedToMeRequest request, CancellationToken cancellationToken)
        {
            return await eventService.GetEventsRecommendedToMe(request.AppUserId, cancellationToken);
        }
    }
}
