using System.Text.Json;
using Data.DTO;
using Data.Model;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Notifications;
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
        private SfGrid<CategoryWarehose> SfGrid { get; set; }

        private SfToast ToastObj;
        private string ToastContent { get; set; }

        protected override async Task OnInitializedAsync()
        {
            GridData = await serviceWarehose.GetWarehose();

        }
        private void ShowToast()
        {
            ToastObj.ShowAsync();
        }
        public async Task OnActionBeginHandler(ActionEventArgs<CategoryWarehose> args)
        {
            if (args.Action == "Add")
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
                    ShowToast();
                    ToastContent = "Warehouse added successfully.";
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
                    ShowToast();
                    ToastContent = "Warehouse updated successfully.";

                }
            }
            else if (args.Action == "Delete" && args.Data.Id != null)
            {
                var DataDelete = args.Data.Id;
                if (DataDelete != null)
                {
                    await serviceWarehose.DeleteWarehose(DataDelete);
                    await SfGrid.Refresh();
                    ShowToast();
                    ToastContent = "Warehouse deleted successfully";
                }
            }
        }
        public async Task ToolbarClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {
            if (args.Item.Text == "Add")
            {
                await SfGrid.AddRecordAsync();
            }
            else if (args.Item.Text == "Edit")
            {
                await SfGrid.StartEditAsync();
            }
            else if (args.Item.Text == "Delete")
            {
                await SfGrid.DeleteRecordAsync();
            }

        }
    }
}
