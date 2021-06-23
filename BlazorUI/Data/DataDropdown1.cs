using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.Data
{
    public class DataDropdown1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool disable { get; set; } = false;

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(disable)}={disable.ToString()}}}";
        }
    }
}
