
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Task_Manager.Domain;
using Task_Manager.Domain.Interfaces;
using Task_Manager.Services;

namespace Task_Manager.Services
{
    public class ProviderDbContext : IProviderDbContext
    {
        private readonly AppDbContext appDbContext;
        public ProviderDbContext(AppDbContext appDbContext)
        {

            this.appDbContext = appDbContext;
        }

        public AppDbContext GetDbContext()
        {
            return this.appDbContext;
        }
    }
}