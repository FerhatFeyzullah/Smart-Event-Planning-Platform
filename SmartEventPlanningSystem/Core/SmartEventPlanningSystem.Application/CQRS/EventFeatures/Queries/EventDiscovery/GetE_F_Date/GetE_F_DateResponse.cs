﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartEventPlanningSystem.Application.DTOs.EventDtos;

namespace SmartEventPlanningSystem.Application.CQRS.EventFeatures.Queries.EventDiscovery.GetE_F_Date
{
    public class GetE_F_DateResponse
    {
        public List<EventsDiscoveryDto> Events { get; set; }

    }
}
