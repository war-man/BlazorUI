using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.Data
{
    public static class DataStores
    {
        public static DataDropdown1 ValueAddSample(string data)
        {
            Random _random = new Random();
            DataDropdown1 dataDropdown1 = new DataDropdown1()
            {
                Id = _random.Next(1, 1000),
                Name = data
            };
            return dataDropdown1;
        }
        public static List<DataExample> SeedDataGridList()
        {
            List<DataExample> dataExamples = new List<DataExample>();
            for (int i = 1; i <= 50; i++)
            {
                DataExample dataExample = new DataExample(i, "text1 - " + i, "text2 - " + i, "text3 - " + i);

                dataExamples.Add(dataExample);
            }
            return dataExamples;
        }
        public static List<DataDropdown1> SeedValue1List()
        {
            var data = new List<DataDropdown1>();
            data.Add(new DataDropdown1() { Id = 1, Name = "A", disable = true });
            data.Add(new DataDropdown1() { Id = 2, Name = "B", disable = false });
            data.Add(new DataDropdown1() { Id = 1, Name = "C", disable = true });
            data.Add(new DataDropdown1() { Id = 1, Name = "D", disable = false });
            return data;
        }
        public static List<DataDropdown2> SeedValue2List()
        {
            var data = new List<DataDropdown2>();
            data.Add(new DataDropdown2() { Id = 1, Name = "Select1" });
            data.Add(new DataDropdown2() { Id = 2, Name = "Select2" });
            data.Add(new DataDropdown2() { Id = 3, Name = "Select3" });
            data.Add(new DataDropdown2() { Id = 4, Name = "Select4" });
            data.Add(new DataDropdown2() { Id = 5, Name = "Select5" });
            return data;
        }
    }
}