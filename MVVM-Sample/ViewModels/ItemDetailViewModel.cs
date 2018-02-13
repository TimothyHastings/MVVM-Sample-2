using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace MVVMSample
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;

            // TH: Update message handler
            MessagingCenter.Subscribe<ItemDetailPage>(this, "UpdateItem", (sender) =>
            {
                UpdateDataStore();
            });

            // TH: Delete message handler
            MessagingCenter.Subscribe<ItemDetailPage>(this, "DeleteItem", (sender) =>
            {
                DeleteDataStore();
            });
        }

        // TH: Update Asynchronously
        async void UpdateDataStore()
        {
            await DataStore.UpdateItemAsync(Item);
        }

        // TH: Delete Asynchronously
        async void DeleteDataStore()
        {
            await DataStore.DeleteItemAsync(Item.Id);
        }
    }
}
