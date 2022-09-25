using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public interface IZonesRepository : IGenericRepository<Zone>
    {
        Zone GetMostRecentCategory();
    }
}
