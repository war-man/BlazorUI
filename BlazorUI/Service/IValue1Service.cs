/************************************************************************/
/* All Rights Reserved. Copyright (C) ソリマチ株式会社                 */
/************************************************************************/
/* File Name    : IValue1Service.cs                                        */
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
    /// IValue1Service Interface
    /// </summary>
    public interface IValue1Service
    {
        /// <summary>
        /// GetDropdown1Data Interface Method
        /// </summary>
        Task<List<DataDropdown1>> GetDropdown1Data();

        /// <summary>
        /// GetSampleDataRandom Interface Method
        /// </summary>
        DataDropdown1 GetSampleDataRandom(string data);
    }
}
