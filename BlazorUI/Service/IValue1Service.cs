using BlazorUI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.Service
{
    public interface IValue1Service
    {
        Task<List<DataDropdown1>> GetDropdown1Data();
        DataDropdown1 GetSampleDataRandom(string data);
    }
}
