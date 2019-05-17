﻿using MicroService.ApiGateway.Ocelot.Dto;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MicroService.ApiGateway.Ocelot
{
    public interface IGlobalConfigurationAppService : IApplicationService
    {
        Task<GlobalConfigurationDto> GetAsync();
    }
}
