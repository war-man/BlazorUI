/***********************************************************************/
/* All Rights Reserved. Copyright (C) ソリマチ株式会社                 */
/***********************************************************************/
/* File Name    : Stores.Datalist.cs                                        */
/* Function     : DataStores                                          */
/* System Name  : Webマネジメントシステム                                */
/* Create       : DucKhoi 2021/06/23                                    */
/* Comment      :                                                      */
/***********************************************************************/
namespace BlazorUI.Data
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// DataStores Class
    /// </summary>
    public static class DataStores
    {
        /// <summary>
        /// Template Datadropdown with random value
        /// </summary>
        /// <param name="data">Name of value</param>
        /// <returns>DataDropdown1</returns>
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

        /// <summary>
        /// Seed value List DataExample to Datagrid
        /// </summary>
        /// <returns>List<DataExample></returns>
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

        /// <summary>
        /// Seed value List DataDropdown1 to Dropdown1
        /// </summary>
        /// <returns>List<DataDropdown1></returns>
        public static List<DataDropdown1> SeedValue1List()
        {
            var data = new List<DataDropdown1>();
            data.Add(new DataDropdown1() { Id = 1, Name = "A" });
            data.Add(new DataDropdown1() { Id = 2, Name = "B" });
            data.Add(new DataDropdown1() { Id = 1, Name = "C" });
            data.Add(new DataDropdown1() { Id = 1, Name = "D" });
            return data;
        }

        /// <summary>
        /// Seed value List DataDropdown2 to Dropdown2
        /// </summary>
        /// <returns>List<DataDropdown2></returns>
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
