/************************************************************************/
/* All Rights Reserved. Copyright (C) ソリマチ株式会社                 */
/************************************************************************/
/* File Name    : Value1Service.cs                                        */
/* Function     : 部門修正処理クラス                                    */
/* System Name  : Webマネジメントシステム                             */
/* Create       : DucKhoi 2021/06/22                               */
/* Comment      :                                                       */
/************************************************************************/

namespace BlazorUI.Service
{
    using BlazorUI.Data;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Value1Service Class.
    /// </summary>
    public class Value1Service : IValue1Service
    {
        /// <summary>
        /// GetDropdown1Data Method.
        /// </summary>
        public async Task<List<DataDropdown1>> GetDropdown1Data()
        {
            List<DataDropdown1> dataDropdown1s = DataStores.SeedValue1List();
            return await Task.FromResult(dataDropdown1s);
        }

        /// <summary>
        /// GetSampleDataRandom Method.
        /// </summary>
        /// <param name="data">data</param>
        /// <returns>Get value random Id</returns>
        public DataDropdown1 GetSampleDataRandom(string data)
        {
            return DataStores.ValueAddSample(data);
        }
    }
}
