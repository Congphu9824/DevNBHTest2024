using System.Text.Json;
using Data.DTO;
using Data.Model;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Grids.Internal;
using WebAssembly.Services;

namespace WebAssembly.Pages.SmartForm
{
    public partial class IndexSmart
    {
        [Inject] private IServiceAll IServiceAll { get; set; }

        private List<SmartDatum> GridData { get; set; } = new List<SmartDatum>();
        private SmartDatum SmartDatas = new SmartDatum();
        SfGrid<SmartDatum> SfGrid;


        protected override async Task OnInitializedAsync()
        {
            GridData = await IServiceAll.GetSmartData();

        }

        public async Task OnActionBeginHandler(ActionEventArgs<SmartDatum> args)
        {
            if (args.Action == "Add")
            {
                var jsondata = JsonSerializer.Serialize(args.Data);
                var response = new ResponseContext()
                {
                    EntityType = "SmartDatum",
                    JsonData = jsondata
                };
                var result = await IServiceAll.CreateData(response);
                if (result)
                {
                    await SfGrid.Refresh();
                }
            }
            else if (args.Action == "Edit")
            {
                var jsondata = JsonSerializer.Serialize(args.Data);
                var response = new ResponseContext()
                {
                    EntityType = "SmartDatum",
                    JsonData = jsondata
                };
                var result = await IServiceAll.updateWsSmartData(response);
                if (result == true)
                {
                    await SfGrid.Refresh();
                }
            }
            else if (args.Action == "Delete")
            {
                var DataDelete = args.Data.Id;
                if (DataDelete != null)
                {
                    await IServiceAll.DeleteSmartData(DataDelete);
                }

            }

        }
       
    }
}
