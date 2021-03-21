using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeerApp
{
    public class Data
    {
        // Variables.
        private static Liveweer _weerData;
        private static string _json;

        /// <summary>
        /// Gets the requested data from the API.
        /// </summary>
        /// <param name="location">The requested location.</param>
        /// <param name="checkboxArray">A checkbox array containing returnable values; returns if checked by user.</param>
        /// <param name="json">String containing all data received from the API or a previously saved JSON file.</param>
        /// <returns>String containing the requested data.</returns>
        public static string LoadData(string location, CheckBox[] checkboxArray, string json = "")
        {
            if (json == String.Empty)
            {
                string link = $"https://weerlive.nl/api/json-data-10min.php?key=994540e0ad&locatie={location}";
                WebClient client = new WebClient();
                String content = client.DownloadString(link);
                _weerData = JsonConvert.DeserializeObject<Root>(content).liveweer[0];
            }
            else
            {
                _weerData = JsonConvert.DeserializeObject<Liveweer>(json);
            }

            string verw = "verwachting: " + _weerData.verw + "\n";
            string temp = "teperatuur: " + _weerData.temp + "°C\ngemiddelde teperatuur: " + _weerData.gtemp + "°C\n";
            string neerslag = "neerslag: " + _weerData.d0neerslag + "%\n";
            string wind = "windsnelheid: " + _weerData.windms + " m/s\nwindrichting: " + _weerData.d0windr + "\n";
            string lucht = "luchtdruk: " + _weerData.luchtd + " hPa\nzicht: " + _weerData.zicht + " km\n";
            string zon = "zon: " + _weerData.d0zon + "%\nzonsopkomst: " + _weerData.sup + "\nzonsondergang: " + _weerData.sunder + "\n";
            string result = verw + "\n";
            
            string[] stringArray = { temp, neerslag, wind, lucht, zon };

            for (int i = 0; i < 5; i++)
            {
                if (checkboxArray[i].Checked)
                {
                    result += stringArray[i] + "\n";
                }
            }
            
            return result;
        }

        // Converts to JSON.
        public static string ConvertJson()
        {
            _json = JsonConvert.SerializeObject(_weerData, Formatting.Indented);
            return _json;
        }

        // Returns location.
        public static string GetLocation()
        {
            return _weerData.plaats;
        }
    }
}