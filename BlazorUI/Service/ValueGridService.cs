using BlazorUI.Data;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.Service
{
    public class ValueGridService : IValueGridService
    {
        public async Task<List<DataExample>> GetListData()
        {
            List<DataExample> someValues = DataStores.SeedDataGridList();
            return await Task.FromResult(someValues);
        }
    }
}
