using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Media;

using Newtonsoft.Json.Linq;

namespace mapGeneratorZero
{
    class ZeroColor
    {
        public System.Drawing.Color colorTrees = System.Drawing.Color.DarkGreen;
        public System.Drawing.Color colorStones = System.Drawing.Color.Gray;
    }

    public class ZeroMap
    {
        bool loaded;
        bool separated;
        int mapHeight;
        int mapWidth;
        List<Tuple<string, System.Drawing.Color, int, float, float>> biomes; // name, color, spreadStrength, 0-1 treesStrength, 0-1 rocksStrength
        List<Tuple<string, System.Drawing.Color, string, float>> objectsRecipes; // name, color, biomeName ("*" if all), spawnRate
        List<ZeroObject> objects;
        List<ZeroCell> chunks;
        Bitmap mapBitmap;

        public ZeroMap()
        {
            loaded = false;
            biomes = new List<Tuple<string, System.Drawing.Color, int, float, float>>();
            objectsRecipes = new List<Tuple<string, System.Drawing.Color, string, float>>();
            objects = new List<ZeroObject>();
            chunks = new List<ZeroCell>();
            mapBitmap = null;
        }

        public ZeroMap(bool sep, int hei, int wid)
        {
            loaded = false;
            separated = sep;
            mapHeight = hei;
            mapWidth = wid;
            biomes = new List<Tuple<string, System.Drawing.Color, int, float, float>>();
            objectsRecipes = new List<Tuple<string, System.Drawing.Color, string, float>>();
            objects = new List<ZeroObject>();
            chunks = new List<ZeroCell>();
            mapBitmap = null;
        }

        void loadOptions(ZeroSave save)
        {
            /// Loading options to variable
            separated = save.mainSettings.separated;
            mapHeight = save.mainSettings.height;
            mapWidth = save.mainSettings.width;
            foreach(ZeroBiomeSettings biomeSettings in save.mainSettings.biomes)
            {
                string tmpName = biomeSettings.name;
                System.Windows.Media.Color tmpMediaColor = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(biomeSettings.color);
                System.Drawing.Color tmpColor = System.Drawing.Color.FromArgb(tmpMediaColor.A, tmpMediaColor.R, tmpMediaColor.G, tmpMediaColor.B);
                int tmpSpread = biomeSettings.spreadStrength;
                float tmpTrees = (float)biomeSettings.trees;
                float tmpRocks = (float)biomeSettings.rocks;
                biomes.Add(new Tuple<string, System.Drawing.Color, int, float, float>(tmpName, tmpColor, tmpSpread, tmpTrees, tmpRocks));
            }
            foreach(ZeroObjectSettings objectSettings in save.mainSettings.objectRecipes)
            {
                System.Windows.Media.Color tmpMediaColor = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(objectSettings.color);
                objectsRecipes.Add(new Tuple<string, System.Drawing.Color, string, float>(objectSettings.name, System.Drawing.Color.FromArgb(tmpMediaColor.A, tmpMediaColor.R, tmpMediaColor.G, tmpMediaColor.B), objectSettings.name, (float)objectSettings.spawnRate));
            }
            /// ==========

            /// Output options log to 'Generate Map' tab

            /// ==========

            loaded = true;
        }

        Tuple<bool, string> generateMap()
        {

            return Tuple.Create(true, "");
        }
    }

    public class ZeroCell
    {
        ZeroColor zeroColor = new ZeroColor();
        string biomeName;
        System.Drawing.Color biomeColor;
        float trees;
        float rocks;
        int chunkSide = 8;
        int row;
        int col;

        public ZeroCell(string bio, System.Drawing.Color bioC, float t, float roc, int r, int c)
        {
            biomeName = bio;
            biomeColor = bioC;
            trees = t;
            rocks = roc;
            row = r;
            col = c;
        }
    }

    public class ZeroObject
    {
        string name;
        System.Drawing.Color color;
        int chunkRow;
        int chunkCol;
        int positionRow;
        int positionCol;
    }
}
