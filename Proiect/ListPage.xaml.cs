using Proiect.Models;

namespace Proiect;

public partial class ListPage : ContentPage
{
    public ListPage()
    {
        InitializeComponent();
    }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (ShoppingList)BindingContext;
        slist.Date = DateTime.UtcNow;
        Shop selectedShop = (ShopPicker.SelectedItem as Shop);
        slist.ShopID = selectedShop.ID;
        await App.Database.SaveShopListAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (ShoppingList)BindingContext;
        await App.Database.DeleteShopListAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnChooseButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProductPage((ShoppingList)
       this.BindingContext)
        {
            BindingContext = new Product()
        });

    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        var items = await App.Database.GetShopsAsync();
        ShopPicker.ItemsSource = (System.Collections.IList)items;
        ShopPicker.ItemDisplayBinding = new Binding("ShopDetails");

        var shopl = (ShoppingList)BindingContext;
        listView.ItemsSource = await App.Database.GetListProductsAsync(shopl.ID);
    }
    async void OnDeleteItemButtonClicked(object sender, EventArgs e)
    {
        Product p;
        if (listView.SelectedItem != null)
        {
            p = listView.SelectedItem as Product;
            await App.Database.DeleteProductAsync(p);
            await Navigation.PopAsync();
        }
    }
}