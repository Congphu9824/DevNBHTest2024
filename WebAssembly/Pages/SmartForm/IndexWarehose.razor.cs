using System.Text.Json;
using Data.DTO;
using Data.Model;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using WebAssembly.Services;

namespace WebAssembly.Pages.SmartForm
{
    public partial class IndexWarehose
    {
        [Parameter]
        public Guid Id { get; set; }

        [Inject] private IServiceWarehose serviceWarehose { get; set; }
        private List<CategoryWarehose> GridData { get; set; } = new List<CategoryWarehose>();
        private CategoryWarehose categoryWarehose = new CategoryWarehose();

        private  SfGrid<CategoryWarehose> SfGrid { get; set; }

        protected override async Task OnInitializedAsync()
        {
            GridData = await serviceWarehose.GetWarehose();

        }

        public async Task OnActionBeginHandler(ActionEventArgs<CategoryWarehose> args)
        {
            if(args.Action == "Delete")
            {
                var DataDelete = args.Data.Id;
                if (DataDelete != null)
                {
                   await  serviceWarehose.DeleteWarehose(DataDelete);
                 }
            }
            else if(args.Action == "Add")
            {
                var jsondata = JsonSerializer.Serialize(args.Data);
                var response = new ResponseContext()
                {
                    EntityType = "CategoryWarehose",
                    JsonData = jsondata
                };
                var result = await serviceWarehose.CreateWarehose(response);
                if (result == true)
                {
                    await SfGrid.Refresh();
                }
            }
            else if (args.Action == "Edit")
            {
                var jsondata = JsonSerializer.Serialize(args.Data);
                var response = new ResponseContext()
                {
                    EntityType = "CategoryWarehose",
                    JsonData = jsondata
                };
                var result = await serviceWarehose.updateWarehose(response);
                if (result == true)
                {
                    await SfGrid.Refresh();
                }
            }
        }
    }
}
