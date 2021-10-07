using System.Collections.Generic;

namespace RestaurantAPI2
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get(int count, int min, int max);
    }
}