using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager.Domain.Interfaces
{
    public interface IProviderDbContext
    {
        AppDbContext GetDbContext();
    }
}
