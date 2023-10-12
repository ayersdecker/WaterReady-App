using System.Collections.ObjectModel;
using WaterReady.DataTypes;
using WaterReady.Models;
using WaterReady.Views;

namespace WaterReady
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<MainPageLocationModel> Locations = new() { 
            new MainPageLocationModel ( "Genesee River", "Genesee River Delta and Marina", new Coordinate(43.2540828,-77.6017813), "geneseeriver.jpg"),
            new MainPageLocationModel ( "Irondequoit Bay", "Bay off the edge of Lake Ontario", new Coordinate(43.1790113,-77.5714571), "ironbay.jpg"),
            new MainPageLocationModel ( "Forest Lawn", "Forest Lawn Dr leading to Lake Ontario", new Coordinate(43.2487271,-77.4996791), "forestlawn.jpg"),
            new MainPageLocationModel ( "Webster Park", "Genesee River Delta and Marina", new Coordinate(43.2609541,-77.446657), "websterpark.jpg")
            };

        public MainPage()
        {
            InitializeComponent();
            MainPageLocationCollection.ItemsSource = Locations;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var item = sender as Button;
            Navigation.PushAsync(new ForecastPage(item.BindingContext as MainPageLocationModel));
        }
    }
}