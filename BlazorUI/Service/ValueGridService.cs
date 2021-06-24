/************************************************************************/
/* All Rights Reserved. Copyright (C) ソリマチ株式会社                     */
/************************************************************************/
/* File Name    : ValueGridService.cs                                      */
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
    /// ValueGridService Class
    /// </summary>
    public class ValueGridService : IValueGridService
    {
        /// <summary>
        /// GetListData Method.
        /// </summary>
        public async Task<List<DataExample>> GetListData()
        {
            List<DataExample> someValues = DataStores.SeedDataGridList();
            return await Task.FromResult(someValues);
        }
    }
}
