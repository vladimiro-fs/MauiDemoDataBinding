namespace MauiDemoDataBinding.Pages;

using MauiDemoDataBinding.Models;

public partial class NotifyBinding : ContentPage
{
	Product product = new Product();

	public NotifyBinding()
	{
		InitializeComponent();
		product = new Product
		{
			Name = "iPhone 5",
			Price = 5000.00m,
			Stock = 5
		};

		BindingContext = product;
	}

    private async void btnUpdate_Clicked(object sender, EventArgs e)
    {
		product.Name = "Samsung Galaxy 10";
		product.Price = 6000.00m;
		product.Stock = 3;

		await DisplayAlert("Product updated", 
			$"{product.Name} - {product.Price}" +
			$"- {product.Stock}", "OK");
    }
}