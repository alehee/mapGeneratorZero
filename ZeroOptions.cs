using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace mapGeneratorZero
{
    class ZeroOptions
    {
        public ZeroSave save;
        ZeroMap zeroMap;
        Generator generatorWindow;

        public void loadSaveFromFile()
        {
            string jsonPath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                jsonPath = openFileDialog.FileName;

            try{ save = JsonConvert.DeserializeObject<ZeroSave>(File.ReadAllText(jsonPath)); }
            catch(Exception e)
            {
                save = null;
                generatorWindow.Dispatcher.BeginInvoke(new Action(() =>
                {
                    generatorWindow.TB_SettingsSET.Text = "JSON file opening error! \n" + e.ToString();
                }));
            }

            if (save != null)
            {
                refreshOptionsIndicator();

                try { zeroMap.loadOptions(save); }
                catch (Exception e)
                {
                    generatorWindow.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        generatorWindow.TB_SettingsSET.Text = "Options loading error! \n" + e.ToString();
                    }));
                }
            }
        }

        public void refreshOptionsIndicator()
        {
            bool fileIsOk = false;

            try
            {
                if (save.saveType == "map" && save.mainSettings != null)
                    fileIsOk = true;
            }
            catch
            {
                fileIsOk = false;
            }

            if (fileIsOk)
            {
                

                generatorWindow.Dispatcher.BeginInvoke(new Action(() =>
                {
                    generatorWindow.TB_SettingsSET.Text = "";
                    generatorWindow.TB_SettingsSET.Text += "Name: " + save.saveName + "\n";
                    generatorWindow.TB_SettingsSET.Text += "Type: " + save.saveType + "\n";
                    generatorWindow.TB_SettingsSET.Text += "Version: " + save.saveVersion + "\n";
                    generatorWindow.TB_SettingsSET.Text += "Main settings: \n";
                    generatorWindow.TB_SettingsSET.Text += "    Separated: " + save.mainSettings.separated + "\n";
                    generatorWindow.TB_SettingsSET.Text += "    Height: " + save.mainSettings.height + "\n";
                    generatorWindow.TB_SettingsSET.Text += "    Width: " + save.mainSettings.width + "\n";
                    generatorWindow.TB_SettingsSET.Text += "    Biomes: \n";
                    foreach (ZeroBiomeSettings biome in save.mainSettings.biomes)
                    {
                        generatorWindow.TB_SettingsSET.Text += "        { \n";
                        generatorWindow.TB_SettingsSET.Text += "            Name: " + biome.name + "\n";
                        generatorWindow.TB_SettingsSET.Text += "            Color: " + biome.color + "\n";
                        generatorWindow.TB_SettingsSET.Text += "            Spread Str.: " + biome.spreadStrength + "\n";
                        generatorWindow.TB_SettingsSET.Text += "            Trees: " + biome.trees + "\n";
                        generatorWindow.TB_SettingsSET.Text += "            Rocks: " + biome.rocks + "\n";
                        generatorWindow.TB_SettingsSET.Text += "        }, \n";
                    }
                    generatorWindow.TB_SettingsSET.Text += "    Object Recipes: \n";
                    foreach (ZeroObjectSettings obj in save.mainSettings.objectRecipes)
                    {
                        generatorWindow.TB_SettingsSET.Text += "        { \n";
                        generatorWindow.TB_SettingsSET.Text += "        Name:" + obj.name + "\n";
                        generatorWindow.TB_SettingsSET.Text += "        Color:" + obj.color + "\n";
                        generatorWindow.TB_SettingsSET.Text += "        Biome:" + obj.biome + "\n";
                        generatorWindow.TB_SettingsSET.Text += "        Spawn Rate:" + obj.spawnRate + "\n";
                        generatorWindow.TB_SettingsSET.Text += "        }, \n";
                    }
                }));

                // IF LOADED SETTINGS ARE FOR 'map' SET MAP INDICATOR INFORMATION
                if(save.saveType == "map")
                {
                    generatorWindow.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        generatorWindow.TB_SettingsGEN.Text = generatorWindow.TB_SettingsSET.Text;
                    }));
                }
            }
            else
            {
                generatorWindow.Dispatcher.BeginInvoke(new Action(() =>
                {
                    generatorWindow.TB_SettingsSET.Text = "File type is incorrect! Check the file and try again!";
                }));
            }
        }

        public ZeroOptions(Generator window, ZeroMap zm)
        {
            generatorWindow = window;
            zeroMap = zm;
        }
    }

    class ZeroSave
    {
        public string saveName;
        public string saveType;
        public double saveVersion;
        public ZeroMainSettings mainSettings;
    }

    class ZeroMainSettings
    {
        public bool separated;
        public int height;
        public int width;
        public List<ZeroBiomeSettings> biomes;
        public List<ZeroObjectSettings> objectRecipes;
    }

    class ZeroBiomeSettings
    {
        public string name;
        public string color;
        public int spreadStrength;
        public double trees;
        public double rocks;
    }

    class ZeroObjectSettings
    {
        public string name;
        public string color;
        public string biome;
        public double spawnRate;
    }

    /*
    {
      "saveName": "exampleName", // Name of the save
      "saveType": "map", // Type of the save
      "saveVersion": 1.0, // Version of the save (can be modified in future)
      "mainSettings": { // Main settings of the map generator
        "separated": true, // Is map going to be separated by wall
        "height": 100, // Amount of height chunks
        "width": 30, // Amount of width chunks
        "biomes": [ // Biomes list for the map
          {
            "name": "Desert", // Displayed name of the biome
            "color": "#FFFF00", // Main color
            "spreadStrength": 5, // Biome strength on map
            "trees": 0, // 0-1 scale how much trees
            "rocks": 0.5 // 0-1 scale how much rocks
          },
          {
            "name": "Meadow",
            "color": "#00FF55",
            "spreadStrength": 9,
            "trees": 0.3,
            "rocks": 0.1
          }
        ],
        "objectRecipes": [ // List of custom objects on map
          {
            "name": "Dungeon", // Name of the object
            "color": "#0000FF", // Color on the map
            "biome": "Desert", // On which biome should be spawned, "*" for all
            "spawnRate": 1 // How many should spawn on map
          }
        ]
      }
    }
    */
}