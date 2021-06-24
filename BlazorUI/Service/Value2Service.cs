/************************************************************************/
/* All Rights Reserved. Copyright (C) ソリマチ株式会社                     */
/************************************************************************/
/* File Name    : Value2Service.cs                                      */
/* Function     : 部門修正処理クラス                                       */
/* System Name  : Webマネジメントシステム                                  */
/* Create       : DucKhoi 2021/06/22                                    */
/* Comment      :                                                       */
/************************************************************************/

namespace BlazorUI.Service
{
    using BlazorUI.Data;

    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Value2Service Class.
    /// </summary>
    public class Value2Service : IValue2Service
    {
        /// <summary>
        /// GetDropdown2Data Method
        /// </summary>
        public async Task<List<DataDropdown2>> GetDropdown2Data()
        {
            List<DataDropdown2> dataDropdown2s = DataStores.SeedValue2List();
            return await Task.FromResult(dataDropdown2s);
        }
    }
}
