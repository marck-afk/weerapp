using System.IO;
using System.Windows.Forms;

namespace WeerApp
{
    public class Files
    {
        // Saves a JSON file.
        public static void Save(string json)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "json files (*.json)|*.json";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        File.Delete(saveFileDialog.FileName);
                    }
                    
                    using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                    using (StreamWriter streamWriter = new StreamWriter(stream))
                    { 
                        streamWriter.Write(json);
                    }
                }
            }
        }

        // Opens / Loads a JSON file.
        public static string Load(string location, CheckBox[] checkboxArray, string json)
        {
            string filePath;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "json files (*.json)|*.json";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    json = File.ReadAllText(filePath);
                    
                    return Data.LoadData(filePath, checkboxArray, json);
                }
            }

            return Data.LoadData(location, checkboxArray, json);
        }
    }
}