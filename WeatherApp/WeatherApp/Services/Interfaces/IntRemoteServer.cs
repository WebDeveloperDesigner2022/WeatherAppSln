using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models.Service;

namespace WeatherApp.Services.Interfaces
{
    public interface IntRemoteServer
    {
        Task<Root> GetRemoteTemp();
    }
}
