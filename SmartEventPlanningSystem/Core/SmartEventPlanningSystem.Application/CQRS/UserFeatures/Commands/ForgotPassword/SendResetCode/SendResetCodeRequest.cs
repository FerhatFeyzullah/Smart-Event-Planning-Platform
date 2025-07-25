﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace SmartEventPlanningSystem.Application.CQRS.UserFeatures.Commands.ForgotPassword.SendResetCode
{
    public class SendResetCodeRequest:IRequest<string>
    {
        public string Email { get; set; }
    }
}
