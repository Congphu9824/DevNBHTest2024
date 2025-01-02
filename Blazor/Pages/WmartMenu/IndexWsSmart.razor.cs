using System.Text.Json;
using Blazor.Services;
using Data.DTO;
using Data.Model;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using static System.Net.WebRequestMethods;

namespace Blazor.Pages.WmartMenu
{
    public partial class IndexWsSmart
    {
        [Inject] private IServiceAll IServiceAll { get; set; }

        private List<WsmartMenu> GridData { get; set; } = new List<WsmartMenu>();
        private WsmartMenu WSmartMenu = new WsmartMenu();
        SfGrid<WsmartMenu> GridRef;

        //protected override async Task OnInitializedAsync()
        //{
        //    GridData = await IServiceAll.GetSmartMenus();
        //}

        public async Task OnActionBeginHandler(ActionEventArgs<WsmartMenu> args)
        {
            if (args.Action == "Add")
            {
                var jsondata = JsonSerializer.Serialize(args.Data);
                var response = new ResponseContext()
                {
                    EntityType = "WsmartMenu",
                    JsonData = jsondata
                };
                var result = await IServiceAll.CreateWsSmartData(response);
                if (result)
                {
                    await GridRef.Refresh();
                }
            }
            else if (args.Action == "Edit")
            {
                var jsondata = JsonSerializer.Serialize(args.Data);
                var response = new ResponseContext()
                {
                    EntityType = "WsmartMenu",
                    JsonData = jsondata
                };
                var result = await IServiceAll.updateWsSmartData(response); 
                if (result == true)
                {
                    await GridRef.Refresh();
                }
            }
            else if (args.Action == "Delete")
            {
                var DataDelete = args.Data.Id;
                if (DataDelete != null)
                {
                    var result =  IServiceAll.DeleteSmartMenu(DataDelete);
                    if(result.IsCompletedSuccessfully)
                    {
                        await GridRef.Refresh();
                    }
                }
              
            }
        }

      
    }
}
