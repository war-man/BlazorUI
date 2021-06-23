using BlazorUI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.Service
{
    public class Value1Service : IValue1Service
    {
        public async Task<List<DataDropdown1>> GetDropdown1Data()
        {
            List<DataDropdown1> dataDropdown1s = DataStores.SeedValue1List();
            return await Task.FromResult(dataDropdown1s);
        }

        public DataDropdown1 GetSampleDataRandom(string data)
        {
            return DataStores.ValueAddSample(data);
        }
    }
}
