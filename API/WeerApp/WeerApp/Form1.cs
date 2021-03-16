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

namespace WeerApp
{
    public partial class Form1 : Form
    { 
        public string Path = @"C:\Users\marck\OneDrive\Bureaublad\technova\C#\projecten\API\WeerApp\WeerAppGegevens.json";
        public static string Plaatsen = @"C:\Users\marck\OneDrive\Bureaublad\technova\C#\projecten\API\WeerApp\WeerApp\Plaatsen.txt";
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
            RtbResults.Text = weerData.samenv;
        }

        private void LoadResults(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
