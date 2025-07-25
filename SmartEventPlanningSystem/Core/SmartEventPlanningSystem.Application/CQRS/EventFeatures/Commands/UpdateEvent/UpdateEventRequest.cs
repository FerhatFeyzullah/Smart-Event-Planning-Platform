﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmartEventPlanningSystem.Application.DTOs.EventDtos;

namespace SmartEventPlanningSystem.Application.CQRS.EventFeatures.Commands.UpdateEvent
{
    public class UpdateEventRequest:IRequest<UpdateEventResponse>
    {
        public UpdateEventDto EventDto { get; set; }
        public int AppUserId { get; set; }
        public List<int> EventCategories { get; set; }
    }
}
