using AutoMapper;
using JobOrder.Application.Interfaces;
using JobOrder.Application.Wrappers;
using JobOrder.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobOrder.Application.Features.Commands.CreateLag
{
    public class CreateLagHandler : IRequestHandler<CreateLagCommand, ServiceResponse<int>>
    {
        ILagRepository lagRepository;
        private readonly IMapper mapper;

        public CreateLagHandler(ILagRepository lagRepository, IMapper mapper)
        {
            this.lagRepository = lagRepository;
            this.mapper = mapper;

        }
        public async Task<ServiceResponse<int>> Handle(CreateLagCommand request, CancellationToken cancellationToken)
        {
            var lag = mapper.Map<Lag>(request);
            await lagRepository.AddAsync(lag);

            return new ServiceResponse<int>(lag.Id);
        }
    }
}
