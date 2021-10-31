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

namespace JobOrder.Application.Features.Queries.GetLagById
{
    public class GetLagByIdHandler : IRequestHandler<GetLagByIdQuery, ServiceResponse<LagViewDto>>
    {
        readonly ILagRepository lagRepository;
        readonly IMapper mapper;

        public GetLagByIdHandler(ILagRepository lagRepository, IMapper mapper)
        {
            this.lagRepository = lagRepository;
            this.mapper = mapper;

        }
        public async Task<ServiceResponse<LagViewDto>> Handle(GetLagByIdQuery request, CancellationToken cancellationToken)
        {
            var lag = await lagRepository.GetByIdAsync(request.Id);
            var dto = mapper.Map<LagViewDto>(lag);
            return new ServiceResponse<LagViewDto>(dto);
        }
    }
}
