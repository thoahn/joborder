using JobOrder.Core.Entities;
using JobOrder.Core.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOrder.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Lag> Lags { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            this.Add<Order>(new Order { Id = 1, OrderName = "1001", StartDate = Convert.ToDateTime("1.01.2017 08:00:00"), EndDate = Convert.ToDateTime("1.01.2017 16:00:00"), CreateDate = DateTime.Now });
            this.Add<Order>(new Order { Id = 2, OrderName = "1002", StartDate = Convert.ToDateTime("1.01.2017 16:00:00"), EndDate = Convert.ToDateTime("2.01.2017 00:00:00"), CreateDate = DateTime.Now });
            this.Add<Order>(new Order { Id = 3, OrderName = "1003", StartDate = Convert.ToDateTime("2.01.2017 00:00:00"), EndDate = Convert.ToDateTime("2.01.2017 08:00:00"), CreateDate = DateTime.Now });
            this.Add<Order>(new Order { Id = 4, OrderName = "1004", StartDate = Convert.ToDateTime("2.01.2017 08:00:00"), EndDate = Convert.ToDateTime("2.01.2017 16:00:00"), CreateDate = DateTime.Now });
            this.Add<Order>(new Order { Id = 5, OrderName = "1005", StartDate = Convert.ToDateTime("2.01.2017 16:00:00"), EndDate = Convert.ToDateTime("3.01.2017 00:00:00"), CreateDate = DateTime.Now });
            this.Add<Order>(new Order { Id = 6, OrderName = "1006", StartDate = Convert.ToDateTime("3.01.2017 00:00:00"), EndDate = Convert.ToDateTime("3.01.2017 08:00:00"), CreateDate = DateTime.Now });
            this.Add<Order>(new Order { Id = 7, OrderName = "1007", StartDate = Convert.ToDateTime("3.01.2017 08:00:00"), EndDate = Convert.ToDateTime("3.01.2017 16:00:00"), CreateDate = DateTime.Now });
            this.Add<Order>(new Order { Id = 8, OrderName = "1008", StartDate = Convert.ToDateTime("3.01.2017 16:00:00"), EndDate = Convert.ToDateTime("4.01.2017 00:00:00"), CreateDate = DateTime.Now });
            this.Add<Order>(new Order { Id = 9, OrderName = "1009", StartDate = Convert.ToDateTime("4.01.2017 00:00:00"), EndDate = Convert.ToDateTime("4.01.2017 08:00:00"), CreateDate = DateTime.Now });


            this.Add<Lag>(new Lag { Id = 1, LagReason = "Mola", StartDate = Convert.ToDateTime("1.01.2017 10:00:00"), EndDate = Convert.ToDateTime("1.01.2017 10:10:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 2, LagReason = "Arıza", StartDate = Convert.ToDateTime("1.01.2017 10:30:00"), EndDate = Convert.ToDateTime("1.01.2017 11:00:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 3, LagReason = "Mola", StartDate = Convert.ToDateTime("1.01.2017 12:00:00"), EndDate = Convert.ToDateTime("1.01.2017 12:30:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 4, LagReason = "Mola", StartDate = Convert.ToDateTime("1.01.2017 14:00:00"), EndDate = Convert.ToDateTime("1.01.2017 14:10:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 5, LagReason = "Setup", StartDate = Convert.ToDateTime("1.01.2017 15:00:00"), EndDate = Convert.ToDateTime("1.01.2017 16:30:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 6, LagReason = "Mola", StartDate = Convert.ToDateTime("1.01.2017 18:00:00"), EndDate = Convert.ToDateTime("1.01.2017 18:10:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 7, LagReason = "Mola", StartDate = Convert.ToDateTime("1.01.2017 20:00:00"), EndDate = Convert.ToDateTime("1.01.2017 20:30:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 8, LagReason = "Mola", StartDate = Convert.ToDateTime("1.01.2017 22:00:00"), EndDate = Convert.ToDateTime("1.01.2017 22:10:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 9, LagReason = "Arge", StartDate = Convert.ToDateTime("1.01.2017 23:00:00"), EndDate = Convert.ToDateTime("2.01.2017 08:30:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 10, LagReason = "Mola", StartDate = Convert.ToDateTime("2.01.2017 10:00:00"), EndDate = Convert.ToDateTime("2.01.2017 10:10:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 11, LagReason = "Mola", StartDate = Convert.ToDateTime("2.01.2017 12:00:00"), EndDate = Convert.ToDateTime("2.01.2017 12:30:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 12, LagReason = "Arıza", StartDate = Convert.ToDateTime("2.01.2017 13:00:00"), EndDate = Convert.ToDateTime("2.01.2017 13:45:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 13, LagReason = "Mola", StartDate = Convert.ToDateTime("2.01.2017 14:00:00"), EndDate = Convert.ToDateTime("2.01.2017 14:10:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 14, LagReason = "Mola", StartDate = Convert.ToDateTime("2.01.2017 18:00:00"), EndDate = Convert.ToDateTime("2.01.2017 18:10:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 15, LagReason = "Arge", StartDate = Convert.ToDateTime("2.01.2017 20:00:00"), EndDate = Convert.ToDateTime("3.01.2017 02:10:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 16, LagReason = "Mola", StartDate = Convert.ToDateTime("3.01.2017 04:00:00"), EndDate = Convert.ToDateTime("3.01.2017 04:30:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 17, LagReason = "Setup", StartDate = Convert.ToDateTime("3.01.2017 06:00:00"), EndDate = Convert.ToDateTime("3.01.2017 09:30:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 18, LagReason = "Mola", StartDate = Convert.ToDateTime("3.01.2017 10:00:00"), EndDate = Convert.ToDateTime("3.01.2017 10:10:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 19, LagReason = "Mola", StartDate = Convert.ToDateTime("3.01.2017 12:00:00"), EndDate = Convert.ToDateTime("3.01.2017 12:30:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 20, LagReason = "Mola", StartDate = Convert.ToDateTime("3.01.2017 14:00:00"), EndDate = Convert.ToDateTime("3.01.2017 14:10:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 21, LagReason = "Arıza", StartDate = Convert.ToDateTime("3.01.2017 15:00:00"), EndDate = Convert.ToDateTime("3.01.2017 18:45:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 22, LagReason = "Mola", StartDate = Convert.ToDateTime("3.01.2017 20:00:00"), EndDate = Convert.ToDateTime("3.01.2017 20:30:00"), CreateDate = DateTime.Now });
            this.Add<Lag>(new Lag { Id = 23, LagReason = "Mola", StartDate = Convert.ToDateTime("3.01.2017 22:00:00"), EndDate = Convert.ToDateTime("3.01.2017 22:10:00"), CreateDate = DateTime.Now });

            this.SaveChanges();
        }
    }
}