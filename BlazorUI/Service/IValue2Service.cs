using BlazorUI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.Service
{
    interface IValue2Service
    {
        Task<List<DataDropdown2>> GetDropdown2Data();
    }
}
