/************************************************************************/
/* All Rights Reserved. Copyright (C) ソリマチ株式会社                 */
/************************************************************************/
/* File Name    : IValueGridService.cs                                        */
/* Function     : 部門修正処理クラス                                    */
/* System Name  : Webマネジメントシステム                             */
/* Create       : DucKhoi 2021/06/23                               */
/* Comment      :                                                       */
/************************************************************************/
namespace BlazorUI.Service
{
    using BlazorUI.Data;

    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="IValueGridService" />.
    /// </summary>
    public interface IValueGridService
    {
        /// <summary>
        /// The GetListData.
        /// </summary>
        /// <returns>The <see cref="Task{List{DataExample}}"/>.</returns>
        Task<List<DataExample>> GetListData();
    }
}
