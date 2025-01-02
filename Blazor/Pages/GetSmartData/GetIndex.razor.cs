using Blazor.Services;
using Data.Model;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using static System.Net.WebRequestMethods;

namespace Blazor.Pages.GetSmartData
{   
    public partial class GetIndex
    {
        [Inject] private IServiceAll IServiceAll { get; set; }

        private List<SmartData> GridData { get; set; } = new List<SmartData>();
        private SmartData SmartDatas = new SmartData();
        SfGrid<SmartData> SfGrid;

 
        protected override async Task OnInitializedAsync()
        {
            GridData = await IServiceAll.GetSmartData();

        }

    }
}
