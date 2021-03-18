using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace WeerApp
{
    public partial class Form1 : Form
    {
        // Variables.
        private string _json = "";
        private readonly string[] _plaatsArray = File.ReadAllLines(@"..\..\Plaatsen.txt");
        private CheckBox[] _checkboxArray;

        public Form1()
        {
            InitializeComponent();
        }

        // Assigns values and placeholders on application launch.
        private void Form1_Load(object sender, EventArgs e)
        {
            CbxPlaats.DataSource = _plaatsArray;
            CbxPlaats.Text = "Amsterdam";
            _checkboxArray = new []{CbxTemperatuur, CbxNeerslag, CbxWind, CbxLucht, CbxZon};
            
            RtbResults.Text = Data.LoadData(CbxPlaats.Text, _checkboxArray);
            _json = Data.ConvertJson();
        }

        // Shows the requested results.
        private void LoadResults(object sender, EventArgs e)
        {
            if (_plaatsArray.Contains(char.ToUpper(CbxPlaats.Text[0]) + CbxPlaats.Text.Substring(1)))
            {
                CbxPlaats.Text = char.ToUpper(CbxPlaats.Text[0]) + CbxPlaats.Text.Substring(1);
                RtbResults.Text = Data.LoadData(CbxPlaats.Text, _checkboxArray);
                _json = Data.ConvertJson();
            }
            else
            {
                MessageBox.Show("PLaats bestaat niet.");
            }
        }

        // Saves the current results.
        private void SaveJson(object sender, EventArgs e)
        {
            Files.Save(_json);
        }

        // Opens/Loads previously saved results.
        private void LoadJson(object sender, EventArgs e)
        {
            RtbResults.Text = Files.Load(CbxPlaats.Text, _checkboxArray, _json);
            _json = Data.ConvertJson();
            CbxPlaats.Text = Data.GetLocation();
        }
    }
}
