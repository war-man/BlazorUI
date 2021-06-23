using BlazorUI.Data;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorUI.Service
{
    public interface IValueGridService
    {
        Task<List<DataExample>> GetListData();
    }
}
