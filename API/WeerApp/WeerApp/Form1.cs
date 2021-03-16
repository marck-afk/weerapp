using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Collections;
using Microsoft.Azure.Management.Monitor.Fluent.Models;

namespace WeerApp
{
    public partial class Form1 : Form
    {
        public string Path = @"C:\Users\marck\OneDrive\Bureaublad\technova\C#\projecten\API\WeerApp\WeerAppGegevens.json";
        public string Json = "";
        public static string Plaatsen = @"..\..\Plaatsen.txt";
        public string[] PlaatsArray = File.ReadAllLines(Plaatsen);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CbxPlaats.DataSource = PlaatsArray;
            LoadData();
        }

        public void LoadData()
        {
            string Link = "https://weerlive.nl/api/json-data-10min.php?key=994540e0ad&locatie=" + CbxPlaats.Text;
            WebClient client = new WebClient();
            String content = client.DownloadString(Link);
            Liveweer weerData = JsonConvert.DeserializeObject<Root>(content).liveweer[0];
            Json = JsonConvert.SerializeObject(weerData, Formatting.Indented);
            string verw = "verwachting: " + weerData.verw + "\n";
            string temp = "teperatuur: " + weerData.temp + "°C\ngemiddelde teperatuur: " + weerData.gtemp + "°C\n";
            string neerslag = "neerslag: " + weerData.d0neerslag + "%\n";
            string wind = "windsnelheid: " + weerData.windms + " m/s\nwindrichting: " + weerData.windr + "\n";
            string lucht = "luchtdruk: " + weerData.luchtd + " hPa\nzicht: " + weerData.zicht + " km\n";
            string zon = "zon: " + weerData.d0zon + "%\nzonsopkomst: " + weerData.sup + "\nzonsondergang: " + weerData.sunder; 
            string result = verw + temp + neerslag + wind + lucht + zon;
            RtbResults.Text = result;
        }

        public void Check()
        {
            RtbResults.Text = "";
            for (int i = 0; i < ClbData.CheckedItems.Count; i++)
            {
                string[] Text = { };
                Text[1] = ClbData.CheckedItems[i].ToString();
            }
        }

        private void LoadResults(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SaveJson(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "json files (*.json)|*.json";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog.FileName) == true)
                    {
                        File.Delete(saveFileDialog.FileName);
                    }
                    using (Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                    using (StreamWriter sw = new StreamWriter(s))
                    { 
                        sw.Write(Json);
                    }
                }
            }
        }

        private void LoadJson(object sender, EventArgs e)
        {
            var FileContent = string.Empty;
            var FilePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "json files (*.json)|*.json";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = openFileDialog.FileName;
                    Json = File.ReadAllText(FilePath);
                    Liveweer weerData = JsonConvert.DeserializeObject<Liveweer>(Json);
                    CbxPlaats.Text = weerData.plaats;
                }
            }
        }
    }
}
