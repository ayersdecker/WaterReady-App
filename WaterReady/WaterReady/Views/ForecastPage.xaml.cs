using WaterReady.Models;

namespace WaterReady.Views;

public partial class ForecastPage : ContentPage
{
	public ForecastPage(MainPageLocationModel location)
	{
		InitializeComponent();
		LocationName.Text = location.Name;
		LocationCoor.Text = location.Coordinate.ToString();
	}
}