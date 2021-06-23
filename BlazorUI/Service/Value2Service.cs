using BlazorUI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.Service
{
    public class Value2Service : IValue2Service
    {
        public async Task<List<DataDropdown2>> GetDropdown2Data()
        {
            List<DataDropdown2> dataDropdown2s = DataStores.SeedValue2List();
            return await Task.FromResult(dataDropdown2s);
        }
    }
}
