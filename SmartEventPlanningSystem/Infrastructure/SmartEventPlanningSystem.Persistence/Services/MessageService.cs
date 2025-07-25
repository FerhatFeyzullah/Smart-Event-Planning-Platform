﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmartEventPlanningSystem.Application.CQRS.MessageFeatures.Commands.CreateMessage;
using SmartEventPlanningSystem.Application.CQRS.MessageFeatures.Queries.GetMessagesForEvent;
using SmartEventPlanningSystem.Application.DTOs.EventDtos;
using SmartEventPlanningSystem.Application.DTOs.MessageDto;
using SmartEventPlanningSystem.Application.Services;
using SmartEventPlanningSystem.Application.UnitOfWorks;
using SmartEventPlanningSystem.Domain.Entities;

namespace SmartEventPlanningSystem.Persistence.Services
{
    public class MessageService(IUnitOfWork unitOfWork,IMapper mapper) : IMessageService
    {
       

        public async Task SendMessage(CreateMessageDto createMessageDto, CancellationToken ct)
        {
            var message = mapper.Map<Message>(createMessageDto);
            message.SendingTime = DateTime.UtcNow;

            await unitOfWork.WriteRepository<Message>().AddAsync(message, ct);
            await unitOfWork.CommitAsync();
        }

        public async Task<GetMessagesForEventResponse> GetMessagesForEvent(int eventId, CancellationToken ct)
        {
            var messages = await unitOfWork.ReadRepository<Message>().GetByFilteredList(
                x =>
                x.EventId == eventId, ct,
                x => x.AppUser
                );

            var orderedMessages = messages.OrderBy(x => x.SendingTime).ToList();

            var Event = await unitOfWork.ReadRepository<Event>().GetByIdAsync(eventId, ct);

            return new GetMessagesForEventResponse
            {
                Messages = mapper.Map<List<ResultMessagesDto>>(orderedMessages),
                Event = mapper.Map<EventForMessageDto>(Event)
            };
        }

    }
}
