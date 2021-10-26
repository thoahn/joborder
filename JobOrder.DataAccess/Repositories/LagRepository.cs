using JobOrder.Application.Interfaces;
using JobOrder.Core.Entities;
using JobOrder.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOrder.DataAccess.Repositories
{
    public class LagRepository : GenericRepository<Lag>, ILagRepository
    {
        public LagRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
