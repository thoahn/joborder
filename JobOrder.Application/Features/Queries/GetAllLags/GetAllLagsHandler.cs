using AutoMapper;
using JobOrder.Application.Dtos;
using JobOrder.Application.Interfaces;
using JobOrder.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobOrder.Application.Features.Queries.GetAllLags
{
    public class GetAllLagsHandler : IRequestHandler<GetAllLagsQuery, ServiceResponse<List<LagViewDto>>>
    {
        private readonly ILagRepository lagRepository;
        private readonly IMapper mapper;

        public GetAllLagsHandler(IMapper mapper, ILagRepository lagRepository)
        {
            this.mapper = mapper;
            this.lagRepository = lagRepository;
        }

        public async Task<ServiceResponse<List<LagViewDto>>> Handle(GetAllLagsQuery request, CancellationToken cancellationToken)
        {
            var lags = await lagRepository.GetAllAsync();
            var viewModel = mapper.Map<List<LagViewDto>>(lags);
            return new ServiceResponse<List<LagViewDto>>(viewModel);
        }
    }
}
