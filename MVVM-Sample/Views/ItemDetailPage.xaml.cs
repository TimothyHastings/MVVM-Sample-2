using System;

using Xamarin.Forms;

namespace MVVMSample
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
        public Item Item { get; set; }

        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        // TH: Update Button Handler
        public async void UpdateClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "UpdateItem");
            await Navigation.PopToRootAsync();
        }

        // TH: Delete Button Handler
        public async void DeleteClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "DeleteItem");
            await Navigation.PopToRootAsync();
        }
    }
}
