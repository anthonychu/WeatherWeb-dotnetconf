namespace WeatherWeb
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public string? Emoji
        {
            get
            {
                switch (Summary)
                {
                    case "Freezing":
                        return "🥶";
                    case "Bracing":
                        return "🧊";
                    case "Chilly":
                        return "⛄";
                    case "Balmy":
                        return "🍂";
                    case "Mild":
                        return "😐";
                    case "Warm":
                        return "😊";
                    case "Cool":
                        return "🆒";
                    case "Hot":
                        return "🔥";
                    case "Sweltering":
                        return "🥵";
                    case "Scorching":
                        return "🫠";
                    default:
                        return "🤔";
                }
            }
        }
    }
}