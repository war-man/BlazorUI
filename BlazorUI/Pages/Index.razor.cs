namespace BlazorUI.Pages
{
    using BlazorUI.Data;
    using BlazorUI.Service;

    using Microsoft.AspNetCore.Components;

    using Radzen.Blazor;

    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Index Class
    /// </summary>
    public partial class Index : ComponentBase
    {
        /// <summary>
        /// Gets or sets the valueGridService.
        /// </summary>
        [Inject]
        private IValueGridService valueGridService { get; set; }

        /// <summary>
        /// Gets or sets the value1Service.
        /// </summary>
        [Inject]
        private IValue1Service value1Service { get; set; }

        /// <summary>
        /// Gets or sets the value2Service.
        /// </summary>
        [Inject]
        private IValue2Service value2Service { get; set; }

        /// <summary>
        /// Defines the grid DataExample.
        /// </summary>
        internal RadzenDataGrid<DataExample> grid;

        /// <summary>
        /// Defines the IsDisabled (Using Dropdown2 Disable).
        /// </summary>
        protected bool IsDisabled { get; set; }

        /// <summary>
        /// Defines the IsConfirmDelete (Using Modal Delete).
        /// </summary>
        internal bool IsConfirmDelete { get; set; } = false;

        /// <summary>
        /// Defines the IsEditModal (Using Modal Edit).
        /// </summary>
        internal bool IsEditModal { get; set; } = false;

        /// <summary>
        /// Defines the SelectedDataExample.
        /// </summary>
        internal DataExample SelectedDataExample;

        /// <summary>
        /// Gets or sets the inputValueAddToDropdown1 (TextBox).
        /// </summary>
        protected string inputValueAddToDropdown1 { get; set; } = String.Empty;

        /// <summary>
        /// Grid Data
        /// </summary>
        internal List<DataExample> dataExamples = new List<DataExample>();

        /// <summary>
        /// Dropdown1 Data
        /// </summary>
        internal List<DataDropdown1> dataDropdown1s = new List<DataDropdown1>();

        /// <summary>
        /// Dropdown2 Data
        /// </summary>
        internal List<DataDropdown2> dataDropdown2s = new List<DataDropdown2>();

        /// <summary>
        /// Defines the currentChoice (Selection Value RadioButton).
        /// </summary>
        internal string currentChoice = String.Empty;

        /// <summary>
        /// Null Contructor
        /// </summary>
        public Index()
        {
            Console.WriteLine("Index start");
        }
        /// <summary>
        /// Initialize
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            Console.WriteLine("Index.OnInitialized() start");

            //DataGrid Data
            await GetAllDataExamplesAsync();
            // DataDropDown1 Data
            await GetAllDataDropdown1sAsync();
            // DataDropDown2 Data
            await GetAllDataDropdown2sAsync();

            Console.WriteLine("Index.OnInitialized() end");
        }
        /// <summary>
        /// Event When Dropdown1 changed
        /// </summary>
        /// <param name="e">The e<see cref="ChangeEventArgs"/>.</param>
        internal void Dropdown1Changed(ChangeEventArgs e)
        {
            Console.WriteLine("Event Change Dropdown 1 Excuted");
            Console.WriteLine(value: $"Current value is {e.Value}");
            IsDisabled = !e.Value.Equals("B") && !e.Value.Equals("D");
        }

        /// <summary>
        /// Event When Dropdown2 changed
        /// </summary>
        /// <param name="e">The e<see cref="ChangeEventArgs"/>.</param>
        internal void Dropdown2Changed(ChangeEventArgs e)
        {
            Console.WriteLine("Event Change Dropdown 2 Excuted");
            Console.WriteLine(value: $"Current value is {e.Value}");
            currentChoice = e.Value.ToString();
        }
        /// <summary>
        /// Event when Radio changed
        /// </summary>
        /// <param name="e">The e<see cref="ChangeEventArgs"/>.</param>
        internal void RadioSelection(ChangeEventArgs args)
        {
            currentChoice = args.Value.ToString();
        }
        /// <summary>
        /// Press the button Add Near by TextBox To Add Value to Dropdown1
        /// </summary>
        internal void AddToDropDown1()
        {
            Console.WriteLine("Index.BtnAdd() start");
            Console.WriteLine("Event Add to Dropdown1 Excuted");
            Console.WriteLine($"Value Text: {inputValueAddToDropdown1}");
            dataDropdown1s.Add(value1Service.GetSampleDataRandom(inputValueAddToDropdown1));
            inputValueAddToDropdown1 = String.Empty;
            StateHasChanged();
            Console.WriteLine("Index.BtnAdd() Exit");
        }

        /// <summary>
        /// Press the button No to Cancel Modal Confrim
        /// </summary>
        internal void No() => ShowHideConfirmDelte();

        /// <summary>
        /// Press the button No to Cancel Modal Edit.
        /// </summary>
        internal void NoEdit() => ShowHideOpenEditForm();

        /// <summary>
        /// Press the button Delete to Open Confirm Modal
        /// </summary>
        /// <param name="data">The data<see cref="DataExample"/>.</param>
        internal void DeleteGrid(DataExample data)
        {
            Console.WriteLine("Index.BtnDelete() start");
            SelectedDataExample = data;
            ShowHideConfirmDelte();
            Console.WriteLine(SelectedDataExample.Id);
            StateHasChanged();
            Console.WriteLine("Index.BtnDelete() exit");
        }
        /// <summary>
        /// Press the button Edit to Open Edit Modal
        /// </summary>
        /// <param name="data">The data<see cref="DataExample"/>.</param>
        internal void EditGrid(DataExample data)
        {
            Console.WriteLine("Index.BtnEdit() start");

            SelectedDataExample = data;
            ShowHideOpenEditForm();
            Console.WriteLine(SelectedDataExample.Id);
            StateHasChanged();

            Console.WriteLine("Index.BtnEdit() start");
        }

        /// <summary>
        /// Press the button Yes to Delete Data
        /// </summary>
        internal void SubmitDelete()
        {
            Console.WriteLine($"Event delete {SelectedDataExample.Id} Started .....");
            dataExamples.Remove(SelectedDataExample);
            grid.Reset(true);
            ShowHideConfirmDelte();
            SelectedDataExample = new DataExample();
            StateHasChanged();
        }

        /// <summary>
        /// Press the button OK to Update Data
        /// </summary>
        internal void SubmitEdit()
        {
            Console.WriteLine($"Event Edit {SelectedDataExample.Id} Started .....");
            var data = dataExamples.Find(x => x.Id == SelectedDataExample.Id);
            data.text1 = SelectedDataExample.text1;
            data.text2 = SelectedDataExample.text2;
            data.text3 = SelectedDataExample.text3;
            ShowHideOpenEditForm();
            StateHasChanged();
        }

        /// <summary>
        /// Get All Data to DataGrid
        /// </summary>
        /// <returns>The <see cref="Task{List{DataExample}}"/>.</returns>
        private async Task<List<DataExample>> GetAllDataExamplesAsync()
        {
            dataExamples = await valueGridService.GetListData();
            return dataExamples;
        }

        /// <summary>
        /// Get All Data Dropdown 1
        /// </summary>
        private async Task<List<DataDropdown1>> GetAllDataDropdown1sAsync()
        {
            dataDropdown1s = await value1Service.GetDropdown1Data();
            return dataDropdown1s;
        }

        /// <summary>
        /// Get All Data Dropdown 2
        /// </summary>
        private async Task<List<DataDropdown2>> GetAllDataDropdown2sAsync()
        {
            dataDropdown2s = await value2Service.GetDropdown2Data();
            return dataDropdown2s;
        }
        /// <summary>
        /// Change State Modal Confirm
        /// </summary>
        internal void ShowHideConfirmDelte()
            => IsConfirmDelete = !IsConfirmDelete;

        /// <summary>
        /// Change State Modal Edit
        /// </summary>
        internal void ShowHideOpenEditForm()
            => IsEditModal = !IsEditModal;
    }
}
