using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Models
{
    public class WindFullInfo : Wind
    {
        public Speed Gust { get; set; }
    }
}
