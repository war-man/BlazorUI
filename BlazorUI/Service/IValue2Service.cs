/************************************************************************/
/* All Rights Reserved. Copyright (C) ソリマチ株式会社                 */
/************************************************************************/
/* File Name    : IValue2Service.cs                                        */
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
    /// IValue2Service Interface
    /// </summary>
    interface IValue2Service
    {
        /// <summary>
        /// GetDropdown2Data Interface Method
        /// </summary>
        Task<List<DataDropdown2>> GetDropdown2Data();
    }
}
