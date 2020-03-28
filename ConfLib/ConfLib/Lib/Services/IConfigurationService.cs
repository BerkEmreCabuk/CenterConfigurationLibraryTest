using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConfLib.Lib.Services
{
    public interface IConfigurationService
    {
        Task<T> GetValue<T>(string key);
    }
}
