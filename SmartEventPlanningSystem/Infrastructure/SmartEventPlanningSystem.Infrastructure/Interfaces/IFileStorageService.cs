﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SmartEventPlanningSystem.Infrastructure.Interfaces
{
    public interface IFileStorageService
    {
        Task<string> UploadImage(IFormFile image);

    }
}
