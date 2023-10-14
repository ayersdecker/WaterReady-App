using Microsoft.Maui.Controls;
using Newtonsoft.Json;
using WaterReady.Models;

namespace WaterReady.Views;

public partial class ForecastPage : ContentPage
{
	public ForecastPage(MainPageLocationModel location)
	{
		InitializeComponent();
		LocationName.Text = location.Name;
		LocationCoor.Text = location.Coordinate.ToString();
		OnGetForecast(location.Coordinate.longitude, location.Coordinate.latitude);
	}

	public async void OnGetForecast(double lon, double lat)
	{
        dynamic query = await FetchURLToJson($"https://api.weather.gov/points/{lon},{lat}");
        string forecastUrl = query.properties.forecast;
        dynamic forecast = await FetchURLToJson(forecastUrl);
        
        string forecastText = forecast.properties.periods[0].detailedForecast;
        AirTempField.Text = forecast.properties.periods[0].temperature + " F";
        string humidity = forecast.properties.periods[0].relativeHumidity + "%";
        WindVelocityField.Text = forecast.properties.periods[0].windSpeed;
        WindDirectionField.Text = forecast.properties.periods[0].windDirection;

        dynamic waveheight = await FetchURLToJson($"https://www.meteosource.com/api/v1/free/map?min_lat={lat}&min_lon={lon}&max_lat={lat+1}&max_lon={lon+1}&variable=precipitation&datetime=+12hours&key=iwbqxrbwsgwsm8f5dsuy08ukk6jq28v63rl0c4cr");


        string o = "k";




    }
    public async Task<dynamic> FetchURLToJson(string url)
    {
        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
        client.DefaultRequestHeaders.Add("User-Agent", "WaterReady");
        client.DefaultRequestHeaders.Add("Accept", "application/json");
        HttpResponseMessage response = await client.GetAsync(url);
        //response.EnsureSuccessStatusCode();
        string content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<dynamic>(content);
    }
}