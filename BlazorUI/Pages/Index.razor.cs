using BlazorUI.Data;
using BlazorUI.Service;

using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BlazorUI.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        private IValueGridService valueGridService { get; set; }
        [Inject]
        private IValue1Service value1Service { get; set; }
        [Inject]
        private IValue2Service value2Service { get; set; }

        protected bool IsDisabled { get; set; }
        private bool ShowDelete = false;
        private bool ShowEdit = false;
        protected string inputValueAddToDropdown1 { get; set; } = String.Empty;
        List<DataExample> dataExamples = new List<DataExample>();
        List<DataDropdown1> dataDropdown1s = new List<DataDropdown1>();
        List<DataDropdown2> dataDropdown2s = new List<DataDropdown2>();
        string currentChoice = String.Empty;
        void RadioSelection(ChangeEventArgs args)
        {
            currentChoice = args.Value.ToString();
        }
        private async Task<List<DataExample>> GetAllDataExamplesAsync()
        {
            dataExamples = await valueGridService.GetListData();
            return dataExamples;
        }
        private async Task<List<DataDropdown1>> GetAllDataDropdown1sAsync()
        {
            dataDropdown1s = await value1Service.GetDropdown1Data();
            return dataDropdown1s;
        }
        private async Task<List<DataDropdown2>> GetAllDataDropdown2sAsync()
        {
            dataDropdown2s = await value2Service.GetDropdown2Data();
            return dataDropdown2s;
        }
        protected override async Task OnInitializedAsync()
        {
            Console.WriteLine("OnInitializedAsync");
            await GetAllDataExamplesAsync();
            await GetAllDataDropdown1sAsync();
            await GetAllDataDropdown2sAsync();
        }
        void AddToDropDown1()
        {
            Console.WriteLine("Event Add to Dropdown1 Excuted");
            Console.WriteLine($"Value Text: {inputValueAddToDropdown1}");
            dataDropdown1s.Add(value1Service.GetSampleDataRandom(inputValueAddToDropdown1));
            inputValueAddToDropdown1 = String.Empty;
        }
        void Dropdown1Changed(ChangeEventArgs e)
        {
            Console.WriteLine("Event Change Dropdown 1 Excuted");
            Console.WriteLine(value: $"Current value is {e.Value}");
            IsDisabled = !e.Value.Equals("B") && !e.Value.Equals("D");
        }
        void Dropdown2Changed(ChangeEventArgs e)
        {
            Console.WriteLine("Event Change Dropdown 2 Excuted");
            Console.WriteLine(value: $"Current value is {e.Value}");
            currentChoice = e.Value.ToString();
        }
        void DeleteGrid(DataExample data)
        {
            int id = data.Id;
            ShowDelete = true;
            Console.WriteLine(id);
        }
        private void DeleteShow() => ShowDelete = true;
        private void DeleteCancel() => ShowDelete = false;
        void EditGrid(DataExample data)
        {
            int id = data.Id;
            string text1 = data.text1;
            string text2 = data.text2;
            string text3 = data.text3;
            Console.WriteLine($"{id}-{text1}-{text2}-{text3}");
        }
    }
}
